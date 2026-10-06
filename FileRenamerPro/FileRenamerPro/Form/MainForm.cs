using System;
using System.IO;
using System.Windows.Forms;
using FileRenamerPro.Services;
using FileRenamerPro.Model;
using FileRenamerPro.Managers;

namespace FileRenamerPro
{
    public partial class MainForm : Form
    {
        private DataInfo data = new DataInfo();
        private RenameManager renamemanager = new RenameManager();

        public MainForm()
        {
            InitializeComponent();

            // フォルダー選択時、カーソルを手の形にする
            SelectFolder_bt.MouseEnter += (s, e) => { SelectFolder_bt.Cursor = Cursors.Hand; };
        }

        /// <summary>
        /// フォルダ選択ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFolder_bt_Click(object sender, EventArgs e)
        {
            var select = FolderSelector.Select();

            if (!string.IsNullOrEmpty(select))
            {
                data.path = select;
                SelectFolderPath_txb.Text = data.path;
            }
        }

        /// <summary>
        /// ドラッグアンドドロップでフォルダを選択したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // フォルダの複数選択可能なため配列
            // 仕様上どうしても配列になる
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (paths.Length == 1 && Directory.Exists(paths[0]))
            {
                data.path = paths[0];
                SelectFolderPath_txb.Text = paths[0];
            }
        }

        /// <summary>
        /// ドラッグアンドドロップされた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // フォルダの複数選択可能なため配列
                // 仕様上どうしても配列になる
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);

                // ドラッグしてきたデータがあるか&&フォルダか判定
                if (paths.Length == 1 && Directory.Exists(paths[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }

            e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// プレビューボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Preview_bt_Click(object sender, EventArgs e)
        {
            // フォルダーnullチェック
            if(data.path == null)
            {
                MessageBox.Show("フォルダを選択してください。");
                return;
            }

            // 各テキストボックス空文字チェック
            if (FirstName_txb.Text == "" || StartNumber_txb.Text == "" || NumberLength_txb.Text == "")
            {
                MessageBox.Show("未入力の項目があります。");
                return;
            }

            // 各テキストボックスの内容をセット
            var options = new RenameOptions
            {
                firstName = FirstName_txb.Text,
                startNumbers = int.Parse(StartNumber_txb.Text),
                digits = int.Parse(NumberLength_txb.Text),
                lastName = LastName_txb.Text
            };

            // プレビュー作成
            data.items = renamemanager.BuildPreviewData(data.path, options);

            // DGVに連携
            Preview_dgv.DataSource = data.items;

            // ヘッダーネームを最適化するprivateメソッドを呼ぶ
            SetHeaders();
        }

        /// <summary>
        /// 続行ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Excute_bt_Click(object sender, EventArgs e)
        {
            // フォルダーnullチェック
            if (data.path == null)
            {
                MessageBox.Show("フォルダを選択してください。");
                return;
            }

            // 各テキストボックス空文字チェック
            if (FirstName_txb.Text == "" || StartNumber_txb.Text == "" || NumberLength_txb.Text == "")
            {
                MessageBox.Show("未入力の項目があります。");
                return;
            }

            if (MessageBox.Show("プレビューは確認しましたか？", "確認",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (MessageBox.Show("リネームを実行しますか？", "確認",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // 現データをスタックに保存
            renamemanager.Push(data.items);

            // リネーム実行
            renamemanager.Excute(data.items);            
        }

        /// <summary>
        /// テキストボックス処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNumber_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyEvents.ValidateNumericKey(e);
        }

        private void NumberLength_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyEvents.ValidateNumericKey(e);
        }

        /// <summary>
        /// ロールバックボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Undo_bt_Click(object sender, EventArgs e)
        {
            var peekData = renamemanager.Peek();

            // stakのnullチェック
            if (peekData == null)
            {
                MessageBox.Show("履歴が存在しません。");
                return;
            }

            // stakデータがあればUndoFormにRenameManagerを渡す
            var undoForm = new UndoForm(renamemanager);
            undoForm.ShowDialog();
        }

        /// <summary>
        /// ヘッダー変更のprivateメソッド
        /// </summary>
        void SetHeaders()
        {
            Preview_dgv.Columns[nameof(RenameDataInfo.beforName)].HeaderText = "元の名前";
            Preview_dgv.Columns[nameof(RenameDataInfo.beforPath)].HeaderText = "元のパス";
            Preview_dgv.Columns[nameof(RenameDataInfo.afterName)].HeaderText = "変更後の名前";
            Preview_dgv.Columns[nameof(RenameDataInfo.afterPath)].HeaderText = "変更後のパス";
            Preview_dgv.Columns[nameof(RenameDataInfo.createTime)].HeaderText = "作成日時";
            Preview_dgv.Columns[nameof(RenameDataInfo.modifiedTime)].HeaderText = "変更日時";
            Preview_dgv.Columns[nameof(RenameDataInfo.accessedTime)].HeaderText = "アクセス日時";
        }
    }
}