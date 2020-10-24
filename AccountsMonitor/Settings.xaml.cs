using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AccountsMonitor
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        //public static object Default { get; private set; }
        public Settings()
        {
            InitializeComponent();
        }


        private void CloseSettings_Click(object sender, RoutedEventArgs e)
        {
            StringWriter writer = new StringWriter();
            DataTable table = new DataTable() { TableName = "accounts" };
            table.Columns.Add("Owner");
            table.Columns.Add("Path");


            foreach (SetAccount el in AccountsList.Children)
            {
                table.Rows.Add(el.Owner.Text, el.filePath.Text);
            }

            table.AcceptChanges();
            table.WriteXml(writer);
            Properties.Settings.Default.TableXml = writer.ToString();
            Properties.Settings.Default.Save();

            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable tableLoad = new DataTable() { TableName = "accounts" };
                tableLoad.Columns.Add("Owner");
                tableLoad.Columns.Add("Path");
                StringReader reader = new StringReader(Properties.Settings.Default.TableXml);
                tableLoad.ReadXml(reader);
                for (int i = 0; i < tableLoad.Rows.Count; i++)
                {
                    SetAccount acc_new = new SetAccount();
                    Button deleteButton = new Button();
                    deleteButton.Content = "X";
                    deleteButton.SetValue(NameProperty, "delBut");
                    deleteButton.Margin = new Thickness(10, 0, 0, 0);
                    deleteButton.Width = 20;
                    deleteButton.Click += deleteButton_Click;
                    deleteButton.Background = new SolidColorBrush(Color.FromRgb(156, 42, 42));
                    deleteButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                    acc_new.accRow.Children.Add(deleteButton);
                    AccountsList.Children.Add(acc_new);
                }

                int xL = 0;
                foreach (SetAccount el in AccountsList.Children)
                {
                    DataRow row = tableLoad.Rows[xL];
                    el.Owner.Text = (string)row["Owner"];
                    el.filePath.Text = (string)row["Path"];
                    xL++;
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void AddAccount_Click(object sender, RoutedEventArgs e)
        {
            SetAccount acc_new = new SetAccount();
            Button deleteButton = new Button();
            deleteButton.Content = "X";
            deleteButton.SetValue(NameProperty, "delBut");
            deleteButton.Margin = new Thickness(10, 0, 0, 0);
            deleteButton.Width = 20;
            deleteButton.Click += deleteButton_Click;
            deleteButton.Background = new SolidColorBrush(Color.FromRgb(156, 42, 42));
            deleteButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            acc_new.accRow.Children.Add(deleteButton);
            AccountsList.Children.Add(acc_new);
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            SetAccount elem = (SetAccount)((FrameworkElement)((FrameworkElement)(((FrameworkElement)sender).Parent)).Parent).Parent;
            AccountsList.Children.Remove(elem);
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
