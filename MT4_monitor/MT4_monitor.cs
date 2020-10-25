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
            LoadTable();
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
            UpdateTable();
            SendCloseAllSignal();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetAllCheckBoxesTrue();
        }
    }
}
