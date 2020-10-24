namespace CorsairsTrading
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
            this.comboBoxSelectTown = new System.Windows.Forms.ComboBox();
            this.townsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.townsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwTownBuy = new System.Windows.Forms.DataGridView();
            this.dgwHighrock = new System.Windows.Forms.DataGridView();
            this.dgwTendeils = new System.Windows.Forms.DataGridView();
            this.dgwDIsland = new System.Windows.Forms.DataGridView();
            this.dgwWeight = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgwProfit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.dataSetCSdb = new CorsairsTrading.DataSetCSdb();
            this.dataSetCSdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.townsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.townsTableAdapter1 = new CorsairsTrading.DataSetCSdbTableAdapters.TownsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new CorsairsTrading.DataSetCSdbTableAdapters.ProductsTableAdapter();
            this.townsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTownBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHighrock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTendeils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDIsland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCSdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCSdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Покупаем в:";
            // 
            // comboBoxSelectTown
            // 
            this.comboBoxSelectTown.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.townsBindingSource1, "TownName", true));
            this.comboBoxSelectTown.DataSource = this.townsBindingSource2;
            this.comboBoxSelectTown.DisplayMember = "TownName";
            this.comboBoxSelectTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelectTown.FormattingEnabled = true;
            this.comboBoxSelectTown.Location = new System.Drawing.Point(12, 471);
            this.comboBoxSelectTown.Name = "comboBoxSelectTown";
            this.comboBoxSelectTown.Size = new System.Drawing.Size(119, 24);
            this.comboBoxSelectTown.TabIndex = 3;
            this.comboBoxSelectTown.ValueMember = "TownName";
            // 
            // townsBindingSource
            // 
            this.townsBindingSource.DataSource = this.townsDataSetBindingSource;
            // 
            // dgwTownBuy
            // 
            this.dgwTownBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgwTownBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTownBuy.ColumnHeadersVisible = false;
            this.dgwTownBuy.Location = new System.Drawing.Point(12, 88);
            this.dgwTownBuy.Name = "dgwTownBuy";
            this.dgwTownBuy.RowHeadersVisible = false;
            this.dgwTownBuy.Size = new System.Drawing.Size(119, 377);
            this.dgwTownBuy.TabIndex = 4;
            // 
            // dgwHighrock
            // 
            this.dgwHighrock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHighrock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHighrock.ColumnHeadersVisible = false;
            this.dgwHighrock.Location = new System.Drawing.Point(173, 88);
            this.dgwHighrock.Name = "dgwHighrock";
            this.dgwHighrock.RowHeadersVisible = false;
            this.dgwHighrock.Size = new System.Drawing.Size(30, 377);
            this.dgwHighrock.TabIndex = 8;
            // 
            // dgwTendeils
            // 
            this.dgwTendeils.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTendeils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTendeils.ColumnHeadersVisible = false;
            this.dgwTendeils.Location = new System.Drawing.Point(209, 88);
            this.dgwTendeils.Name = "dgwTendeils";
            this.dgwTendeils.RowHeadersVisible = false;
            this.dgwTendeils.Size = new System.Drawing.Size(30, 377);
            this.dgwTendeils.TabIndex = 9;
            // 
            // dgwDIsland
            // 
            this.dgwDIsland.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDIsland.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDIsland.ColumnHeadersVisible = false;
            this.dgwDIsland.Location = new System.Drawing.Point(245, 88);
            this.dgwDIsland.Name = "dgwDIsland";
            this.dgwDIsland.RowHeadersVisible = false;
            this.dgwDIsland.Size = new System.Drawing.Size(30, 377);
            this.dgwDIsland.TabIndex = 10;
            // 
            // dgwWeight
            // 
            this.dgwWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWeight.ColumnHeadersVisible = false;
            this.dgwWeight.Location = new System.Drawing.Point(137, 88);
            this.dgwWeight.Name = "dgwWeight";
            this.dgwWeight.RowHeadersVisible = false;
            this.dgwWeight.Size = new System.Drawing.Size(30, 377);
            this.dgwWeight.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(144, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вес";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(298, 468);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(224, 27);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Расчет";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "...";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(181, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Хайрок";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(216, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Тендейлз";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(251, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "М. Остров";
            // 
            // dgwProfit
            // 
            this.dgwProfit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProfit.Location = new System.Drawing.Point(299, 88);
            this.dgwProfit.Name = "dgwProfit";
            this.dgwProfit.RowHeadersVisible = false;
            this.dgwProfit.Size = new System.Drawing.Size(223, 377);
            this.dgwProfit.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(294, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Топ выгоды - везём туда!";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(150, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Трюм:";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCapacity.Location = new System.Drawing.Point(209, 470);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(66, 26);
            this.textBoxCapacity.TabIndex = 21;
            this.textBoxCapacity.Text = "100";
            // 
            // dataSetCSdb
            // 
            this.dataSetCSdb.DataSetName = "DataSetCSdb";
            this.dataSetCSdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetCSdbBindingSource
            // 
            this.dataSetCSdbBindingSource.DataSource = this.dataSetCSdb;
            this.dataSetCSdbBindingSource.Position = 0;
            // 
            // townsBindingSource1
            // 
            this.townsBindingSource1.DataMember = "Towns";
            this.townsBindingSource1.DataSource = this.dataSetCSdbBindingSource;
            // 
            // townsTableAdapter1
            // 
            this.townsTableAdapter1.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dataSetCSdbBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // townsBindingSource2
            // 
            this.townsBindingSource2.DataMember = "Towns";
            this.townsBindingSource2.DataSource = this.dataSetCSdb;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 507);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwProfit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dgwWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgwDIsland);
            this.Controls.Add(this.dgwTendeils);
            this.Controls.Add(this.dgwHighrock);
            this.Controls.Add(this.dgwTownBuy);
            this.Controls.Add(this.comboBoxSelectTown);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Corsairs Trading Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTownBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHighrock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTendeils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDIsland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCSdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCSdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectTown;
        private System.Windows.Forms.BindingSource townsDataSetBindingSource;
        private System.Windows.Forms.BindingSource townsBindingSource;
        private System.Windows.Forms.DataGridView dgwTownBuy;
        private System.Windows.Forms.DataGridView dgwHighrock;
        private System.Windows.Forms.DataGridView dgwTendeils;
        private System.Windows.Forms.DataGridView dgwDIsland;
        private System.Windows.Forms.DataGridView dgwWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgwProfit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.BindingSource dataSetCSdbBindingSource;
        private DataSetCSdb dataSetCSdb;
        private System.Windows.Forms.BindingSource townsBindingSource1;
        private DataSetCSdbTableAdapters.TownsTableAdapter townsTableAdapter1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DataSetCSdbTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource townsBindingSource2;
    }
}

