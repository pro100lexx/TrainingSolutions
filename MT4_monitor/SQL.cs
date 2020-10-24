using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MT4_monitor
{
    public partial class MT4_monitor : Form
    {
        public void LoadTable()
        {
            MySqlConnection conn = new MySqlConnection(GetConnectionString());
            string sqlquery = "SELECT * FROM `accounts`;";

            try
            {
                conn.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter(sqlquery, conn);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                dataGridView.DataSource = DATA;
                DateTime timeNow = DateTime.Now;
                DateTime dbTime = new DateTime();
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    dbTime = Convert.ToDateTime(dataGridView.Rows[i].Cells[4].Value.ToString());
                    if (dbTime.AddSeconds(5) < timeNow)
                    {
                        dataGridView.Rows[i].Cells[4].Style.BackColor = System.Drawing.Color.Tomato;
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[4].Style.BackColor = System.Drawing.Color.PaleGreen;
                    }
                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private string GetConnectionString()
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "185.246.65.19";        // IP адрес БД
            mysqlCSB.Port = 3306;                     // Порт
            mysqlCSB.Database = "mt_monitor";         // Имя БД
            mysqlCSB.UserID = "mt_monitor";           // Имя пользователя БД
            mysqlCSB.Password = "aRXgaOp4UIcXvDDu";   // Пароль пользователя БД

            return mysqlCSB.ConnectionString;
        }

    }
}
