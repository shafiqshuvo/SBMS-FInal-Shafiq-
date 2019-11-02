using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.UI
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private bool blnButtonDown = false;

        private void categoryButton_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void categoryButton_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void categoryButton_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void purchasereportbutton_Click(object sender, EventArgs e)
        {
            PurchaseRepotingUI newForm = new PurchaseRepotingUI();
            newForm.Show();
            this.Hide();
        }

        private void salesreportButton_Click(object sender, EventArgs e)
        {
            SaleRepotingUI newForm = new SaleRepotingUI();
            newForm.Show();
            this.Hide();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            StockPeriodicalUI newForm = new StockPeriodicalUI();
            newForm.Show();
            this.Hide();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            SalesUI newForm = new SalesUI();
            newForm.Show();
            this.Hide();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseUI newForm = new PurchaseUI();
            newForm.Show();
            this.Hide();
        }

        private void supplyerButton_Click(object sender, EventArgs e)
        {
            SupplierEntryUI newForm = new SupplierEntryUI();
            newForm.Show();
            this.Hide();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            CustomerUI newForm = new CustomerUI();
            newForm.Show();
            this.Hide();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            ProductUI newForm = new ProductUI();
            newForm.Show();
            this.Hide();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryUI newForm = new CategoryUI();
            newForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();

        }
    }
}
