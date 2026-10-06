using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamerPro.Services
{
    /// <summary>
    /// フォルダー選択
    /// </summary>
    public class FolderSelector
    {
        public static string Select()
        {
            using (var folder = new FolderBrowserDialog())
            {
                folder.Description = "フォルダーを選択してください。";
                folder.SelectedPath = @"c:\";

                // フォルダ選択ダイアログ表示
                DialogResult result = folder.ShowDialog();

                // OK/キャンセル押下時処理
                if (result == DialogResult.OK) return folder.SelectedPath;

                return null;
            }
        }
    }
}
