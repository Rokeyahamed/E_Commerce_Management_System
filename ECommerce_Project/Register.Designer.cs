
namespace ECommerce_Project
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newPassLabel = new System.Windows.Forms.Label();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.matchPassBox = new System.Windows.Forms.TextBox();
            this.dobPick = new System.Windows.Forms.DateTimePicker();
            this.accType = new System.Windows.Forms.Label();
            this.sellerBtn = new System.Windows.Forms.RadioButton();
            this.customerBtn = new System.Windows.Forms.RadioButton();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.emailCheckLabel = new System.Windows.Forms.Label();
            this.passCheckLabel = new System.Windows.Forms.Label();
            this.passConfirmLabel = new System.Windows.Forms.Label();
            this.firstNameCheckLabel = new System.Windows.Forms.Label();
            this.lastNameCheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Location = new System.Drawing.Point(206, 258);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(78, 13);
            this.newPassLabel.TabIndex = 1;
            this.newPassLabel.Text = "New Passowrd";
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.Location = new System.Drawing.Point(206, 297);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPassLabel.TabIndex = 2;
            this.confirmPassLabel.Text = "Confirm Password";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(206, 176);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(66, 13);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "Date of Birth";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(206, 217);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(206, 134);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(397, 137);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(339, 353);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(92, 33);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(283, 134);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 8;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(461, 131);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 9;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(303, 214);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(200, 20);
            this.emailBox.TabIndex = 10;
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(303, 255);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.PasswordChar = '*';
            this.newPassBox.Size = new System.Drawing.Size(152, 20);
            this.newPassBox.TabIndex = 11;
            // 
            // matchPassBox
            // 
            this.matchPassBox.Location = new System.Drawing.Point(303, 294);
            this.matchPassBox.Name = "matchPassBox";
            this.matchPassBox.PasswordChar = '*';
            this.matchPassBox.Size = new System.Drawing.Size(152, 20);
            this.matchPassBox.TabIndex = 12;
            // 
            // dobPick
            // 
            this.dobPick.Location = new System.Drawing.Point(303, 176);
            this.dobPick.Name = "dobPick";
            this.dobPick.Size = new System.Drawing.Size(200, 20);
            this.dobPick.TabIndex = 13;
            // 
            // accType
            // 
            this.accType.AutoSize = true;
            this.accType.Location = new System.Drawing.Point(198, 84);
            this.accType.Name = "accType";
            this.accType.Size = new System.Drawing.Size(74, 13);
            this.accType.TabIndex = 15;
            this.accType.Text = "Account Type";
            // 
            // sellerBtn
            // 
            this.sellerBtn.AutoSize = true;
            this.sellerBtn.Location = new System.Drawing.Point(283, 80);
            this.sellerBtn.Name = "sellerBtn";
            this.sellerBtn.Size = new System.Drawing.Size(51, 17);
            this.sellerBtn.TabIndex = 16;
            this.sellerBtn.TabStop = true;
            this.sellerBtn.Text = "Seller";
            this.sellerBtn.UseVisualStyleBackColor = true;
            // 
            // customerBtn
            // 
            this.customerBtn.AutoSize = true;
            this.customerBtn.Location = new System.Drawing.Point(349, 80);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(69, 17);
            this.customerBtn.TabIndex = 17;
            this.customerBtn.TabStop = true;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.accountTypeLabel.Location = new System.Drawing.Point(283, 104);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(144, 13);
            this.accountTypeLabel.TabIndex = 18;
            this.accountTypeLabel.Text = "*Please select Account Type";
            this.accountTypeLabel.Visible = false;
            // 
            // emailCheckLabel
            // 
            this.emailCheckLabel.AutoSize = true;
            this.emailCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.emailCheckLabel.Location = new System.Drawing.Point(301, 237);
            this.emailCheckLabel.Name = "emailCheckLabel";
            this.emailCheckLabel.Size = new System.Drawing.Size(96, 13);
            this.emailCheckLabel.TabIndex = 19;
            this.emailCheckLabel.Text = "*enter a valid email";
            this.emailCheckLabel.Visible = false;
            // 
            // passCheckLabel
            // 
            this.passCheckLabel.AutoSize = true;
            this.passCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.passCheckLabel.Location = new System.Drawing.Point(300, 278);
            this.passCheckLabel.Name = "passCheckLabel";
            this.passCheckLabel.Size = new System.Drawing.Size(117, 13);
            this.passCheckLabel.TabIndex = 20;
            this.passCheckLabel.Text = "*enter a valid password";
            this.passCheckLabel.Visible = false;
            // 
            // passConfirmLabel
            // 
            this.passConfirmLabel.AutoSize = true;
            this.passConfirmLabel.ForeColor = System.Drawing.Color.Red;
            this.passConfirmLabel.Location = new System.Drawing.Point(301, 317);
            this.passConfirmLabel.Name = "passConfirmLabel";
            this.passConfirmLabel.Size = new System.Drawing.Size(179, 13);
            this.passConfirmLabel.TabIndex = 21;
            this.passConfirmLabel.Text = "*password didnt match with previous";
            this.passConfirmLabel.Visible = false;
            // 
            // firstNameCheckLabel
            // 
            this.firstNameCheckLabel.AutoSize = true;
            this.firstNameCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameCheckLabel.Location = new System.Drawing.Point(281, 157);
            this.firstNameCheckLabel.Name = "firstNameCheckLabel";
            this.firstNameCheckLabel.Size = new System.Drawing.Size(102, 13);
            this.firstNameCheckLabel.TabIndex = 22;
            this.firstNameCheckLabel.Text = "*First Name required";
            this.firstNameCheckLabel.Visible = false;
            // 
            // lastNameCheckLabel
            // 
            this.lastNameCheckLabel.AutoSize = true;
            this.lastNameCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameCheckLabel.Location = new System.Drawing.Point(458, 154);
            this.lastNameCheckLabel.Name = "lastNameCheckLabel";
            this.lastNameCheckLabel.Size = new System.Drawing.Size(103, 13);
            this.lastNameCheckLabel.TabIndex = 23;
            this.lastNameCheckLabel.Text = "*Last Name required";
            this.lastNameCheckLabel.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 494);
            this.Controls.Add(this.lastNameCheckLabel);
            this.Controls.Add(this.firstNameCheckLabel);
            this.Controls.Add(this.passConfirmLabel);
            this.Controls.Add(this.passCheckLabel);
            this.Controls.Add(this.emailCheckLabel);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.sellerBtn);
            this.Controls.Add(this.accType);
            this.Controls.Add(this.dobPick);
            this.Controls.Add(this.matchPassBox);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.newPassLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.TextBox matchPassBox;
        private System.Windows.Forms.DateTimePicker dobPick;
        private System.Windows.Forms.Label accType;
        private System.Windows.Forms.RadioButton sellerBtn;
        private System.Windows.Forms.RadioButton customerBtn;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label emailCheckLabel;
        private System.Windows.Forms.Label passCheckLabel;
        private System.Windows.Forms.Label passConfirmLabel;
        private System.Windows.Forms.Label firstNameCheckLabel;
        private System.Windows.Forms.Label lastNameCheckLabel;
    }
}