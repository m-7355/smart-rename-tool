using FileRenamerPro.Model;
using FileRenamerPro.Services;
using FileRenamerPro.Services.Undo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamerPro.Managers
{
    /// <summary>
    /// 各機能呼び出し用の管理クラス
    /// </summary>
    public class RenameManager
    {
        /// <summary>
        /// 各機能呼び出し用
        /// </summary>
        private readonly RenameCoordinator renameCoordinator = new RenameCoordinator();
        private readonly RenameExcuter renameExcuter = new RenameExcuter();
        private readonly UndoManager undoManager = new UndoManager();
        private readonly UndoPreviewBuilder undoPreviewBuilder = new UndoPreviewBuilder();

        /// <summary>
        /// プレビュー作成
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public List<RenameDataInfo> BuildPreviewData(string folderPath, RenameOptions options)
            => renameCoordinator.BuildPreviewData(folderPath, options);

        /// <summary>
        /// リネーム実行
        /// </summary>
        /// <param name="items"></param>
        public void Excute(List<RenameDataInfo> items)
            => renameExcuter.Excute(items);

        /// <summary>
        /// スタックに修正後データ保存
        /// </summary>
        /// <param name="items"></param>
        public void Push(List<RenameDataInfo> items)
            => undoManager.Push(items);

        /// <summary>
        /// 現データ取得
        /// </summary>
        public List<RenameDataInfo> Peek()
            => undoManager.Peek();

        /// <summary>
        /// ロールバック対象(スタックの先頭)を取得
        /// </summary>
        public List<UndoDataInfo> UndoPreviewBuilder()
            => undoPreviewBuilder.UndoPreviewBuild(undoManager.Peek());

        // 修復実行
        public void Undo()
            => undoManager.Undo();
    }
}
