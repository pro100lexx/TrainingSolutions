using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorsairsTrading
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label5.Paint += Label5_Paint;
            label7.Paint += Label7_Paint;
            label8.Paint += Label8_Paint;
            label9.Paint += Label9_Paint;
        }

        #region ROTATE LABELS
        private void Label5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(label5.Text, label5.Font);
            label5.Width = (int)textSize.Height + 2;
            label5.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-label5.Height / 2, label5.Width / 2);
            e.Graphics.DrawString(label5.Text, label5.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }

        private void Label7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(label7.Text, label7.Font);
            label7.Width = (int)textSize.Height + 2;
            label7.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-label7.Height / 2, label7.Width / 2);
            e.Graphics.DrawString(label7.Text, label7.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }

        private void Label8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(label8.Text, label8.Font);
            label8.Width = (int)textSize.Height + 2;
            label8.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-label8.Height / 2, label8.Width / 2);
            e.Graphics.DrawString(label8.Text, label8.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }

        private void Label9_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(label9.Text, label9.Font);
            label9.Width = (int)textSize.Height + 2;
            label9.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-label9.Height / 2, label9.Width / 2);
            e.Graphics.DrawString(label9.Text, label9.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetCSdb.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.dataSetCSdb.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetCSdb.Towns". При необходимости она может быть перемещена или удалена.
            this.townsTableAdapter1.Fill(this.dataSetCSdb.Towns);
            dgwTownBuy.Columns.Add("TownBuy", "TownBuy");
            dgwTownBuy.Columns.Add("ProductName", "ProductName");
            dgwWeight.Columns.Add("Weight", "Weight");
            dgwHighrock.Columns.Add("TSell", "TSell");
            dgwTendeils.Columns.Add("TSell", "TSell");
            dgwDIsland.Columns.Add("TSell", "TSell");
            dgwProfit.Columns.Add("Town", "Город");
            dgwProfit.Columns.Add("Product", "Товар");
            dgwProfit.Columns.Add("Profit", "Выгода");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int comboIndex = comboBoxSelectTown.SelectedIndex;
            switch (comboIndex)
            {
                case 0: comboIndex = 4; break;
                case 1: comboIndex = 6; break;
                case 2: comboIndex = 8; break;
                default: comboIndex = 2; break;
            }

            label6.Text = comboBoxSelectTown.Text;
            label6.BackColor = Color.Transparent;
            dgwTownBuy.Rows.Clear();
            dgwWeight.Rows.Clear();
            dgwHighrock.Rows.Clear();
            dgwTendeils.Rows.Clear();
            dgwDIsland.Rows.Clear();
            dgwProfit.Rows.Clear();

            for (int i = 0; i < dataSetCSdb.Products.Rows.Count; i++)
            {
                dgwTownBuy.Rows.Add(dataSetCSdb.Products.Rows[i][1], dataSetCSdb.Products.Rows[i][comboIndex]);
                dgwWeight.Rows.Add(dataSetCSdb.Products.Rows[i][2]);
                dgwHighrock.Rows.Add(dataSetCSdb.Products.Rows[i][3]);
                dgwTendeils.Rows.Add(dataSetCSdb.Products.Rows[i][5]);
                dgwDIsland.Rows.Add(dataSetCSdb.Products.Rows[i][7]);

                //Хайрок
                if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][3]) != 0 && Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]) != 0)
                {
                    if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][3]) > Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                    {
                        dgwHighrock.Rows[i].Cells[0].Style.BackColor = Color.PaleGreen;
                        dgwProfit.Rows.Add("Хайрок", dataSetCSdb.Products.Rows[i][1],
                            (Convert.ToInt32(dataSetCSdb.Products.Rows[i][3]) - Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                            * (Convert.ToInt32(textBoxCapacity.Text) / Convert.ToInt32(dataSetCSdb.Products.Rows[i][2])));
                    }

                    if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][3]) < Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                    {
                        dgwHighrock.Rows[i].Cells[0].Style.BackColor = Color.DarkSalmon;
                    }
                }

                //Тендейлз
                if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][5]) != 0 && Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]) != 0)
                {
                    if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][5]) > Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                    {
                        dgwTendeils.Rows[i].Cells[0].Style.BackColor = Color.PaleGreen;
                        dgwProfit.Rows.Add("Тендейлз", dataSetCSdb.Products.Rows[i][1],
                            (Convert.ToInt32(dataSetCSdb.Products.Rows[i][5]) - Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                            * (Convert.ToInt32(textBoxCapacity.Text) / Convert.ToInt32(dataSetCSdb.Products.Rows[i][2])));
                    }

                    if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][5]) < Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                    {
                        dgwTendeils.Rows[i].Cells[0].Style.BackColor = Color.DarkSalmon;
                    }
                }

                //М. Остров
                if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][7]) != 0 && Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]) != 0)
                {
                    if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][7]) > Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                    {
                        dgwDIsland.Rows[i].Cells[0].Style.BackColor = Color.PaleGreen;
                        dgwProfit.Rows.Add("М. Остров", dataSetCSdb.Products.Rows[i][1],
                            (Convert.ToInt32(dataSetCSdb.Products.Rows[i][7]) - Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                            * (Convert.ToInt32(textBoxCapacity.Text) / Convert.ToInt32(dataSetCSdb.Products.Rows[i][2])));
                    }

                    if (Convert.ToInt32(dataSetCSdb.Products.Rows[i][7]) < Convert.ToInt32(dataSetCSdb.Products.Rows[i][comboIndex]))
                    {
                        dgwDIsland.Rows[i].Cells[0].Style.BackColor = Color.DarkSalmon;
                    }
                }
            }

            dgwProfit.Sort(dgwProfit.Columns[2], ListSortDirection.Descending);

            dgwTownBuy.ClearSelection();
            dgwWeight.ClearSelection();
            dgwHighrock.ClearSelection();
            dgwTendeils.ClearSelection();
            dgwDIsland.ClearSelection();
            dgwProfit.ClearSelection();
        }
    }
}
