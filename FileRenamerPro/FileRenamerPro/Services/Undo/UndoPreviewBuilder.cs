using FileRenamerPro.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamerPro.Services.Undo
{
    /// <summary>
    /// ロールバックデータ格納
    /// </summary>
    public class UndoPreviewBuilder
    {
        public List<UndoDataInfo> UndoPreviewBuild(List<RenameDataInfo> items)
        {
            if (items == null) return null;

            return items.Select(x => new UndoDataInfo
            {
                beforName = x.afterName,
                beforPath = x.afterPath,
                afterName = x.beforName,
                afterPath = x.beforPath,
                createTime = File.GetCreationTime(x.afterPath),
                modifiedTime = File.GetLastWriteTime(x.afterPath),
                accessedTime = File.GetLastAccessTime(x.afterPath)
            }).ToList();

        }
    }
}
