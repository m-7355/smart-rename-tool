using FileRenamerPro.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamerPro.Services
{
    public class Renamer
    {
        public string Rename(string beforFile, RenameOptions options)
        {
            // 拡張子を保存
            string ext = Path.GetExtension(beforFile);

            // 桁数を反映させるための一番でデフォルトな書き方
            string number = options.currentNumber.ToString(new string('0', options.digits));

            // 新しい名前生成
            string newName = options.firstName + "_" + number + "_" + options.lastName + ext;

            // 次のファイルのために番号を増やす
            options.currentNumber++;

            return newName;
        }

    }
}
