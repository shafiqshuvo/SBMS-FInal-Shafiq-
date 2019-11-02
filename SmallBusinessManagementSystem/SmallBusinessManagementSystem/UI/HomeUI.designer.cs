namespace SmallBusinessManagementSystem.UI
{
    partial class HomeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUI));
            this.label1 = new System.Windows.Forms.Label();
            this.categoryButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.supplyerButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.salesreportButton = new System.Windows.Forms.Button();
            this.purchasereportbutton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME SMALL SHOP";
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryButton.Image = ((System.Drawing.Image)(resources.GetObject("categoryButton.Image")));
            this.categoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.Location = new System.Drawing.Point(74, 115);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(150, 50);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Product Category";
            this.categoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            this.categoryButton.Paint += new System.Windows.Forms.PaintEventHandler(this.categoryButton_Paint);
            this.categoryButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.categoryButton_MouseDown);
            this.categoryButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.categoryButton_MouseUp);
            // 
            // productButton
            // 
            this.productButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.productButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(74, 183);
            this.productButton.Margin = new System.Windows.Forms.Padding(0);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(150, 50);
            this.productButton.TabIndex = 3;
            this.productButton.Text = "Product Add";
            this.productButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // supplyerButton
            // 
            this.supplyerButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.supplyerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplyerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplyerButton.Image = ((System.Drawing.Image)(resources.GetObject("supplyerButton.Image")));
            this.supplyerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplyerButton.Location = new System.Drawing.Point(285, 115);
            this.supplyerButton.Margin = new System.Windows.Forms.Padding(0);
            this.supplyerButton.Name = "supplyerButton";
            this.supplyerButton.Size = new System.Drawing.Size(150, 50);
            this.supplyerButton.TabIndex = 4;
            this.supplyerButton.Text = "Supplyer Detail";
            this.supplyerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.supplyerButton.UseVisualStyleBackColor = false;
            this.supplyerButton.Click += new System.EventHandler(this.supplyerButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerButton.Image = ((System.Drawing.Image)(resources.GetObject("customerButton.Image")));
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(74, 263);
            this.customerButton.Margin = new System.Windows.Forms.Padding(0);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(150, 50);
            this.customerButton.TabIndex = 5;
            this.customerButton.Text = "Add Customer";
            this.customerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.salesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesButton.Image = ((System.Drawing.Image)(resources.GetObject("salesButton.Image")));
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(285, 263);
            this.salesButton.Margin = new System.Windows.Forms.Padding(0);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(150, 50);
            this.salesButton.TabIndex = 6;
            this.salesButton.Text = "Sales Product";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.purchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchaseButton.Image = ((System.Drawing.Image)(resources.GetObject("purchaseButton.Image")));
            this.purchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseButton.Location = new System.Drawing.Point(285, 183);
            this.purchaseButton.Margin = new System.Windows.Forms.Padding(0);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(150, 50);
            this.purchaseButton.TabIndex = 7;
            this.purchaseButton.Text = "Purchase \r\nProduct\r\n";
            this.purchaseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.purchaseButton.UseVisualStyleBackColor = false;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.stockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockButton.Image = ((System.Drawing.Image)(resources.GetObject("stockButton.Image")));
            this.stockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockButton.Location = new System.Drawing.Point(490, 115);
            this.stockButton.Margin = new System.Windows.Forms.Padding(0);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(150, 50);
            this.stockButton.TabIndex = 8;
            this.stockButton.Text = "Stock Details";
            this.stockButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stockButton.UseVisualStyleBackColor = false;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // salesreportButton
            // 
            this.salesreportButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.salesreportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesreportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesreportButton.Image = ((System.Drawing.Image)(resources.GetObject("salesreportButton.Image")));
            this.salesreportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesreportButton.Location = new System.Drawing.Point(490, 184);
            this.salesreportButton.Margin = new System.Windows.Forms.Padding(0);
            this.salesreportButton.Name = "salesreportButton";
            this.salesreportButton.Size = new System.Drawing.Size(150, 50);
            this.salesreportButton.TabIndex = 9;
            this.salesreportButton.Text = "Sales Report";
            this.salesreportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salesreportButton.UseVisualStyleBackColor = false;
            this.salesreportButton.Click += new System.EventHandler(this.salesreportButton_Click);
            // 
            // purchasereportbutton
            // 
            this.purchasereportbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.purchasereportbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasereportbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchasereportbutton.Image = ((System.Drawing.Image)(resources.GetObject("purchasereportbutton.Image")));
            this.purchasereportbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchasereportbutton.Location = new System.Drawing.Point(490, 262);
            this.purchasereportbutton.Margin = new System.Windows.Forms.Padding(0);
            this.purchasereportbutton.Name = "purchasereportbutton";
            this.purchasereportbutton.Size = new System.Drawing.Size(150, 50);
            this.purchasereportbutton.TabIndex = 10;
            this.purchasereportbutton.Text = "Purchase \r\nReport";
            this.purchasereportbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.purchasereportbutton.UseVisualStyleBackColor = false;
            this.purchasereportbutton.Click += new System.EventHandler(this.purchasereportbutton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(27, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchasereportbutton);
            this.Controls.Add(this.salesreportButton);
            this.Controls.Add(this.stockButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.supplyerButton);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.categoryButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button supplyerButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button salesreportButton;
        private System.Windows.Forms.Button purchasereportbutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}