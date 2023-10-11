using DBECommerce_Project.Entity;
using DBECommerce_Project.Operation;
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
    public partial class customerForm : Form
    {
        DataGridViewRow selectedRow = null;
        public customerForm()
        {
            InitializeComponent();
        }

        private void Product_Page_Load(object sender, EventArgs e)
        {

        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            EProduct product = new EProduct();
            product.ProductName = searchBox.Text;
            OUser oUser = new OUser();
            SqlDataAdapter sqlData = oUser.ShowLog();
            DataTable table = new DataTable();
            sqlData.Fill(table);
            DataView tableView = new DataView(table);

            tableView.RowFilter = "[username] LIKE '" + product.ProductName + "'";

            customerGridView.DataSource = tableView;
        }

        private void addCart_Click(object sender, EventArgs e)
        {

            if (selectedRow != null)
            {
                EOrder order = new EOrder();
                order.OrderID = "O-" + (++HomePage.orderCount).ToString(); 
                order.OrderSeller = selectedRow.Cells[1].Value.ToString();
                order.OrderCustomer = HomePage.loggedUser.Username;
                order.ProductName = selectedRow.Cells[3].Value.ToString();
                order.ProductPrice = Convert.ToInt32(selectedRow.Cells[2].Value.ToString());

                OOrder oOrder = new OOrder();
                oOrder.addOrder(order);
                MessageBox.Show("   Order Confirmed \nProduct Name: " + order.ProductName + "\nProduct Price: " + order.ProductPrice + "\nProduct Seller: " + order.OrderSeller);
            }
            else
            {
                MessageBox.Show("Please select a Product");
            }
        }

        private void customerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= customerGridView.Rows.Count)
            {
                MessageBox.Show("Invalid Selection");
                return;
            }
            selectedRow = customerGridView.Rows[index];
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlData = oProduct.getList();
            DataTable table = new DataTable();
            sqlData.Fill(table);
            customerGridView.DataSource = table;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage.loggedUser = null;
            new HomePage().Show();
        }

        private void orderListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order_List().Show();
        }
    }
}
