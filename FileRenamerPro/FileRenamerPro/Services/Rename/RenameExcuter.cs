using FileRenamerPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileRenamerPro.Services
{
    public class RenameExcuter
    {
        /// <summary>
        /// リネーム実行
        /// </summary>
        /// <param name="items"></param>
        /// <exception cref="Exception"></exception>
        public void Excute(List<RenameDataInfo> items)
        {
            try
            {
                foreach (var item in items)
                {
                    // ファイルのリネーム
                    File.Move(item.beforPath, item.afterPath);
                }
                MessageBox.Show("リネームに成功しました。");
            }
            catch (Exception e)
            {
                throw new Exception("リネームに失敗しました。:" + e.Message);
            }
        }

    }
}
