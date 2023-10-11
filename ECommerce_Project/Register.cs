using DBECommerce_Project.Entity;
using DBECommerce_Project.Operation;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            EUser user = new EUser();
            user.Username = emailBox.Text;
            user.FirstName = firstNameBox.Text;
            user.LastName = lastNameBox.Text;
            user.DOB = dobPick.Text;

            if (sellerBtn.Checked == false && customerBtn.Checked == false)
            {
                accountTypeLabel.Visible = true;
                return;
            }
            else
            {
                if (sellerBtn.Checked)
                {
                    user.AccountType = sellerBtn.Text;
                }
                else
                {
                    user.AccountType = customerBtn.Text;
                }
                accountTypeLabel.Visible = false;
            }
            if (user.FirstName.Length > 0)
            {

                firstNameCheckLabel.Visible = false;
                
            }
            else
            {
                firstNameCheckLabel.Visible = true;
                return;
            }
            if (user.LastName.Length >0 )
            {
                lastNameCheckLabel.Visible = false;
            }
            else
            {
                lastNameCheckLabel.Visible = true;
                return;
            }


            if (emailBox.Text.Length > 3)
            {
                bool pass = true;
                String temp = emailBox.Text;
                int size = temp.Length;
                if (temp[size - 1] != 'm')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 2] != 'o')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 3] != 'c')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 4] != '.')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 5] != 'l')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 6] != 'i')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 7] != 'a')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 8] != 'm')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 9] != 'g')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }
                if (temp[size - 10] != '@')
                {
                    emailCheckLabel.Visible = true;
                    pass = false;
                    return;
                }

                if (pass == true)
                    emailCheckLabel.Visible = false;
            }
            else
            { 
            emailCheckLabel.Visible = true;
            return;
            }

            if (newPassBox.Text.Length >= 4)
            {
                if (newPassBox.Text == matchPassBox.Text)
                {
                    user.Password = newPassBox.Text;
                    passConfirmLabel.Visible = false;
                }
                else
                {
                    passConfirmLabel.Visible = true;
                    return;
                }
            }
            else
            {
                passConfirmLabel.Visible = true;
                return;
            }


            OUser oUser = new OUser();
            int res = oUser.signup(user);
            if (res > 0)
            {
                MessageBox.Show("The Account Registered Successfully");
                this.Hide();
                new HomePage().Show();
            }
            else
            {
                MessageBox.Show("Unable to Register\nEmail already registered");
            }
        } 
    }
}
