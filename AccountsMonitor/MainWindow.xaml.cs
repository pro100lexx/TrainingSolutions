using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;

namespace AccountsMonitor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<AccountsDBclass> AccList = new List<AccountsDBclass>();
        DispatcherTimer localTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
    }

        private void SettingsWindowOpen_click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            CreateAccountList();
            SaveDataFromFilesToAccountList();
            OrdersTablePrintFromAccountList();
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateAccountList();
                SaveDataFromFilesToAccountList();
                OrdersTablePrintFromAccountList();
            }
            catch (Exception)
            {

                
            }

            localTimer.Tick += new EventHandler(timerTick);
            localTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
        }

        private void timerTick(object sender, EventArgs e)
        {
            UpdateAccountList();
        }

        private void About_click(object sender, RoutedEventArgs e)
        {
            string str = "Программа расчитана на 5 валют" + Environment.NewLine;
            str += "EURUSD - GBPUSD - GBPJPY - USDCAD - AUDUSD" + Environment.NewLine;
            str += "в МТ4 должны быть открыты графики этих валют" + Environment.NewLine;
            str += "а считывающий эксперт установлен на любой другой график";
            MessageBox.Show(str);
        }

        private void StartButton_click(object sender, RoutedEventArgs e)
        {
            if (localTimer.IsEnabled)
            {
                localTimer.Stop();
                StartButton.Header = "Запустить";
                StartButton.Background = new SolidColorBrush(Color.FromRgb(14, 151, 71));
            }
            else
            {
                localTimer.Start();
                StartButton.Header = "Остановить";
                StartButton.Background = new SolidColorBrush(Color.FromRgb(214, 86, 86));
            }
        }
    }
}
