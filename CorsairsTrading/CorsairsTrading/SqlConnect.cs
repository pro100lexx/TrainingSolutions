using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorsairsTrading
{
    public partial class MainForm : Form
    {
        public static void ConnectSQL()
        {
            SqlConnection conn;
            //Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=CorsairsStores;User ID=sa;Password=***********
            using (conn = new SqlConnection(@"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=CorsairsStores;User ID=sa;Password=1qA-2wS-3eD"))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Соединено");
                    conn.Close();
                }
                catch (Exception help)
                {
                    MessageBox.Show(help.Message);
                }
            }
        }
    }
}
