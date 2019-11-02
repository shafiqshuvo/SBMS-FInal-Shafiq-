using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagementSystem.Manager;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.UI
{
    public partial class PurchaseRepotingUI : Form
    {
        public PurchaseRepotingUI()
        {
            InitializeComponent();
        }
        PurchaseRepotingManager _purchaserepotingManager = new PurchaseRepotingManager();
        private void searchButton_Click(object sender, EventArgs e)
        {
            //showdataGridView.DataSource = null;

            PurchaseRepotingModel purchaserepotingModel = new PurchaseRepotingModel();

            if (startDateTimePicker.Text ==" " )
            {
                MessageBox.Show("please insert start date");
                return;

            }
            if (endDateTimePicker.Text ==" ")
            {
                MessageBox.Show("please insert end date");
                return;

            }
            purchaserepotingModel.Date = startDateTimePicker.Text;
            purchaserepotingModel.Date2 = endDateTimePicker.Text;

            bool ishas = !_purchaserepotingManager.SearchValue(purchaserepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showdataGridView.DataSource = _purchaserepotingManager.SearchValue(purchaserepotingModel);
            }
        }

        private void showdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showdataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            SaleRepotingUI newForm = new SaleRepotingUI();
            newForm.Show();
            this.Hide();
        }

        private void crossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                startDateTimePicker.CustomFormat = " ";

            }
        }

        private void endDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                endDateTimePicker.CustomFormat = " ";

            }
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTimePicker.CustomFormat = "yyyy / MM / dd";
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTimePicker.CustomFormat = "yyyy / MM / dd";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            HomeUI newForm = new HomeUI();
            newForm.Show();
            this.Hide();
        }

        private void searchiconButton_Click(object sender, EventArgs e)
        {
            PurchaseRepotingModel purchaserepotingModel = new PurchaseRepotingModel();

            if (nameTextBox.Text ==" ")
            {
                MessageBox.Show("please insert name");
                return;

            }
            
            purchaserepotingModel.Name = nameTextBox.Text;
            

            bool ishas = !_purchaserepotingManager.SearchValueByName(purchaserepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showdataGridView.DataSource = _purchaserepotingManager.SearchValueByName(purchaserepotingModel);
            }
        }
    }
}
