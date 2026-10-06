using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamerPro.Model
{
    public class DataInfo
    {
        // 選択されたファイル
        public String path {  get; set; }

        // リネームデータ
        public List<RenameDataInfo> items {  get; set; }
    }
}
