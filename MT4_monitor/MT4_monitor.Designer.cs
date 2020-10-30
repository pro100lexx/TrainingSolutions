namespace MT4_monitor
{
    partial class MT4_monitor
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.timerForRefresh = new System.Windows.Forms.Timer(this.components);
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonCloseALL = new System.Windows.Forms.Button();
            this.buttonDBset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(426, 108);
            this.dataGridView.TabIndex = 0;
            // 
            // timerForRefresh
            // 
            this.timerForRefresh.Interval = 1000;
            this.timerForRefresh.Tick += new System.EventHandler(this.timerForRefresh_Tick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonRefresh.Location = new System.Drawing.Point(12, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(53, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Старт";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(71, 12);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(67, 23);
            this.buttonReload.TabIndex = 2;
            this.buttonReload.Text = "Обновить";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonCloseALL
            // 
            this.buttonCloseALL.BackColor = System.Drawing.Color.Tomato;
            this.buttonCloseALL.Location = new System.Drawing.Point(363, 12);
            this.buttonCloseALL.Name = "buttonCloseALL";
            this.buttonCloseALL.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseALL.TabIndex = 3;
            this.buttonCloseALL.Text = "CLOSEALL";
            this.buttonCloseALL.UseVisualStyleBackColor = false;
            this.buttonCloseALL.Click += new System.EventHandler(this.buttonCloseALL_Click);
            // 
            // buttonDBset
            // 
            this.buttonDBset.Location = new System.Drawing.Point(144, 12);
            this.buttonDBset.Name = "buttonDBset";
            this.buttonDBset.Size = new System.Drawing.Size(34, 23);
            this.buttonDBset.TabIndex = 4;
            this.buttonDBset.Text = "БД";
            this.buttonDBset.UseVisualStyleBackColor = true;
            this.buttonDBset.Click += new System.EventHandler(this.buttonDBset_Click);
            // 
            // MT4_monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 161);
            this.Controls.Add(this.buttonDBset);
            this.Controls.Add(this.buttonCloseALL);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(466, 200);
            this.Name = "MT4_monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мониторинг счетов MT4";
            this.Load += new System.EventHandler(this.MT4_monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Timer timerForRefresh;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonCloseALL;
        private System.Windows.Forms.Button buttonDBset;
    }
}

