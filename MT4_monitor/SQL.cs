using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MT4_monitor
{
    public partial class MT4_monitor : Form
    {
        //Загружает данные из SQL и перегружает DataGridView полностью
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
        
        //Обновляет данные в уже отрисованной таблице
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
                Text = "Connection failed!";
                //MessageBox.Show(ex.Message);
                //Мониторинг счетов MT4
            }
            finally
            {
                conn.Close();
            }
        }

        //Проверяет чекбоксы и отправляет в БД сигналы закрытия
        public void SendCloseAllSignal()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView.Rows[i].Cells[5].EditedFormattedValue))
                {
                    string sqlExpression = String.Format("UPDATE accounts SET close = True WHERE account = {0}", dataGridView.Rows[i].Cells[0].Value);

                    using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                    }
                    dataGridView.Rows[i].Cells[5].Value = 0;
                    dataGridView.RefreshEdit();
                }
            }
        }

        //Устанавливает все чекбоксы в положение True
        public void SetAllCheckBoxesTrue()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[5].Value = 1;
            }
            dataGridView.RefreshEdit();
        }

        private string GetConnectionString()
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = Properties.Settings.Default.host;        // IP адрес БД
            mysqlCSB.Port = 3306;                                      // Порт
            mysqlCSB.Database = Properties.Settings.Default.database;  // Имя БД
            mysqlCSB.UserID = Properties.Settings.Default.login;       // Имя пользователя БД
            mysqlCSB.Password = Properties.Settings.Default.pwd;       // Пароль пользователя БД

            return mysqlCSB.ConnectionString;
        }
    }
}
