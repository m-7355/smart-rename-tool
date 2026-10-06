using FileRenamerPro.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamerPro.Services
{
    /// <summary>
    /// プレビュー構築
    /// </summary>
    public class RenameCoordinator
    {
        private readonly PreviewBuilder previewBuilder = new PreviewBuilder();
        private readonly Renamer renamer = new Renamer();

        public List<RenameDataInfo> BuildPreviewData(string folderPath, RenameOptions options)
        {
            // フォルダ内のファイルの情報を取得
            var list = previewBuilder.BuildPreviewData(folderPath);

            // 連番の開始値をオプションにセット
            options.currentNumber = options.startNumbers;

            // 各ファイルの新しい名前とパスを生成
            foreach (var item in list)
            {
                item.afterName = renamer.Rename(item.beforName, options);
                item.afterPath = Path.Combine(folderPath, item.afterName);
            }

            return list;
        }
    }
}
