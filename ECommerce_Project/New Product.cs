using DBECommerce_Project.Entity;
using DBECommerce_Project.Operation;
using ECommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECommerce_Project
{
    public partial class newProductForm : Form
    {
        public newProductForm()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            EProduct product = new EProduct();
            product.ProductID = productIdBox.Text;
            product.ProductName = productNameBox.Text;
            product.ProductSeller = HomePage.loggedUser.Username;
            product.ProductPrice = Convert.ToInt32(productPriceBox.Text);
            product.ProductStock = Convert.ToInt32(stockBox.Text);

            OProduct oProduct = new OProduct();
            int res =  oProduct.addProduct(product);

            if (res > 0)
            {
                MessageBox.Show("The registration is complete");
                this.Hide();
                new sellerForm().Show();
            }
            else
            {
                MessageBox.Show("Error: " + res + "\nUnable to Add Product\nProduct already registered");
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
