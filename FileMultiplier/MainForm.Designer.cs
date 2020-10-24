namespace FileMultiplier
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.textBoxSourceFolderPath = new System.Windows.Forms.TextBox();
            this.textBoxReceiver_1 = new System.Windows.Forms.TextBox();
            this.buttonReceiver_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReceiver_2 = new System.Windows.Forms.TextBox();
            this.buttonReceiver_2 = new System.Windows.Forms.Button();
            this.textBoxReceiver_3 = new System.Windows.Forms.TextBox();
            this.buttonReceiver_3 = new System.Windows.Forms.Button();
            this.textBoxReceiver_4 = new System.Windows.Forms.TextBox();
            this.buttonReceiver_4 = new System.Windows.Forms.Button();
            this.textBoxReceiver_5 = new System.Windows.Forms.TextBox();
            this.buttonReceiver_5 = new System.Windows.Forms.Button();
            this.textBoxReceiver_6 = new System.Windows.Forms.TextBox();
            this.buttonReceiver_6 = new System.Windows.Forms.Button();
            this.textBoxReceiver_7 = new System.Windows.Forms.TextBox();
            this.buttonReceiver_7 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerFileSearch = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.btRec_PathClear_1 = new System.Windows.Forms.Button();
            this.btRec_PathClear_2 = new System.Windows.Forms.Button();
            this.btRec_PathClear_3 = new System.Windows.Forms.Button();
            this.btRec_PathClear_4 = new System.Windows.Forms.Button();
            this.btRec_PathClear_5 = new System.Windows.Forms.Button();
            this.btRec_PathClear_6 = new System.Windows.Forms.Button();
            this.btRec_PathClear_7 = new System.Windows.Forms.Button();
            this.labelStatusString = new System.Windows.Forms.Label();
            this.checkBox_XAU_1 = new System.Windows.Forms.CheckBox();
            this.checkBox_XAU_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_XAU_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_XAU_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_XAU_5 = new System.Windows.Forms.CheckBox();
            this.checkBox_XAU_6 = new System.Windows.Forms.CheckBox();
            this.checkBox_XAU_7 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Источник:";
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.Location = new System.Drawing.Point(435, 5);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(83, 23);
            this.btnOpenSource.TabIndex = 1;
            this.btnOpenSource.Text = "Выбрать";
            this.btnOpenSource.UseVisualStyleBackColor = true;
            this.btnOpenSource.Click += new System.EventHandler(this.btnOpenSource_Click);
            // 
            // textBoxSourceFolderPath
            // 
            this.textBoxSourceFolderPath.Location = new System.Drawing.Point(91, 7);
            this.textBoxSourceFolderPath.Name = "textBoxSourceFolderPath";
            this.textBoxSourceFolderPath.Size = new System.Drawing.Size(338, 20);
            this.textBoxSourceFolderPath.TabIndex = 2;
            // 
            // textBoxReceiver_1
            // 
            this.textBoxReceiver_1.Location = new System.Drawing.Point(15, 69);
            this.textBoxReceiver_1.Name = "textBoxReceiver_1";
            this.textBoxReceiver_1.Size = new System.Drawing.Size(356, 20);
            this.textBoxReceiver_1.TabIndex = 5;
            // 
            // buttonReceiver_1
            // 
            this.buttonReceiver_1.Location = new System.Drawing.Point(377, 67);
            this.buttonReceiver_1.Name = "buttonReceiver_1";
            this.buttonReceiver_1.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiver_1.TabIndex = 4;
            this.buttonReceiver_1.Text = "Выбрать";
            this.buttonReceiver_1.UseVisualStyleBackColor = true;
            this.buttonReceiver_1.Click += new System.EventHandler(this.buttonReceiver_1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "................   Пути к приемникам   .................\r\n";
            // 
            // textBoxReceiver_2
            // 
            this.textBoxReceiver_2.Location = new System.Drawing.Point(15, 98);
            this.textBoxReceiver_2.Name = "textBoxReceiver_2";
            this.textBoxReceiver_2.Size = new System.Drawing.Size(356, 20);
            this.textBoxReceiver_2.TabIndex = 7;
            // 
            // buttonReceiver_2
            // 
            this.buttonReceiver_2.Location = new System.Drawing.Point(377, 96);
            this.buttonReceiver_2.Name = "buttonReceiver_2";
            this.buttonReceiver_2.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiver_2.TabIndex = 6;
            this.buttonReceiver_2.Text = "Выбрать";
            this.buttonReceiver_2.UseVisualStyleBackColor = true;
            this.buttonReceiver_2.Click += new System.EventHandler(this.buttonReceiver_2_Click);
            // 
            // textBoxReceiver_3
            // 
            this.textBoxReceiver_3.Location = new System.Drawing.Point(15, 127);
            this.textBoxReceiver_3.Name = "textBoxReceiver_3";
            this.textBoxReceiver_3.Size = new System.Drawing.Size(356, 20);
            this.textBoxReceiver_3.TabIndex = 9;
            // 
            // buttonReceiver_3
            // 
            this.buttonReceiver_3.Location = new System.Drawing.Point(377, 125);
            this.buttonReceiver_3.Name = "buttonReceiver_3";
            this.buttonReceiver_3.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiver_3.TabIndex = 8;
            this.buttonReceiver_3.Text = "Выбрать";
            this.buttonReceiver_3.UseVisualStyleBackColor = true;
            this.buttonReceiver_3.Click += new System.EventHandler(this.buttonReceiver_3_Click);
            // 
            // textBoxReceiver_4
            // 
            this.textBoxReceiver_4.Location = new System.Drawing.Point(15, 156);
            this.textBoxReceiver_4.Name = "textBoxReceiver_4";
            this.textBoxReceiver_4.Size = new System.Drawing.Size(356, 20);
            this.textBoxReceiver_4.TabIndex = 11;
            // 
            // buttonReceiver_4
            // 
            this.buttonReceiver_4.Location = new System.Drawing.Point(377, 154);
            this.buttonReceiver_4.Name = "buttonReceiver_4";
            this.buttonReceiver_4.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiver_4.TabIndex = 10;
            this.buttonReceiver_4.Text = "Выбрать";
            this.buttonReceiver_4.UseVisualStyleBackColor = true;
            this.buttonReceiver_4.Click += new System.EventHandler(this.buttonReceiver_4_Click);
            // 
            // textBoxReceiver_5
            // 
            this.textBoxReceiver_5.Location = new System.Drawing.Point(15, 185);
            this.textBoxReceiver_5.Name = "textBoxReceiver_5";
            this.textBoxReceiver_5.Size = new System.Drawing.Size(356, 20);
            this.textBoxReceiver_5.TabIndex = 13;
            // 
            // buttonReceiver_5
            // 
            this.buttonReceiver_5.Location = new System.Drawing.Point(377, 183);
            this.buttonReceiver_5.Name = "buttonReceiver_5";
            this.buttonReceiver_5.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiver_5.TabIndex = 12;
            this.buttonReceiver_5.Text = "Выбрать";
            this.buttonReceiver_5.UseVisualStyleBackColor = true;
            this.buttonReceiver_5.Click += new System.EventHandler(this.buttonReceiver_5_Click);
            // 
            // textBoxReceiver_6
            // 
            this.textBoxReceiver_6.Location = new System.Drawing.Point(15, 214);
            this.textBoxReceiver_6.Name = "textBoxReceiver_6";
            this.textBoxReceiver_6.Size = new System.Drawing.Size(356, 20);
            this.textBoxReceiver_6.TabIndex = 15;
            // 
            // buttonReceiver_6
            // 
            this.buttonReceiver_6.Location = new System.Drawing.Point(377, 212);
            this.buttonReceiver_6.Name = "buttonReceiver_6";
            this.buttonReceiver_6.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiver_6.TabIndex = 14;
            this.buttonReceiver_6.Text = "Выбрать";
            this.buttonReceiver_6.UseVisualStyleBackColor = true;
            this.buttonReceiver_6.Click += new System.EventHandler(this.buttonReceiver_6_Click);
            // 
            // textBoxReceiver_7
            // 
            this.textBoxReceiver_7.Location = new System.Drawing.Point(15, 243);
            this.textBoxReceiver_7.Name = "textBoxReceiver_7";
            this.textBoxReceiver_7.Size = new System.Drawing.Size(356, 20);
            this.textBoxReceiver_7.TabIndex = 17;
            // 
            // buttonReceiver_7
            // 
            this.buttonReceiver_7.Location = new System.Drawing.Point(377, 241);
            this.buttonReceiver_7.Name = "buttonReceiver_7";
            this.buttonReceiver_7.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiver_7.TabIndex = 16;
            this.buttonReceiver_7.Text = "Выбрать";
            this.buttonReceiver_7.UseVisualStyleBackColor = true;
            this.buttonReceiver_7.Click += new System.EventHandler(this.buttonReceiver_7_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(14, 273);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 34);
            this.buttonStart.TabIndex = 18;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerFileSearch
            // 
            this.timerFileSearch.Interval = 200;
            this.timerFileSearch.Tick += new System.EventHandler(this.timerFileSearch_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(152, 281);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(219, 20);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Программа остановлена";
            // 
            // btRec_PathClear_1
            // 
            this.btRec_PathClear_1.Location = new System.Drawing.Point(456, 67);
            this.btRec_PathClear_1.Name = "btRec_PathClear_1";
            this.btRec_PathClear_1.Size = new System.Drawing.Size(53, 23);
            this.btRec_PathClear_1.TabIndex = 21;
            this.btRec_PathClear_1.Text = "Сброс";
            this.btRec_PathClear_1.UseVisualStyleBackColor = true;
            this.btRec_PathClear_1.Click += new System.EventHandler(this.btRec_PathClear_1_Click);
            // 
            // btRec_PathClear_2
            // 
            this.btRec_PathClear_2.Location = new System.Drawing.Point(456, 96);
            this.btRec_PathClear_2.Name = "btRec_PathClear_2";
            this.btRec_PathClear_2.Size = new System.Drawing.Size(53, 23);
            this.btRec_PathClear_2.TabIndex = 22;
            this.btRec_PathClear_2.Text = "Сброс";
            this.btRec_PathClear_2.UseVisualStyleBackColor = true;
            this.btRec_PathClear_2.Click += new System.EventHandler(this.btRec_PathClear_2_Click);
            // 
            // btRec_PathClear_3
            // 
            this.btRec_PathClear_3.Location = new System.Drawing.Point(456, 125);
            this.btRec_PathClear_3.Name = "btRec_PathClear_3";
            this.btRec_PathClear_3.Size = new System.Drawing.Size(53, 23);
            this.btRec_PathClear_3.TabIndex = 23;
            this.btRec_PathClear_3.Text = "Сброс";
            this.btRec_PathClear_3.UseVisualStyleBackColor = true;
            this.btRec_PathClear_3.Click += new System.EventHandler(this.btRec_PathClear_3_Click);
            // 
            // btRec_PathClear_4
            // 
            this.btRec_PathClear_4.Location = new System.Drawing.Point(456, 154);
            this.btRec_PathClear_4.Name = "btRec_PathClear_4";
            this.btRec_PathClear_4.Size = new System.Drawing.Size(53, 23);
            this.btRec_PathClear_4.TabIndex = 24;
            this.btRec_PathClear_4.Text = "Сброс";
            this.btRec_PathClear_4.UseVisualStyleBackColor = true;
            this.btRec_PathClear_4.Click += new System.EventHandler(this.btRec_PathClear_4_Click);
            // 
            // btRec_PathClear_5
            // 
            this.btRec_PathClear_5.Location = new System.Drawing.Point(456, 183);
            this.btRec_PathClear_5.Name = "btRec_PathClear_5";
            this.btRec_PathClear_5.Size = new System.Drawing.Size(53, 23);
            this.btRec_PathClear_5.TabIndex = 25;
            this.btRec_PathClear_5.Text = "Сброс";
            this.btRec_PathClear_5.UseVisualStyleBackColor = true;
            this.btRec_PathClear_5.Click += new System.EventHandler(this.btRec_PathClear_5_Click);
            // 
            // btRec_PathClear_6
            // 
            this.btRec_PathClear_6.Location = new System.Drawing.Point(456, 212);
            this.btRec_PathClear_6.Name = "btRec_PathClear_6";
            this.btRec_PathClear_6.Size = new System.Drawing.Size(53, 23);
            this.btRec_PathClear_6.TabIndex = 26;
            this.btRec_PathClear_6.Text = "Сброс";
            this.btRec_PathClear_6.UseVisualStyleBackColor = true;
            this.btRec_PathClear_6.Click += new System.EventHandler(this.btRec_PathClear_6_Click);
            // 
            // btRec_PathClear_7
            // 
            this.btRec_PathClear_7.Location = new System.Drawing.Point(456, 241);
            this.btRec_PathClear_7.Name = "btRec_PathClear_7";
            this.btRec_PathClear_7.Size = new System.Drawing.Size(53, 23);
            this.btRec_PathClear_7.TabIndex = 27;
            this.btRec_PathClear_7.Text = "Сброс";
            this.btRec_PathClear_7.UseVisualStyleBackColor = true;
            this.btRec_PathClear_7.Click += new System.EventHandler(this.btRec_PathClear_7_Click);
            // 
            // labelStatusString
            // 
            this.labelStatusString.AutoSize = true;
            this.labelStatusString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusString.Location = new System.Drawing.Point(12, 321);
            this.labelStatusString.Name = "labelStatusString";
            this.labelStatusString.Size = new System.Drawing.Size(140, 17);
            this.labelStatusString.TabIndex = 29;
            this.labelStatusString.Text = "Строка состояния...";
            // 
            // checkBox_XAU_1
            // 
            this.checkBox_XAU_1.AutoSize = true;
            this.checkBox_XAU_1.Location = new System.Drawing.Point(515, 73);
            this.checkBox_XAU_1.Name = "checkBox_XAU_1";
            this.checkBox_XAU_1.Size = new System.Drawing.Size(48, 17);
            this.checkBox_XAU_1.TabIndex = 30;
            this.checkBox_XAU_1.Text = "XAU";
            this.checkBox_XAU_1.UseVisualStyleBackColor = true;
            // 
            // checkBox_XAU_2
            // 
            this.checkBox_XAU_2.AutoSize = true;
            this.checkBox_XAU_2.Location = new System.Drawing.Point(515, 101);
            this.checkBox_XAU_2.Name = "checkBox_XAU_2";
            this.checkBox_XAU_2.Size = new System.Drawing.Size(48, 17);
            this.checkBox_XAU_2.TabIndex = 31;
            this.checkBox_XAU_2.Text = "XAU";
            this.checkBox_XAU_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_XAU_3
            // 
            this.checkBox_XAU_3.AutoSize = true;
            this.checkBox_XAU_3.Location = new System.Drawing.Point(515, 130);
            this.checkBox_XAU_3.Name = "checkBox_XAU_3";
            this.checkBox_XAU_3.Size = new System.Drawing.Size(48, 17);
            this.checkBox_XAU_3.TabIndex = 32;
            this.checkBox_XAU_3.Text = "XAU";
            this.checkBox_XAU_3.UseVisualStyleBackColor = true;
            // 
            // checkBox_XAU_4
            // 
            this.checkBox_XAU_4.AutoSize = true;
            this.checkBox_XAU_4.Location = new System.Drawing.Point(515, 160);
            this.checkBox_XAU_4.Name = "checkBox_XAU_4";
            this.checkBox_XAU_4.Size = new System.Drawing.Size(48, 17);
            this.checkBox_XAU_4.TabIndex = 33;
            this.checkBox_XAU_4.Text = "XAU";
            this.checkBox_XAU_4.UseVisualStyleBackColor = true;
            // 
            // checkBox_XAU_5
            // 
            this.checkBox_XAU_5.AutoSize = true;
            this.checkBox_XAU_5.Location = new System.Drawing.Point(515, 189);
            this.checkBox_XAU_5.Name = "checkBox_XAU_5";
            this.checkBox_XAU_5.Size = new System.Drawing.Size(48, 17);
            this.checkBox_XAU_5.TabIndex = 34;
            this.checkBox_XAU_5.Text = "XAU";
            this.checkBox_XAU_5.UseVisualStyleBackColor = true;
            // 
            // checkBox_XAU_6
            // 
            this.checkBox_XAU_6.AutoSize = true;
            this.checkBox_XAU_6.Location = new System.Drawing.Point(515, 217);
            this.checkBox_XAU_6.Name = "checkBox_XAU_6";
            this.checkBox_XAU_6.Size = new System.Drawing.Size(48, 17);
            this.checkBox_XAU_6.TabIndex = 35;
            this.checkBox_XAU_6.Text = "XAU";
            this.checkBox_XAU_6.UseVisualStyleBackColor = true;
            // 
            // checkBox_XAU_7
            // 
            this.checkBox_XAU_7.AutoSize = true;
            this.checkBox_XAU_7.Location = new System.Drawing.Point(515, 247);
            this.checkBox_XAU_7.Name = "checkBox_XAU_7";
            this.checkBox_XAU_7.Size = new System.Drawing.Size(48, 17);
            this.checkBox_XAU_7.TabIndex = 36;
            this.checkBox_XAU_7.Text = "XAU";
            this.checkBox_XAU_7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 350);
            this.Controls.Add(this.checkBox_XAU_7);
            this.Controls.Add(this.checkBox_XAU_6);
            this.Controls.Add(this.checkBox_XAU_5);
            this.Controls.Add(this.checkBox_XAU_4);
            this.Controls.Add(this.checkBox_XAU_3);
            this.Controls.Add(this.checkBox_XAU_2);
            this.Controls.Add(this.checkBox_XAU_1);
            this.Controls.Add(this.labelStatusString);
            this.Controls.Add(this.btRec_PathClear_7);
            this.Controls.Add(this.btRec_PathClear_6);
            this.Controls.Add(this.btRec_PathClear_5);
            this.Controls.Add(this.btRec_PathClear_4);
            this.Controls.Add(this.btRec_PathClear_3);
            this.Controls.Add(this.btRec_PathClear_2);
            this.Controls.Add(this.btRec_PathClear_1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxReceiver_7);
            this.Controls.Add(this.buttonReceiver_7);
            this.Controls.Add(this.textBoxReceiver_6);
            this.Controls.Add(this.buttonReceiver_6);
            this.Controls.Add(this.textBoxReceiver_5);
            this.Controls.Add(this.buttonReceiver_5);
            this.Controls.Add(this.textBoxReceiver_4);
            this.Controls.Add(this.buttonReceiver_4);
            this.Controls.Add(this.textBoxReceiver_3);
            this.Controls.Add(this.buttonReceiver_3);
            this.Controls.Add(this.textBoxReceiver_2);
            this.Controls.Add(this.buttonReceiver_2);
            this.Controls.Add(this.textBoxReceiver_1);
            this.Controls.Add(this.buttonReceiver_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSourceFolderPath);
            this.Controls.Add(this.btnOpenSource);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Копировальщик файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.Button btnOpenSource;
        private System.Windows.Forms.TextBox textBoxSourceFolderPath;
        private System.Windows.Forms.TextBox textBoxReceiver_1;
        private System.Windows.Forms.Button buttonReceiver_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReceiver_2;
        private System.Windows.Forms.Button buttonReceiver_2;
        private System.Windows.Forms.TextBox textBoxReceiver_3;
        private System.Windows.Forms.Button buttonReceiver_3;
        private System.Windows.Forms.TextBox textBoxReceiver_4;
        private System.Windows.Forms.Button buttonReceiver_4;
        private System.Windows.Forms.TextBox textBoxReceiver_5;
        private System.Windows.Forms.Button buttonReceiver_5;
        private System.Windows.Forms.TextBox textBoxReceiver_6;
        private System.Windows.Forms.Button buttonReceiver_6;
        private System.Windows.Forms.TextBox textBoxReceiver_7;
        private System.Windows.Forms.Button buttonReceiver_7;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerFileSearch;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btRec_PathClear_1;
        private System.Windows.Forms.Button btRec_PathClear_2;
        private System.Windows.Forms.Button btRec_PathClear_3;
        private System.Windows.Forms.Button btRec_PathClear_4;
        private System.Windows.Forms.Button btRec_PathClear_5;
        private System.Windows.Forms.Button btRec_PathClear_6;
        private System.Windows.Forms.Button btRec_PathClear_7;
        private System.Windows.Forms.Label labelStatusString;
        private System.Windows.Forms.CheckBox checkBox_XAU_1;
        private System.Windows.Forms.CheckBox checkBox_XAU_2;
        private System.Windows.Forms.CheckBox checkBox_XAU_3;
        private System.Windows.Forms.CheckBox checkBox_XAU_4;
        private System.Windows.Forms.CheckBox checkBox_XAU_5;
        private System.Windows.Forms.CheckBox checkBox_XAU_6;
        private System.Windows.Forms.CheckBox checkBox_XAU_7;
    }
}

