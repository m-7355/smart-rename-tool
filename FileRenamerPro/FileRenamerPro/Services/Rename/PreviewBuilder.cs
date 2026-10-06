using FileRenamerPro.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamerPro.Services
{
    public class PreviewBuilder
    {
        /// <summary>
        /// プレビューデータ格納
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public List<RenameDataInfo> BuildPreviewData(string folderPath)
        {
            // フォルダ内のファイルを取得
            var file = Directory.GetFiles(folderPath);

            // ファイル名でソート
            var files = Directory.GetFiles(folderPath)
                         .OrderBy(f => f)   
                         .ToList();

            // 元データ保存
            var list = file.Select(f => new RenameDataInfo
            {
                beforName = Path.GetFileName(f),
                beforPath = f,
                createTime = File.GetCreationTime(f),
                modifiedTime = File.GetLastWriteTime(f),
                accessedTime = File.GetLastAccessTime(f),
            }).ToList();

            return list;
        }

    }
}
