using FileRenamerPro.Model;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamerPro.Managers
{
    /// <summary>
    /// ロールバック管理クラス
    /// </summary>
    public class UndoManager
    {
        // ロールバック用スタック
        private Stack<List<RenameDataInfo>> undoStack = new Stack<List<RenameDataInfo>>();

        // json保存用
        private readonly string appFolder;
        private readonly string undoFilePath;

        // Json読み込み
        public UndoManager()
        {
            // アプリケーションデータフォルダのパスを取得
            appFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "FileRenamerPro");

            // ファイルパス設定
            undoFilePath = Path.Combine(appFolder, "undo.sysdata");

            // 履歴読み込み
            LoadHistory();
        }

        /// <summary>
        /// Json にシリアライズしてロールバック履歴を保存
        /// </summary>
        private void SaveHistory()
        {
            // フォルダがなければ作成
            if (!Directory.Exists(appFolder))
                Directory.CreateDirectory(appFolder);

            // 書き込み前に属性を Normal に戻す（重要）
            if (File.Exists(undoFilePath))
                File.SetAttributes(undoFilePath, FileAttributes.Normal);

            // スタックを JSON にシリアライズして保存
            var jsonUndo = JsonConvert.SerializeObject(undoStack, Formatting.Indented);
            File.WriteAllText(undoFilePath, jsonUndo);

            // 書き込み後に Hidden属性を付ける
            File.SetAttributes(undoFilePath, FileAttributes.Hidden);
        }

        /// <summary>
        /// Json からロールバック履歴を読み込む
        /// </summary>
        private void LoadHistory()
        {
            if (File.Exists(undoFilePath))
            {
                try
                {
                    var json = File.ReadAllText(undoFilePath);
                    var data = JsonConvert.DeserializeObject<Stack<List<RenameDataInfo>>>(json);

                    undoStack = data ?? new Stack<List<RenameDataInfo>>();
                }
                catch
                {
                    // JSON が壊れていた場合は新規スタックとして扱う
                    undoStack = new Stack<List<RenameDataInfo>>();
                }
            }
            else
            {
                undoStack = new Stack<List<RenameDataInfo>>();
            }
        }

        /// <summary>
        /// データをスタック方式で格納
        /// </summary>
        /// <param name="items"></param>
        public void Push(List<RenameDataInfo> items)
        {
            undoStack.Push(Clone(items));
            SaveHistory();
        }

        /// <summary>
        /// UIに表示するためスタックの先頭データを取得
        /// </summary>
        /// <returns></returns>
        public List<RenameDataInfo> Peek()
        {
            // スタックにデータがあるかチェック
            // ある場合は深いコピーを返す（重要）
            return undoStack.Count > 0 ? Clone(undoStack.Peek()) : null;
        }

        /// <summary>
        /// ロールバック実行
        /// </summary>
        /// <returns></returns>
        public List<RenameDataInfo> Undo()
        {
            // スタックにデータがあるかチェック
            if (undoStack.Count == 0) return null;

            var items = undoStack.Pop();

            foreach(var item in items)
            {
                try
                {
                    // 元フォルダが無けれは作る
                    var dir = Path.GetDirectoryName(item.beforPath);

                    if(!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                    // フォルダ先にファイルがなければスキップ
                    if (!File.Exists(item.afterPath)) continue;

                    // ファイル修復
                    File.Move(item.afterPath, item.beforPath);

                    // 日付も戻しておく
                    File.SetCreationTime(item.beforPath, item.createTime);  
                    File.SetLastWriteTime(item.beforPath, item.modifiedTime);
                    File.SetLastAccessTime(item.beforPath, item.accessedTime);
                }
                catch (Exception ex)
                {
                    // エラー処理（例: ログ出力）
                    Console.WriteLine($"エラーが発生しました: {ex.Message}");
                    continue; // エラーが発生しても次のアイテムに進む
                }
            }
            SaveHistory();

            return items;
        }

        // -------------------------
        // 深いコピー（重要）
        // -------------------------
        private List<RenameDataInfo> Clone(List<RenameDataInfo> items)
        {
            var newList = new List<RenameDataInfo>();
            foreach (var i in items)
            {
                newList.Add(new RenameDataInfo
                {
                    beforName = i.beforName,
                    beforPath = i.beforPath,
                    afterName = i.afterName,
                    afterPath = i.afterPath,
                    createTime = i.createTime,
                    modifiedTime = i.modifiedTime,
                    accessedTime = i.accessedTime
                });
            }
            return newList;
        }

    }
}
