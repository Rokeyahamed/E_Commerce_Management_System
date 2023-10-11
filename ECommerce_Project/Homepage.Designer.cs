
namespace ECommerce_Project
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.forgotPassClick = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.checkedRemember = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowLog = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdvance = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.RadioButton();
            this.userBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(561, 207);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(172, 23);
            this.passwordBox.TabIndex = 0;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(561, 139);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(172, 23);
            this.usernameBox.TabIndex = 1;
            // 
            // forgotPassClick
            // 
            this.forgotPassClick.AutoSize = true;
            this.forgotPassClick.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassClick.Location = new System.Drawing.Point(739, 219);
            this.forgotPassClick.Name = "forgotPassClick";
            this.forgotPassClick.Size = new System.Drawing.Size(86, 13);
            this.forgotPassClick.TabIndex = 2;
            this.forgotPassClick.TabStop = true;
            this.forgotPassClick.Text = "Forgot Password";
            // 
            // loginButton
            // 
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(568, 316);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(157, 41);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.LinkColor = System.Drawing.Color.Black;
            this.registerLabel.Location = new System.Drawing.Point(573, 411);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(162, 25);
            this.registerLabel.TabIndex = 4;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Create Account";
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameLabel.Location = new System.Drawing.Point(565, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 17);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordLabel.Location = new System.Drawing.Point(565, 187);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // checkedRemember
            // 
            this.checkedRemember.AutoSize = true;
            this.checkedRemember.BackColor = System.Drawing.Color.Transparent;
            this.checkedRemember.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedRemember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkedRemember.Location = new System.Drawing.Point(561, 236);
            this.checkedRemember.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkedRemember.Name = "checkedRemember";
            this.checkedRemember.Size = new System.Drawing.Size(102, 17);
            this.checkedRemember.TabIndex = 9;
            this.checkedRemember.Text = "Remember Me";
            this.checkedRemember.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(640, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "OR";
            // 
            // buttonShowLog
            // 
            this.buttonShowLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowLog.Location = new System.Drawing.Point(66, 425);
            this.buttonShowLog.Name = "buttonShowLog";
            this.buttonShowLog.Size = new System.Drawing.Size(100, 35);
            this.buttonShowLog.TabIndex = 12;
            this.buttonShowLog.Text = "Show Log";
            this.buttonShowLog.UseVisualStyleBackColor = true;
            this.buttonShowLog.Visible = false;
            this.buttonShowLog.Click += new System.EventHandler(this.buttonShowLog_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(28, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(436, 306);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.Visible = false;
            // 
            // buttonAdvance
            // 
            this.buttonAdvance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdvance.Location = new System.Drawing.Point(204, 425);
            this.buttonAdvance.Name = "buttonAdvance";
            this.buttonAdvance.Size = new System.Drawing.Size(166, 35);
            this.buttonAdvance.TabIndex = 14;
            this.buttonAdvance.Text = "Advanced Options";
            this.buttonAdvance.UseVisualStyleBackColor = true;
            this.buttonAdvance.Visible = false;
            this.buttonAdvance.Click += new System.EventHandler(this.buttonAdvance_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.AutoSize = true;
            this.adminBtn.BackColor = System.Drawing.Color.Transparent;
            this.adminBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminBtn.Location = new System.Drawing.Point(28, 30);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(70, 21);
            this.adminBtn.TabIndex = 15;
            this.adminBtn.TabStop = true;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.CheckedChanged += new System.EventHandler(this.adminBtn_CheckedChanged);
            // 
            // userBtn
            // 
            this.userBtn.AutoSize = true;
            this.userBtn.BackColor = System.Drawing.Color.Transparent;
            this.userBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userBtn.Location = new System.Drawing.Point(104, 30);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(60, 21);
            this.userBtn.TabIndex = 16;
            this.userBtn.TabStop = true;
            this.userBtn.Text = "User";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.CheckedChanged += new System.EventHandler(this.userBtn_CheckedChanged);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 517);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.buttonAdvance);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonShowLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedRemember);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.forgotPassClick);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.LinkLabel forgotPassClick;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel registerLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox checkedRemember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowLog;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdvance;
        private System.Windows.Forms.RadioButton adminBtn;
        private System.Windows.Forms.RadioButton userBtn;
    }
}

