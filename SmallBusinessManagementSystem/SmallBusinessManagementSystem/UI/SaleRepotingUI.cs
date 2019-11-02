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
    public partial class SaleRepotingUI : Form
    {
        public SaleRepotingUI()
        {
            InitializeComponent();
        }
        SaleRepotingManager _salerepotingManager = new SaleRepotingManager();
        private void searchButton_Click(object sender, EventArgs e)
        {
           //showdataGridView.DataSource = null;
            
            SaleRepotingModel salerepotingModel = new SaleRepotingModel();

            if (startDateTimePicker.Text ==" ") 
            {
                MessageBox.Show("please insert start date");
                return;

            }
            if (endDateTimePicker.Text ==" ")
            {
                MessageBox.Show("please insert end date");
                return;

            }
            salerepotingModel.Date = startDateTimePicker.Text;
            salerepotingModel.Date2 = endDateTimePicker.Text;
           
            bool ishas = !_salerepotingManager.SearchValue(salerepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showdataGridView.DataSource = _salerepotingManager.SearchValue(salerepotingModel);
            }
        }

        private void showdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showdataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            PurchaseRepotingUI newForm = new PurchaseRepotingUI();
            newForm.Show();
            this.Hide();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTimePicker.CustomFormat = "yyyy/MM/dd";
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTimePicker.CustomFormat = "yyyy/MM/dd";
        }

        private void endDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                startDateTimePicker.CustomFormat =" ";

            }
        }

        private void startDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                startDateTimePicker.CustomFormat =" ";

            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            HomeUI newForm = new HomeUI();
            newForm.Show();
            this.Hide();
        }

        private void namesearchButton_Click(object sender, EventArgs e)
        {

            SaleRepotingModel salerepotingModel = new SaleRepotingModel();

            if (nameTextBox.Text ==" ")
            {
                MessageBox.Show("please insert name");
                return;

            }
            
            salerepotingModel.Name = nameTextBox.Text;
           

            bool ishas = !_salerepotingManager.SearchValueByName(salerepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showdataGridView.DataSource = _salerepotingManager.SearchValueByName(salerepotingModel);
            }

        }
    }
    
}
