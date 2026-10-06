using FileRenamerPro.Managers;
using FileRenamerPro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamerPro
{
    public partial class UndoForm : Form
    {
        // 各機能呼び出し用
        RenameManager renameManager = new RenameManager();

        public UndoForm(RenameManager renameManager)
        {
            InitializeComponent();

            // 呼び出し元からRenameManagerを受け取る
            this.renameManager = renameManager;
        }

        /// <summary>
        /// Undo画面に遷移したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoForm_Load(object sender, EventArgs e)
        {
            // stakのデータ参照
            var peekData = renameManager.Peek();

            // 現データとロールバック対象をDGVに表示
            UndoResult_dgv.DataSource = renameManager.UndoPreviewBuilder();

            // ヘッダー名変更
            SetHeaders();
        }

        /// <summary>
        /// 修復するボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Excute_btn_Click(object sender, EventArgs e)
        {
            renameManager.Undo();

            MessageBox.Show("ファイルの修復が完了しました。");

            // 1回実行したら押せないようにする
            Excute_btn.Enabled = false;
        }

        /// <summary>
        /// ヘッダー変更のprivateメソッド
        /// </summary>
        void SetHeaders()
        {
            UndoResult_dgv.Columns[nameof(UndoDataInfo.beforName)].HeaderText = "現在の名前";
            UndoResult_dgv.Columns[nameof(UndoDataInfo.beforPath)].HeaderText = "現在のパス";
            UndoResult_dgv.Columns[nameof(UndoDataInfo.afterName)].HeaderText = "修復後の名前";
            UndoResult_dgv.Columns[nameof(UndoDataInfo.afterPath)].HeaderText = "修復後のパス";
            UndoResult_dgv.Columns[nameof(UndoDataInfo.createTime)].HeaderText = "作成日時";
            UndoResult_dgv.Columns[nameof(UndoDataInfo.modifiedTime)].HeaderText = "変更日時";
            UndoResult_dgv.Columns[nameof(UndoDataInfo.accessedTime)].HeaderText = "アクセス日時";
        }

    }
}
