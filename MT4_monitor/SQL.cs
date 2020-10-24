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

        public void UpdateTable()
        {
            MySqlConnection conn = new MySqlConnection(GetConnectionString());
            string sqlquery = "SELECT * FROM `accounts`;";

            try
            {
                conn.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter(sqlquery, conn);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                //DataGridView dgw = new DataGridView();
                //dgw.DataSource = DATA;
                DateTime timeNow = DateTime.Now;
                DateTime dbTime = new DateTime();
                //Обновляем содержимое столбцов (Баланс, Сделки, Время)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < DATA.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value) == Convert.ToInt32(DATA.Rows[j][0]))
                        {
                            dataGridView.Rows[i].Cells[2].Value = DATA.Rows[j][2];
                            dataGridView.Rows[i].Cells[3].Value = DATA.Rows[j][3];
                            dataGridView.Rows[i].Cells[4].Value = DATA.Rows[j][4];
                        }
                    }

                    //Перекрашиваем ячейки со временем
                    dbTime = Convert.ToDateTime(dataGridView.Rows[i].Cells[4].Value.ToString());
                    if (dbTime.AddSeconds(5) < timeNow)
                        dataGridView.Rows[i].Cells[4].Style.BackColor = System.Drawing.Color.Tomato;
                    else
                        dataGridView.Rows[i].Cells[4].Style.BackColor = System.Drawing.Color.PaleGreen;
                }
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

        public void SendCloseAllSignal()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView.Rows[i].Cells[5].EditedFormattedValue))
                {
                    string sqlExpression = String.Format("UPDATE accounts SET close = True WHERE account = {0}", dataGridView.Rows[i].Cells[0].Value);

                    using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                    {
                        //connection.Open();
                        MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                    }

                    dataGridView.Rows[i].Cells[5].Value = 0;
                    //dataGridView.Refresh();
                }
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
