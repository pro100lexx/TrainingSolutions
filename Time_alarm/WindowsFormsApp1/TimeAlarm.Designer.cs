namespace WindowsFormsApp1
{
    partial class TimeAlarm
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
            this.minutesCounter = new System.Windows.Forms.NumericUpDown();
            this.secondsCounter = new System.Windows.Forms.NumericUpDown();
            this.sound_5M = new System.Windows.Forms.CheckBox();
            this.labelTimeNow = new System.Windows.Forms.Label();
            this.sound_30M = new System.Windows.Forms.CheckBox();
            this.sound_1H = new System.Windows.Forms.CheckBox();
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // minutesCounter
            // 
            this.minutesCounter.Location = new System.Drawing.Point(12, 12);
            this.minutesCounter.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minutesCounter.Name = "minutesCounter";
            this.minutesCounter.Size = new System.Drawing.Size(35, 20);
            this.minutesCounter.TabIndex = 0;
            this.minutesCounter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // secondsCounter
            // 
            this.secondsCounter.Location = new System.Drawing.Point(54, 12);
            this.secondsCounter.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsCounter.Name = "secondsCounter";
            this.secondsCounter.Size = new System.Drawing.Size(35, 20);
            this.secondsCounter.TabIndex = 1;
            this.secondsCounter.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // sound_5M
            // 
            this.sound_5M.AutoSize = true;
            this.sound_5M.Checked = true;
            this.sound_5M.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sound_5M.Location = new System.Drawing.Point(104, 15);
            this.sound_5M.Name = "sound_5M";
            this.sound_5M.Size = new System.Drawing.Size(41, 17);
            this.sound_5M.TabIndex = 2;
            this.sound_5M.Text = "5M";
            this.sound_5M.UseVisualStyleBackColor = true;
            // 
            // labelTimeNow
            // 
            this.labelTimeNow.AutoSize = true;
            this.labelTimeNow.Location = new System.Drawing.Point(9, 45);
            this.labelTimeNow.Name = "labelTimeNow";
            this.labelTimeNow.Size = new System.Drawing.Size(52, 13);
            this.labelTimeNow.TabIndex = 3;
            this.labelTimeNow.Text = "TimeNow";
            // 
            // sound_30M
            // 
            this.sound_30M.AutoSize = true;
            this.sound_30M.Checked = true;
            this.sound_30M.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sound_30M.Location = new System.Drawing.Point(104, 39);
            this.sound_30M.Name = "sound_30M";
            this.sound_30M.Size = new System.Drawing.Size(47, 17);
            this.sound_30M.TabIndex = 4;
            this.sound_30M.Text = "30M";
            this.sound_30M.UseVisualStyleBackColor = true;
            // 
            // sound_1H
            // 
            this.sound_1H.AutoSize = true;
            this.sound_1H.Checked = true;
            this.sound_1H.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sound_1H.Location = new System.Drawing.Point(104, 63);
            this.sound_1H.Name = "sound_1H";
            this.sound_1H.Size = new System.Drawing.Size(40, 17);
            this.sound_1H.TabIndex = 5;
            this.sound_1H.Text = "1H";
            this.sound_1H.UseVisualStyleBackColor = true;
            // 
            // secTimer
            // 
            this.secTimer.Enabled = true;
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.SecTimer_Tick);
            // 
            // TimeAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 90);
            this.Controls.Add(this.sound_1H);
            this.Controls.Add(this.sound_30M);
            this.Controls.Add(this.labelTimeNow);
            this.Controls.Add(this.sound_5M);
            this.Controls.Add(this.secondsCounter);
            this.Controls.Add(this.minutesCounter);
            this.Name = "TimeAlarm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown minutesCounter;
        private System.Windows.Forms.NumericUpDown secondsCounter;
        private System.Windows.Forms.CheckBox sound_5M;
        private System.Windows.Forms.Label labelTimeNow;
        private System.Windows.Forms.CheckBox sound_30M;
        private System.Windows.Forms.CheckBox sound_1H;
        private System.Windows.Forms.Timer secTimer;
    }
}

