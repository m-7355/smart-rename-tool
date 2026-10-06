using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamerPro.Services
{
    /// <summary>
    /// 各コンポーネントからリネームに必要な情報を保持するクラス
    /// </summary>
    public class RenameOptions
    {
        public string firstName {  get; set; }
        public int startNumbers { get; set; }
        public int digits { get; set; }
        public string lastName { get; set; }
        public int currentNumber { get; set; }
    }
}
