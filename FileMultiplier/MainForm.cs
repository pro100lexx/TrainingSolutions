using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileMultiplier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string filename;
        public string[] allfiles;

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxSourceFolderPath.Text = Properties.Settings.Default.SourceFolderPath;
            textBoxReceiver_1.Text = Properties.Settings.Default.Receiver_1;
            textBoxReceiver_2.Text = Properties.Settings.Default.Receiver_2;
            textBoxReceiver_3.Text = Properties.Settings.Default.Receiver_3;
            textBoxReceiver_4.Text = Properties.Settings.Default.Receiver_4;
            textBoxReceiver_5.Text = Properties.Settings.Default.Receiver_5;
            textBoxReceiver_6.Text = Properties.Settings.Default.Receiver_6;
            textBoxReceiver_7.Text = Properties.Settings.Default.Receiver_7;
            
            checkBox_XAU_1.Checked = Properties.Settings.Default.XAU_1;
            checkBox_XAU_2.Checked = Properties.Settings.Default.XAU_2;
            checkBox_XAU_3.Checked = Properties.Settings.Default.XAU_3;
            checkBox_XAU_4.Checked = Properties.Settings.Default.XAU_4;
            checkBox_XAU_5.Checked = Properties.Settings.Default.XAU_5;
            checkBox_XAU_6.Checked = Properties.Settings.Default.XAU_6;
            checkBox_XAU_7.Checked = Properties.Settings.Default.XAU_7;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SourceFolderPath = textBoxSourceFolderPath.Text;
            Properties.Settings.Default.Receiver_1 = textBoxReceiver_1.Text;
            Properties.Settings.Default.Receiver_2 = textBoxReceiver_2.Text;
            Properties.Settings.Default.Receiver_3 = textBoxReceiver_3.Text;
            Properties.Settings.Default.Receiver_4 = textBoxReceiver_4.Text;
            Properties.Settings.Default.Receiver_5 = textBoxReceiver_5.Text;
            Properties.Settings.Default.Receiver_6 = textBoxReceiver_6.Text;
            Properties.Settings.Default.Receiver_7 = textBoxReceiver_7.Text;
            
            Properties.Settings.Default.XAU_1 = checkBox_XAU_1.Checked;
            Properties.Settings.Default.XAU_2 = checkBox_XAU_2.Checked;
            Properties.Settings.Default.XAU_3 = checkBox_XAU_3.Checked;
            Properties.Settings.Default.XAU_4 = checkBox_XAU_4.Checked;
            Properties.Settings.Default.XAU_5 = checkBox_XAU_5.Checked;
            Properties.Settings.Default.XAU_6 = checkBox_XAU_6.Checked;
            Properties.Settings.Default.XAU_7 = checkBox_XAU_7.Checked;

            Properties.Settings.Default.Save();
            timerFileSearch.Stop();
        }

        #region ВЫБОР ПУТЕЙ
        private void btnOpenSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxSourceFolderPath.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void buttonReceiver_1_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxReceiver_1.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void buttonReceiver_2_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxReceiver_2.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void buttonReceiver_3_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxReceiver_3.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void buttonReceiver_4_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxReceiver_4.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void buttonReceiver_5_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxReceiver_5.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void buttonReceiver_6_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxReceiver_6.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void buttonReceiver_7_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBoxReceiver_7.Text = folderBrowserDialogSource.SelectedPath;
        }

        #endregion

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Старт")
            {
                buttonStart.BackColor = Color.Tomato;
                buttonStart.Text = "СТОП";
                labelStatus.Text = "Идет поиск файла...";
                labelStatus.ForeColor = Color.Green;
                timerFileSearch.Start();
            }
            else
            {
                buttonStart.BackColor = Color.PaleGreen;
                buttonStart.Text = "Старт";
                labelStatus.Text = "Программа остановлена";
                labelStatus.ForeColor = Color.Red;
                timerFileSearch.Stop();
            }
        }

        private void timerFileSearch_Tick(object sender, EventArgs e)
        {
            //проверяет количество файлов в папке, если 0 то ничего делать не будет
            if (new DirectoryInfo(textBoxSourceFolderPath.Text).GetFiles().Length > 0)
            {
                string MessageText = "";
                allfiles = Directory.GetFiles(textBoxSourceFolderPath.Text);
                foreach (string fullpath in allfiles)
                {
                    string[] pathelem = fullpath.Split('\\');
                    filename = pathelem[pathelem.Length - 1];

                    try
                    {
                        var fs = File.Open(fullpath, FileMode.Open, FileAccess.Read, FileShare.None);
                        fs.Close();
                        MessageText = "Файл: " + filename + " свободен.";
                        labelStatusString.ForeColor = Color.Black;

                        //ПОЛУЧАТЕЛЬ № 1
                        if (textBoxReceiver_1.Text != "empty")
                        {
                            if (!File.Exists(textBoxReceiver_1.Text + "\\" + filename))
                            {
                                if (checkBox_XAU_1.Checked)
                                    GoldConvertation(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_1.Text + "\\" + filename);
                                else
                                    File.Copy(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_1.Text + "\\" + filename);
                                MessageText = "Файл   >   " + filename + "   >   скопирован";
                            }
                            else
                            {
                                MessageText = "Файл в целевых папках уже существует!";
                            }
                        }

                        //ПОЛУЧАТЕЛЬ № 2
                        if (textBoxReceiver_2.Text != "empty")
                        {
                            if (!File.Exists(textBoxReceiver_2.Text + "\\" + filename))
                            {
                                if (checkBox_XAU_2.Checked)
                                    GoldConvertation(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_2.Text + "\\" + filename);
                                else
                                    File.Copy(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_2.Text + "\\" + filename);
                                MessageText = "Файл   >   " + filename + "   >   скопирован";
                            }
                            else
                            {
                                MessageText = "Файл в целевых папках уже существует!";
                            }
                        }

                        //ПОЛУЧАТЕЛЬ № 3
                        if (textBoxReceiver_3.Text != "empty")
                        {
                            if (!File.Exists(textBoxReceiver_3.Text + "\\" + filename))
                            {
                                if (checkBox_XAU_3.Checked)
                                    GoldConvertation(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_3.Text + "\\" + filename);
                                else
                                    File.Copy(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_3.Text + "\\" + filename);
                                MessageText = "Файл   >   " + filename + "   >   скопирован";
                            }
                            else
                            {
                                MessageText = "Файл в целевых папках уже существует!";
                            }
                        }

                        //ПОЛУЧАТЕЛЬ № 4
                        if (textBoxReceiver_4.Text != "empty")
                        {
                            if (!File.Exists(textBoxReceiver_4.Text + "\\" + filename))
                            {
                                if (checkBox_XAU_4.Checked)
                                    GoldConvertation(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_4.Text + "\\" + filename);
                                else
                                    File.Copy(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_4.Text + "\\" + filename);
                                MessageText = "Файл   >   " + filename + "   >   скопирован";
                            }
                            else
                            {
                                MessageText = "Файл в целевых папках уже существует!";
                            }
                        }

                        //ПОЛУЧАТЕЛЬ № 5
                        if (textBoxReceiver_5.Text != "empty")
                        {
                            if (!File.Exists(textBoxReceiver_5.Text + "\\" + filename))
                            {
                                if (checkBox_XAU_5.Checked)
                                    GoldConvertation(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_5.Text + "\\" + filename);
                                else
                                    File.Copy(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_5.Text + "\\" + filename);
                                MessageText = "Файл   >   " + filename + "   >   скопирован";
                            }
                            else
                            {
                                MessageText = "Файл в целевых папках уже существует!";
                            }
                        }

                        //ПОЛУЧАТЕЛЬ № 6
                        if (textBoxReceiver_6.Text != "empty")
                        {
                            if (!File.Exists(textBoxReceiver_6.Text + "\\" + filename))
                            {
                                if (checkBox_XAU_6.Checked)
                                    GoldConvertation(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_6.Text + "\\" + filename);
                                else
                                    File.Copy(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_6.Text + "\\" + filename);
                                MessageText = "Файл   >   " + filename + "   >   скопирован";
                            }
                            else
                            {
                                MessageText = "Файл в целевых папках уже существует!";
                            }
                        }

                        //ПОЛУЧАТЕЛЬ № 7 
                        if (textBoxReceiver_7.Text != "empty")
                        {
                            if (!File.Exists(textBoxReceiver_7.Text + "\\" + filename))
                            {
                                if (checkBox_XAU_7.Checked)
                                    GoldConvertation(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_7.Text + "\\" + filename);
                                else
                                    File.Copy(textBoxSourceFolderPath.Text + "\\" + filename, textBoxReceiver_7.Text + "\\" + filename);
                                MessageText = "Файл   >   " + filename + "   >   скопирован";
                            }
                            else
                            {
                                MessageText = "Файл в целевых папках уже существует!";
                            }
                        }

                        File.Delete(textBoxSourceFolderPath.Text + "\\" + filename);
                    }
                    catch (IOException)
                    {
                        MessageText = "Файл: " + filename + " занят!";
                        labelStatusString.ForeColor = Color.Red;
                    }
                    finally
                    {
                        labelStatusString.Text = MessageText;
                    }
                }

            }
        }

        #region ОЧИСТКА ПУТЕЙ
        private void btRec_PathClear_1_Click(object sender, EventArgs e)
        {
            textBoxReceiver_1.Text = "empty";
            checkBox_XAU_1.Checked = false;
        }

        private void btRec_PathClear_2_Click(object sender, EventArgs e)
        {
            textBoxReceiver_2.Text = "empty";
            checkBox_XAU_2.Checked = false;
        }

        private void btRec_PathClear_3_Click(object sender, EventArgs e)
        {
            textBoxReceiver_3.Text = "empty";
            checkBox_XAU_3.Checked = false;
        }

        private void btRec_PathClear_4_Click(object sender, EventArgs e)
        {
            textBoxReceiver_4.Text = "empty";
            checkBox_XAU_4.Checked = false;
        }

        private void btRec_PathClear_5_Click(object sender, EventArgs e)
        {
            textBoxReceiver_5.Text = "empty";
            checkBox_XAU_5.Checked = false;
        }

        private void btRec_PathClear_6_Click(object sender, EventArgs e)
        {
            textBoxReceiver_6.Text = "empty";
            checkBox_XAU_6.Checked = false;
        }

        private void btRec_PathClear_7_Click(object sender, EventArgs e)
        {
            textBoxReceiver_7.Text = "empty";
            checkBox_XAU_7.Checked = false;
        }
        #endregion

    }
}
