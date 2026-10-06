using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamerPro.Model
{
    /// <summary>
    /// リネームに必要なデータを保持するクラス
    /// </summary>
    public class RenameDataInfo
    {
        public string beforName {  get; set; }
        public string afterName { get; set; }
        public string beforPath { get; set; }
        public string afterPath { get; set; }
        public DateTime createTime { get; set; }
        public DateTime modifiedTime { get; set; }
        public DateTime accessedTime { get; set; }
    }
}
