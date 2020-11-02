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
    public partial class MT4_monitor : Form
    {
        public MT4_monitor()
        {
            InitializeComponent();
        }

        private void MT4_monitor_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(buttonRefresh, "Обновление данных из БД каждую секунду");
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(buttonReload, "Полностью перезагружает таблицу из БД");
            ToolTip t3 = new ToolTip();
            t3.SetToolTip(buttonDBset, "Настройки подключения к БД");

            if (Properties.Settings.Default.host == "")
            {
                CredentialsEnter credentialsEnter = new CredentialsEnter();
                credentialsEnter.ShowDialog();
            }
            
            if (CheckForInternetConnection())
            {
                Text = "Мониторинг счетов MT4";
                LoadTable();
            }
            else
            {
                Text = "Internet connection failed!";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (buttonRefresh.Text == "Старт")
            {
                buttonRefresh.BackColor = Color.Tomato;
                buttonRefresh.Text = "СТОП";
                timerForRefresh.Start();
            }
            else
            {
                buttonRefresh.BackColor = Color.PaleGreen;
                buttonRefresh.Text = "Старт";
                timerForRefresh.Stop();
            }
        }

        private void timerForRefresh_Tick(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                Text = "Мониторинг счетов MT4";
                UpdateTable();
                SendCloseAllSignal();
            }
            else
            {
                Text = "Internet connection failed!";

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Cells[4].Style.BackColor = System.Drawing.Color.Tomato;
                }
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                LoadTable();
            }
            else
            {
                MessageBox.Show("Интернет подключение отсутствует");
            }
        }

        private void buttonCloseALL_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите закрыть ВСЕ сделки на ВСЕХ счетах?", "Требуется подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SetAllCheckBoxesTrue();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void buttonDBset_Click(object sender, EventArgs e)
        {
            CredentialsEnter credentialsEnter = new CredentialsEnter();
            credentialsEnter.ShowDialog();
        }
    }
}
