using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace AccountsMonitor
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Выполняет распечатку данных из AccountList
        /// </summary>
        void OrdersTablePrintFromAccountList()
        {
            accTable.Children.Clear();

            foreach (var el in AccList)
            {
                accountRow row_new = new accountRow();

                row_new.lblOwner.Content = el.OwnerName;
                row_new.lblAccNo.Content = el.AccountNumber;
                row_new.lblAccBal.Content = el.AccountBalance;
                row_new.lblEURUSD.Content = el.EURUSD.ToString();
                row_new.lblGBPUSD.Content = el.GBPUSD.ToString();
                row_new.lblGBPJPY.Content = el.GBPGPY.ToString();
                row_new.lblUSDCAD.Content = el.USDCAD.ToString();
                row_new.lblAUDUSD.Content = el.AUDUSD.ToString();

                accTable.Children.Add(row_new);
            }
            
        }
        void OrdersTablePrint()
        {
            accTable.Children.Clear();
            DataTable tableOrders = new DataTable() { TableName = "accounts" };
            tableOrders.Columns.Add("Owner");
            tableOrders.Columns.Add("Path");
            StringReader reader = new StringReader(Properties.Settings.Default.TableXml);
            tableOrders.ReadXml(reader);
            for (int i = 0; i < tableOrders.Rows.Count; i++)
            {
                accountRow row_new = new accountRow();
                accTable.Children.Add(row_new);
            }

            int xL = 0;
            foreach (accountRow el in accTable.Children)
            {
                string[] alllines = null;
                DataRow row = tableOrders.Rows[xL];
                el.lblOwner.Content = (string)row["Owner"];
                el.lblAccNo.Content = "файла";
                el.lblAccBal.Content = "нет";
                el.lblEURUSD.Content = "0";
                el.lblGBPUSD.Content = "0";
                el.lblGBPJPY.Content = "0";
                el.lblUSDCAD.Content = "0";
                el.lblAUDUSD.Content = "0";
                string path = (string)row["Path"];
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path, Encoding.Default))
                    {
                        string line;
                        if ((line = sr.ReadLine()) != null)
                        {
                            alllines = line.Split(';');
                        }
                        el.lblAccNo.Content = alllines[0];
                        el.lblAccBal.Content = alllines[1];
                    }

                    for (int i = 2; i < alllines.Length; i++)
                    {
                        string[] sym = alllines[i].Split(':');

                        if (sym[0] == "EURUSD")
                        {
                            el.lblEURUSD.Content = sym[1];
                            if (int.Parse(sym[1]) > 0)
                            {
                                el.lblEURUSD.Foreground =  new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            }
                            else
                            {
                                el.lblEURUSD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            }
                        }
                        if (sym[0] == "GBPUSD")
                        {
                            el.lblGBPUSD.Content = sym[1];
                            if (int.Parse(sym[1]) > 0)
                            {
                                el.lblGBPUSD.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            }
                            else
                            {
                                el.lblGBPUSD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            }
                        }
                        if (sym[0] == "GBPJPY")
                        {
                            el.lblGBPJPY.Content = sym[1];
                            if (int.Parse(sym[1]) > 0)
                            {
                                el.lblGBPJPY.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            }
                            else
                            {
                                el.lblGBPJPY.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            }
                        }
                        if (sym[0] == "USDCAD")
                        {
                            el.lblUSDCAD.Content = sym[1];
                            if (int.Parse(sym[1]) > 0)
                            {
                                el.lblUSDCAD.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            }
                            else
                            {
                                el.lblUSDCAD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            }
                        }
                        if (sym[0] == "AUDUSD")
                        {
                            el.lblAUDUSD.Content = sym[1];
                            if (int.Parse(sym[1]) > 0)
                            {
                                el.lblAUDUSD.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            }
                            else
                            {
                                el.lblAUDUSD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            }
                        }
                    }

                }
                xL++;
            }
        }

        /// <summary>
        /// Обновляем данные в списке из файлов.
        /// </summary>
        void UpdateAccountList()
        {
            if (AccList.Count != 0)
            {
                foreach (AccountsDBclass el in AccList)
                {
                    if (File.Exists(el.Path))
                    {
                        string[] alllines = null;
                        using (StreamReader sr = new StreamReader(el.Path, Encoding.Default))
                        {
                            alllines = sr.ReadToEnd().Split(';');
                            el.AccountNumber = alllines[0];
                            el.AccountBalance = alllines[1];

                            for (int i = 2; i < alllines.Length; i++)
                            {
                                string[] sym = alllines[i].Split(':');

                                if (sym[0] == "EURUSD")
                                {
                                    el.EURUSD = int.Parse(sym[1]);
                                }
                                if (sym[0] == "GBPUSD")
                                {
                                    el.GBPUSD = int.Parse(sym[1]);
                                }
                                if (sym[0] == "GBPJPY")
                                {
                                    el.GBPGPY = int.Parse(sym[1]);
                                }
                                if (sym[0] == "USDCAD")
                                {
                                    el.USDCAD = int.Parse(sym[1]);
                                }
                                if (sym[0] == "AUDUSD")
                                {
                                    el.AUDUSD = int.Parse(sym[1]);
                                }
                            }
                        }

                        File.Delete(el.Path);

                        //Присваиваем лейблам считанные значения и устанавливаем цвет
                        foreach (accountRow row in accTable.Children)
                        {
                            //Выбираем элемент списка AccList соответствующий выбранной строке в таблице
                            //AccountsDBclass elem = AccList.SingleOrDefault(s => s.AccountNumber == row.lblAccNo.Content.ToString());

                            if (row.lblOwner.Content.ToString() == el.OwnerName)
                            {
                                row.lblAccNo.Content = el.AccountNumber;
                                row.lblAccBal.Content = el.AccountBalance;

                                if (el.EURUSD > 0)
                                {
                                    row.lblEURUSD.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                                }
                                else
                                {
                                    row.lblEURUSD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                }

                                if (el.GBPUSD > 0)
                                {
                                    row.lblGBPUSD.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                                }
                                else
                                {
                                    row.lblGBPUSD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                }

                                if (el.GBPGPY > 0)
                                {
                                    row.lblGBPJPY.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                                }
                                else
                                {
                                    row.lblGBPJPY.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                }

                                if (el.USDCAD > 0)
                                {
                                    row.lblUSDCAD.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                                }
                                else
                                {
                                    row.lblUSDCAD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                }

                                if (el.AUDUSD > 0)
                                {
                                    row.lblAUDUSD.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                                }
                                else
                                {
                                    row.lblAUDUSD.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                }

                                row.lblEURUSD.Content = el.EURUSD;
                                row.lblGBPUSD.Content = el.GBPUSD;
                                row.lblGBPJPY.Content = el.GBPGPY;
                                row.lblUSDCAD.Content = el.USDCAD;
                                row.lblAUDUSD.Content = el.AUDUSD;
                            }
                        }
                    } // end of File.Exists
                }


            }
            else
            {
                localTimer.Stop();
                StartButton.Header = "Запустить";
                StartButton.Background = new SolidColorBrush(Color.FromRgb(14, 151, 71));
                MessageBox.Show("Список счетов пуст, проверьте настройки");
            }
        }

        /// <summary>
        /// Создает внутренний список, хранящий имена владельцев счетов и пути к их файлам.
        /// </summary>
        void CreateAccountList()
        {
            DataTable tb = new DataTable() { TableName = "accounts" };
            tb.Columns.Add("Owner");
            tb.Columns.Add("Path");
            StringReader reader = new StringReader(Properties.Settings.Default.TableXml);
            //Читаем сохраненный список пользователей и пути к их файлам
            tb.ReadXml(reader);
            AccList.Clear();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                AccountsDBclass accInfo = new AccountsDBclass();
                DataRow row = tb.Rows[i];
                accInfo.Path = (string)row["Path"];
                accInfo.OwnerName = (string)row["Owner"];
                accInfo.AccountNumber = "файла";
                accInfo.AccountBalance = "нет";
                AccList.Add(accInfo);
            }
        }

        /// <summary>
        /// Заполняет созданный список данными взятыми из файлов.
        /// При отсутствии файла строка останется пустой.
        /// </summary>
        void SaveDataFromFilesToAccountList()
        {
            string[] alllines;
            foreach (var el in AccList)
            {
                if (File.Exists(el.Path))
                {
                    using (StreamReader sr = new StreamReader(el.Path, Encoding.Default))
                    {
                        alllines = sr.ReadToEnd().Split(';');
                        el.AccountNumber = alllines[0];
                        el.AccountBalance = alllines[1];
                    }
                }

                
            }
        }
    }
}
