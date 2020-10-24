using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccountsMonitor
{
    /// <summary>
    /// Логика взаимодействия для SetAccount.xaml
    /// </summary>
    public partial class SetAccount : UserControl
    {
        public SetAccount()
        {
            InitializeComponent();
        }

        private void browsePath_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.ShowDialog();
            filePath.Text = ofd.FileName;
        }
    }
}
