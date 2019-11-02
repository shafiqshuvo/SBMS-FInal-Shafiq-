namespace SmallBusinessManagementSystem.UI
{
    partial class StockPeriodicalUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockPeriodicalUI));
            this.Product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expiredCheckBox = new System.Windows.Forms.CheckBox();
            this.reorderLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.damageCheckBox = new System.Windows.Forms.CheckBox();
            this.lostCheckBox = new System.Windows.Forms.CheckBox();
            this.searchStockButton = new System.Windows.Forms.Button();
            this.stockSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.homeButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.stockPeriodicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderlavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPeriodicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(74, 110);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(44, 13);
            this.Product.TabIndex = 0;
            this.Product.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date";
            // 
            // expiredCheckBox
            // 
            this.expiredCheckBox.AutoSize = true;
            this.expiredCheckBox.Location = new System.Drawing.Point(262, 156);
            this.expiredCheckBox.Name = "expiredCheckBox";
            this.expiredCheckBox.Size = new System.Drawing.Size(64, 17);
            this.expiredCheckBox.TabIndex = 2;
            this.expiredCheckBox.Text = "Expired ";
            this.expiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // reorderLevelCheckBox
            // 
            this.reorderLevelCheckBox.AutoSize = true;
            this.reorderLevelCheckBox.Location = new System.Drawing.Point(136, 156);
            this.reorderLevelCheckBox.Name = "reorderLevelCheckBox";
            this.reorderLevelCheckBox.Size = new System.Drawing.Size(98, 17);
            this.reorderLevelCheckBox.TabIndex = 2;
            this.reorderLevelCheckBox.Text = "Re-Order Lavel";
            this.reorderLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // damageCheckBox
            // 
            this.damageCheckBox.AutoSize = true;
            this.damageCheckBox.Location = new System.Drawing.Point(406, 156);
            this.damageCheckBox.Name = "damageCheckBox";
            this.damageCheckBox.Size = new System.Drawing.Size(66, 17);
            this.damageCheckBox.TabIndex = 2;
            this.damageCheckBox.Text = "Damage";
            this.damageCheckBox.UseVisualStyleBackColor = true;
            // 
            // lostCheckBox
            // 
            this.lostCheckBox.AutoSize = true;
            this.lostCheckBox.Location = new System.Drawing.Point(551, 156);
            this.lostCheckBox.Name = "lostCheckBox";
            this.lostCheckBox.Size = new System.Drawing.Size(46, 17);
            this.lostCheckBox.TabIndex = 2;
            this.lostCheckBox.Text = "Lost";
            this.lostCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchStockButton
            // 
            this.searchStockButton.Location = new System.Drawing.Point(539, 191);
            this.searchStockButton.Name = "searchStockButton";
            this.searchStockButton.Size = new System.Drawing.Size(75, 23);
            this.searchStockButton.TabIndex = 3;
            this.searchStockButton.Text = "Search";
            this.searchStockButton.UseVisualStyleBackColor = true;
            this.searchStockButton.Click += new System.EventHandler(this.searchStockButton_Click);
            // 
            // stockSearchDataGridView
            // 
            this.stockSearchDataGridView.AutoGenerateColumns = false;
            this.stockSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SI,
            this.productNameDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.expiredDateDataGridViewTextBoxColumn,
            this.reorderlavelDataGridViewTextBoxColumn,
            this.openingBalanceDataGridViewTextBoxColumn,
            this.inDataGridViewTextBoxColumn,
            this.outDataGridViewTextBoxColumn,
            this.closingBalanceDataGridViewTextBoxColumn});
            this.stockSearchDataGridView.DataSource = this.stockPeriodicalBindingSource;
            this.stockSearchDataGridView.Location = new System.Drawing.Point(12, 235);
            this.stockSearchDataGridView.Name = "stockSearchDataGridView";
            this.stockSearchDataGridView.Size = new System.Drawing.Size(1034, 215);
            this.stockSearchDataGridView.TabIndex = 4;
            this.stockSearchDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.stockSearchDataGridView_RowPostPaint);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Checked = false;
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(480, 58);
            this.startDateTimePicker.MaxDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.startDateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 5;
            this.startDateTimePicker.Value = new System.DateTime(2019, 10, 25, 0, 0, 0, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Checked = false;
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(480, 107);
            this.endDateTimePicker.MaxDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 5;
            this.endDateTimePicker.Value = new System.DateTime(2019, 10, 25, 0, 0, 0, 0);
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(508, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(43, 35);
            this.homeButton.TabIndex = 8;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(136, 56);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(162, 21);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.categoryComboBox_SelectedValueChanged);
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(136, 107);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(162, 21);
            this.productComboBox.TabIndex = 10;
            this.productComboBox.SelectedValueChanged += new System.EventHandler(this.productComboBox_SelectedValueChanged);
            // 
            // stockPeriodicalBindingSource
            // 
            this.stockPeriodicalBindingSource.DataSource = typeof(SmallBusinessManagementSystem.Model.StockPeriodical);
            // 
            // categoryModelBindingSource
            // 
            this.categoryModelBindingSource.DataSource = typeof(SmallBusinessManagementSystem.Model.CategoryModel);
            // 
            // SI
            // 
            this.SI.HeaderText = "SI";
            this.SI.Name = "SI";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "productCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            // 
            // expiredDateDataGridViewTextBoxColumn
            // 
            this.expiredDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiredDate";
            this.expiredDateDataGridViewTextBoxColumn.HeaderText = "Expired Date";
            this.expiredDateDataGridViewTextBoxColumn.Name = "expiredDateDataGridViewTextBoxColumn";
            // 
            // reorderlavelDataGridViewTextBoxColumn
            // 
            this.reorderlavelDataGridViewTextBoxColumn.DataPropertyName = "Reorderlavel";
            this.reorderlavelDataGridViewTextBoxColumn.HeaderText = "Reorder level";
            this.reorderlavelDataGridViewTextBoxColumn.Name = "reorderlavelDataGridViewTextBoxColumn";
            // 
            // openingBalanceDataGridViewTextBoxColumn
            // 
            this.openingBalanceDataGridViewTextBoxColumn.DataPropertyName = "OpeningBalance";
            this.openingBalanceDataGridViewTextBoxColumn.HeaderText = "Opening Balance";
            this.openingBalanceDataGridViewTextBoxColumn.Name = "openingBalanceDataGridViewTextBoxColumn";
            // 
            // inDataGridViewTextBoxColumn
            // 
            this.inDataGridViewTextBoxColumn.DataPropertyName = "In";
            this.inDataGridViewTextBoxColumn.HeaderText = "In";
            this.inDataGridViewTextBoxColumn.Name = "inDataGridViewTextBoxColumn";
            // 
            // outDataGridViewTextBoxColumn
            // 
            this.outDataGridViewTextBoxColumn.DataPropertyName = "Out";
            this.outDataGridViewTextBoxColumn.HeaderText = "Out";
            this.outDataGridViewTextBoxColumn.Name = "outDataGridViewTextBoxColumn";
            // 
            // closingBalanceDataGridViewTextBoxColumn
            // 
            this.closingBalanceDataGridViewTextBoxColumn.DataPropertyName = "ClosingBalance";
            this.closingBalanceDataGridViewTextBoxColumn.HeaderText = "Closing Balance";
            this.closingBalanceDataGridViewTextBoxColumn.Name = "closingBalanceDataGridViewTextBoxColumn";
            // 
            // StockPeriodicalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.stockSearchDataGridView);
            this.Controls.Add(this.searchStockButton);
            this.Controls.Add(this.reorderLevelCheckBox);
            this.Controls.Add(this.lostCheckBox);
            this.Controls.Add(this.damageCheckBox);
            this.Controls.Add(this.expiredCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Product);
            this.Name = "StockPeriodicalUI";
            this.Text = "StockPeriodicalUI";
            this.Load += new System.EventHandler(this.StockPeriodicalUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPeriodicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox expiredCheckBox;
        private System.Windows.Forms.CheckBox reorderLevelCheckBox;
        private System.Windows.Forms.CheckBox damageCheckBox;
        private System.Windows.Forms.CheckBox lostCheckBox;
        private System.Windows.Forms.Button searchStockButton;
        private System.Windows.Forms.DataGridView stockSearchDataGridView;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoryModelBindingSource;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.BindingSource stockPeriodicalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderlavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingBalanceDataGridViewTextBoxColumn;
    }
}