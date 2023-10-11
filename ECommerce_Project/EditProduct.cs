using DBECommerce_Project.Entity;
using DBECommerce_Project.Operation;
using ECommerce;
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

namespace ECommerce_Project
{
    public partial class editProductForm : Form
    {
        EProduct product = new EProduct();

        public editProductForm()
        {
            InitializeComponent();
        }
        public editProductForm(String productID)
        {
            InitializeComponent();
            this.product.ProductID = productID;
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlData = oProduct.getList();
            DataTable table = new DataTable();
            sqlData.Fill(table);
            DataView tableView = new DataView(table);

            tableView.RowFilter = "[productID] = '" + product.ProductID + "'";
            product.ProductName = tableView[0][3].ToString();
            MessageBox.Show(product.ProductName);
            product.ProductPrice = Convert.ToInt32(tableView[0][2].ToString());
            product.ProductStock = Convert.ToInt32(tableView[0][4].ToString());
            oldProductNameBox.Text = product.ProductName;
            oldPriceBox.Text = product.ProductPrice.ToString();
            oldStockStatusBox.Text = product.ProductStock.ToString();

        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            

            EProduct newProduct = new EProduct();

            newProduct.ProductID = product.ProductID;

            if(renameProductBox.Text.Length > 0)
            {
                newProduct.ProductName = renameProductBox.Text;
            }
            else
            {
                newProduct.ProductName = product.ProductName;
            }

            if (renamePriceBox.Text.Length > 0)
            {
                newProduct.ProductPrice = Convert.ToInt32(renamePriceBox.Text);
            }
            else
            {
                newProduct.ProductPrice = Convert.ToInt32(oldPriceBox.Text);
            }
            if (newStockStatusBox.Text.Length > 0)
            {
                newProduct.ProductStock = Convert.ToInt32(newStockStatusBox.Text);
            }
            else
            {
                newProduct.ProductStock = Convert.ToInt32(oldStockStatusBox.Text);
            }

            OProduct oProduct = new OProduct();
            int res = oProduct.editProduct(newProduct);

            if (res > 0)
            {
                MessageBox.Show("Product Details have been updated");
                this.Hide();
                new sellerForm().Show();
            }
            else
            {
                MessageBox.Show("Unable to Update Product Details");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage.loggedUser = null;
            new HomePage().Show();
        }
    }
}
