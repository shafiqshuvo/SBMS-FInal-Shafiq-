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
    public partial class StockPeriodicalUI : Form
    {
        public StockPeriodicalUI()
        {
            InitializeComponent();
        }

       
        StockPeriodicalManager _stockPeriodicalManager = new StockPeriodicalManager();
        StockPeriodical stockPeriodical = new StockPeriodical();

        private bool _isCategorySelected = false, _isProductSelected = false;

        private void searchStockButton_Click(object sender, EventArgs e)
        {
            stockPeriodical.startDate = startDateTimePicker.Text;
            stockPeriodical.endDate = endDateTimePicker.Text;

            if ((reorderLevelCheckBox.Checked) && _stockPeriodicalManager.searchStockByReorderLevel(stockPeriodical).Any())
            {

                MessageBox.Show("Search Stock By Lower Re-order Level....");
                stockSearchDataGridView.DataSource = _stockPeriodicalManager.searchStockByReorderLevel(stockPeriodical);
            }

            else if ((!reorderLevelCheckBox.Checked) && _stockPeriodicalManager.searchStock(stockPeriodical).Any())
            {
                MessageBox.Show("Search stock By Selected Item .. ");
                stockSearchDataGridView.DataSource = _stockPeriodicalManager.searchStock(stockPeriodical);
            }
           
            else
            {
                MessageBox.Show("No Data Found Between:  "+stockPeriodical.startDate+ " And " +stockPeriodical.endDate);
                return;
            }
     


        }

        private void stockSearchDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            stockSearchDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeUI newForm = new HomeUI();
            newForm.Show();
            this.Hide();
        }

        private void StockPeriodicalUI_Load(object sender, EventArgs e)
        {
            reorderLevelCheckBox.Checked = true;
            categoryComboBox.DataSource = _stockPeriodicalManager.GetCategoryList();

            categoryComboBox.ValueMember = "Code";
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.SelectedIndex = -1;

        }

        private void productComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (productComboBox.SelectedIndex != 0) _isProductSelected = true;
            if (productComboBox.SelectedIndex == -1) return;
            if (_isProductSelected)
            {
                
                stockPeriodical.productCategory = ((CategoryModel)categoryComboBox.SelectedItem).Name ;
                stockPeriodical.CategoryCode = ((CategoryModel)categoryComboBox.SelectedItem).Code;
                stockPeriodical.productName = ((ProductModel)productComboBox.SelectedItem).Name;
                stockPeriodical.ProductCode = ((ProductModel)productComboBox.SelectedItem).Code;
               
            }

        }

        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != 0)
            {
                _isCategorySelected = true;
            }

            
            if (categoryComboBox.SelectedIndex == -1)
            {
                return;
            }
            
            if (_isCategorySelected)
            {
               
                productComboBox.DataSource =_stockPeriodicalManager.GetProductList(((CategoryModel)categoryComboBox.SelectedItem).Code.ToString());
                productComboBox.ValueMember = "Code";
                productComboBox.DisplayMember = "Name";
                _isProductSelected = false;
                             
            }
        }
    }
}
