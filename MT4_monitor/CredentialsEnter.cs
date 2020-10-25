using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MT4_monitor
{
    public partial class CredentialsEnter : Form
    {
        public CredentialsEnter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.host = textBoxServer.Text;
            Properties.Settings.Default.database = textBoxDB.Text;
            Properties.Settings.Default.login = textBoxUser.Text;
            Properties.Settings.Default.pwd = textBoxPwd.Text;
            Properties.Settings.Default.Save();

            MySqlConnection conn = new MySqlConnection(GetConnectionString());

            try
            {
                conn.Open();
                MessageBox.Show("Соединение успешно установлено.\nДанные для подключения сохранены.\nОкно с настройками можно закрыть.");
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
            mysqlCSB.Server = Properties.Settings.Default.host;        // IP адрес БД
            mysqlCSB.Port = 3306;                                      // Порт
            mysqlCSB.Database = Properties.Settings.Default.database;  // Имя БД
            mysqlCSB.UserID = Properties.Settings.Default.login;       // Имя пользователя БД
            mysqlCSB.Password = Properties.Settings.Default.pwd;       // Пароль пользователя БД

            return mysqlCSB.ConnectionString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CredentialsEnter_Load(object sender, EventArgs e)
        {
            textBoxServer.Text = Properties.Settings.Default.host;
            textBoxDB.Text = Properties.Settings.Default.database;
            textBoxUser.Text = Properties.Settings.Default.login;
            textBoxPwd.Text = Properties.Settings.Default.pwd;
        }
    }
}
