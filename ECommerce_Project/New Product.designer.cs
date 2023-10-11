
namespace ECommerce_Project
{
    partial class newProductForm
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
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productIdBox = new System.Windows.Forms.TextBox();
            this.productPriceBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.newProductLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(139, 127);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(58, 13);
            this.productIdLabel.TabIndex = 0;
            this.productIdLabel.Text = "Product ID";
            // 
            // productIdBox
            // 
            this.productIdBox.Location = new System.Drawing.Point(322, 124);
            this.productIdBox.Multiline = true;
            this.productIdBox.Name = "productIdBox";
            this.productIdBox.Size = new System.Drawing.Size(237, 27);
            this.productIdBox.TabIndex = 1;
            // 
            // productPriceBox
            // 
            this.productPriceBox.Location = new System.Drawing.Point(322, 232);
            this.productPriceBox.Multiline = true;
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(237, 28);
            this.productPriceBox.TabIndex = 3;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(322, 285);
            this.stockBox.Multiline = true;
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(237, 26);
            this.stockBox.TabIndex = 4;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(139, 183);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(75, 13);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Text = "Product Name";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(139, 235);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(71, 13);
            this.productPriceLabel.TabIndex = 6;
            this.productPriceLabel.Text = "Product Price";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(139, 288);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(35, 13);
            this.stockLabel.TabIndex = 7;
            this.stockLabel.Text = "Stock";
            // 
            // newProductLabel
            // 
            this.newProductLabel.AutoSize = true;
            this.newProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductLabel.Location = new System.Drawing.Point(337, 22);
            this.newProductLabel.Name = "newProductLabel";
            this.newProductLabel.Size = new System.Drawing.Size(187, 36);
            this.newProductLabel.TabIndex = 8;
            this.newProductLabel.Text = "New Product";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(675, 400);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(97, 39);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(355, 366);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(169, 38);
            this.addProductBtn.TabIndex = 11;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(322, 180);
            this.productNameBox.Multiline = true;
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(237, 28);
            this.productNameBox.TabIndex = 12;
            // 
            // newProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.newProductLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.productPriceBox);
            this.Controls.Add(this.productIdBox);
            this.Controls.Add(this.productIdLabel);
            this.Name = "newProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.TextBox productIdBox;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label newProductLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.TextBox productNameBox;
    }
}