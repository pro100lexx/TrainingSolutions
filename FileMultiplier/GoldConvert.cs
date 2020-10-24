using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMultiplier
{
    public partial class MainForm : Form
    {
        private void GoldConvertation(string senderPath, string receiverPath)
        {
            string str = string.Empty;
            using (System.IO.StreamReader reader = System.IO.File.OpenText(senderPath))
            {
                str = reader.ReadToEnd();
            }
            str = str.Replace("GOLD", "XAUUSD");

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(receiverPath))
            {
                file.Write(str);
            }
        }
    }
}
