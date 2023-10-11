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
    public partial class advancedOptions : Form
    {
        public advancedOptions()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            EUser user = new EUser();
            user.Username = usernameBox.Text;
            OUser oUser = new OUser();
            //SqlDataReader sqlDataRead = oUser.searchUser(usernameBox.Text);
            SqlDataAdapter sqlData = oUser.ShowLog();
            DataTable table = new DataTable();
            sqlData.Fill(table);
            DataView tableView = new DataView(table);

            tableView.RowFilter = "[username] LIKE '" + user.Username + "'";

            MessageBox.Show(tableView[0][1] as String);
            searchGridView.DataSource = tableView;

        }

        private void buttonDetele_Click(object sender, EventArgs e)
        {
            EUser user = new EUser();
            user.Username = usernameBox.Text;
            OUser oUser = new OUser();
            int check = oUser.deleteUser(user);

            if (check > 0)
            {
                MessageBox.Show("Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            usernameLabel.Visible = false;
            usernameBox.Visible = false;
            searchBtn.Visible = false;
            deleteButton.Visible = false;
            buttonUpdate.Visible = false;
            buttonSave.Visible = true;
            newPass.Visible = true;
            newPassLabel.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            EUser user = new EUser();
            user.Username = usernameBox.Text;
            user.Password = newPass.Text;

            OUser oUser = new OUser();
            int check = oUser.updatePass(user);

            if (check > 0)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            usernameLabel.Visible = true;
            usernameBox.Visible = true;
            searchBtn.Visible = true;
            deleteButton.Visible = true;
            buttonUpdate.Visible = true;
            buttonSave.Visible = false;
            newPass.Visible = false;
            newPassLabel.Visible = false;

        }
    }
}
