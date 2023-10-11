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
    public partial class HomePage : Form
    {
        public static EUser loggedUser;
        public static int orderCount = 0;
        public HomePage()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EUser user = new EUser();
            user.Username = usernameBox.Text;
            user.Password = passwordBox.Text;

            OUser userOp = new OUser();
            EUser newUser = userOp.login(user);

            if (newUser.Username == "INVALID")
            {
                MessageBox.Show("Incorrect Usernane/Password");
                return;
            }
            HomePage.loggedUser = newUser;
            MessageBox.Show("Login Successful\nUser:" + newUser.Username + "\nAccount Type: " + newUser.AccountType );

            if (newUser.AccountType == "Seller")
            {
                this.Hide();
                new sellerForm().Show();
            }
            else if (newUser.AccountType == "Customer")
            {
                this.Hide();
                new customerForm().Show();
            }
        }

        private void buttonShowLog_Click(object sender, EventArgs e)
        {
            OUser oUser = new OUser();
            SqlDataAdapter sqlData = oUser.ShowLog();
            DataTable table = new DataTable();
            sqlData.Fill(table);

            dataGridView.DataSource = table;

        }

        private void buttonAdvance_Click(object sender, EventArgs e)
        {
            this.Hide();
            new advancedOptions().Show();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }


        private void adminBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (adminBtn.Checked)
            {
                buttonAdvance.Visible = true;
                dataGridView.Visible = true;
                buttonShowLog.Visible = true;
            }
            else
            {
                buttonAdvance.Visible = false;
                dataGridView.Visible = false;
                buttonShowLog.Visible = false;
            }
        }

        private void userBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (adminBtn.Checked)
            {
                buttonAdvance.Visible = false;
                dataGridView.Visible = false;
                buttonShowLog.Visible = false;
            }
        }
    }
}
