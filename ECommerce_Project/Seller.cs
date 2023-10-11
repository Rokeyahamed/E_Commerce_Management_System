
using DBECommerce_Project.Entity;
using DBECommerce_Project.Operation;
using ECommerce_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECommerce
{
    public partial class sellerForm : Form
    {
        DataGridViewRow selectedRow = null;
        public sellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm(object sender, EventArgs e)
        {

        }

        private void addproductBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new newProductForm().Show();
        }

        private void editproductBtn_Click(object sender, EventArgs e)
        {
            if(selectedRow != null)
            {
                this.Hide();
                String id = selectedRow.Cells[0].Value.ToString();
                new editProductForm(id).Show();
            }
            else
            {
                MessageBox.Show("Please select a Product");
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            EProduct product = new EProduct();
            product.ProductName = searchBox.Text;
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlData = oProduct.getList();
            DataTable table = new DataTable();
            sqlData.Fill(table);
            DataView tableView = new DataView(table);

            tableView.RowFilter = "[productName] LIKE '%" + product.ProductName + "%'";

            productGridView.DataSource = tableView;
        }

        private void searchboxBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order_List().Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage.loggedUser = null;
            new HomePage().Show();
        }


        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= productGridView.Rows.Count)
            {
                MessageBox.Show("Invalid Selection");
                return;
            }
            selectedRow = productGridView.Rows[index];
            String name = selectedRow.Cells[3].Value.ToString();
            MessageBox.Show("Product Selected: " + name);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {


            String id = selectedRow.Cells[0].Value.ToString();

            OProduct oProduct = new OProduct();
            oProduct.deleteProduct(id);
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlData = oProduct.getList();
            DataTable table = new DataTable();
            sqlData.Fill(table);
            productGridView.DataSource = table;

            
        }
    }
}
