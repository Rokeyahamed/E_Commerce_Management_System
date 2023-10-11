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
    public partial class Order_List : Form
    {
        public Order_List()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            OOrder oOrder = new OOrder();
            SqlDataAdapter sqlData = oOrder.viewOrder(HomePage.loggedUser);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            orderGridView.DataSource = table;
        }
    }
}
