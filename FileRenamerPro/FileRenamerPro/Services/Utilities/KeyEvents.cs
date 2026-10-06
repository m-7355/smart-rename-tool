using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamerPro.Services
{
    /// <summary>
    /// キーイベントの処理
    /// </summary>
    public class KeyEvents
    {
        public static void ValidateNumericKey(KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値1～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '1' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
