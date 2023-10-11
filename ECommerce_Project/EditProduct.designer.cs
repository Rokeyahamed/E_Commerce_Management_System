
namespace ECommerce_Project
{
    partial class editProductForm
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
            this.renameProductBox = new System.Windows.Forms.TextBox();
            this.renamePriceBox = new System.Windows.Forms.TextBox();
            this.renameProductLabel = new System.Windows.Forms.Label();
            this.renamePriceLabel = new System.Windows.Forms.Label();
            this.editProductButton = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.oldProductNameBox = new System.Windows.Forms.TextBox();
            this.oldPriceBox = new System.Windows.Forms.TextBox();
            this.oldStockStatusBox = new System.Windows.Forms.TextBox();
            this.editProductLabel = new System.Windows.Forms.Label();
            this.stockStatusLabel = new System.Windows.Forms.Label();
            this.newStockStatusBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // renameProductBox
            // 
            this.renameProductBox.Location = new System.Drawing.Point(426, 137);
            this.renameProductBox.Multiline = true;
            this.renameProductBox.Name = "renameProductBox";
            this.renameProductBox.Size = new System.Drawing.Size(164, 25);
            this.renameProductBox.TabIndex = 0;
            // 
            // renamePriceBox
            // 
            this.renamePriceBox.Location = new System.Drawing.Point(426, 199);
            this.renamePriceBox.Multiline = true;
            this.renamePriceBox.Name = "renamePriceBox";
            this.renamePriceBox.Size = new System.Drawing.Size(164, 25);
            this.renamePriceBox.TabIndex = 1;
            // 
            // renameProductLabel
            // 
            this.renameProductLabel.AutoSize = true;
            this.renameProductLabel.Location = new System.Drawing.Point(157, 140);
            this.renameProductLabel.Name = "renameProductLabel";
            this.renameProductLabel.Size = new System.Drawing.Size(99, 13);
            this.renameProductLabel.TabIndex = 2;
            this.renameProductLabel.Text = "Edit Product Name ";
            // 
            // renamePriceLabel
            // 
            this.renamePriceLabel.AutoSize = true;
            this.renamePriceLabel.Location = new System.Drawing.Point(157, 202);
            this.renamePriceLabel.Name = "renamePriceLabel";
            this.renamePriceLabel.Size = new System.Drawing.Size(52, 13);
            this.renamePriceLabel.TabIndex = 3;
            this.renamePriceLabel.Text = "Edit Price";
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(358, 328);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(130, 39);
            this.editProductButton.TabIndex = 4;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(612, 373);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(95, 39);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // oldProductNameBox
            // 
            this.oldProductNameBox.Location = new System.Drawing.Point(270, 140);
            this.oldProductNameBox.Name = "oldProductNameBox";
            this.oldProductNameBox.Size = new System.Drawing.Size(128, 20);
            this.oldProductNameBox.TabIndex = 6;
            // 
            // oldPriceBox
            // 
            this.oldPriceBox.Location = new System.Drawing.Point(270, 202);
            this.oldPriceBox.Name = "oldPriceBox";
            this.oldPriceBox.Size = new System.Drawing.Size(128, 20);
            this.oldPriceBox.TabIndex = 7;
            // 
            // oldStockStatusBox
            // 
            this.oldStockStatusBox.Location = new System.Drawing.Point(270, 259);
            this.oldStockStatusBox.Name = "oldStockStatusBox";
            this.oldStockStatusBox.Size = new System.Drawing.Size(128, 20);
            this.oldStockStatusBox.TabIndex = 8;
            // 
            // editProductLabel
            // 
            this.editProductLabel.AutoSize = true;
            this.editProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductLabel.Location = new System.Drawing.Point(309, 30);
            this.editProductLabel.Name = "editProductLabel";
            this.editProductLabel.Size = new System.Drawing.Size(179, 36);
            this.editProductLabel.TabIndex = 9;
            this.editProductLabel.Text = "Edit Product";
            // 
            // stockStatusLabel
            // 
            this.stockStatusLabel.AutoSize = true;
            this.stockStatusLabel.Location = new System.Drawing.Point(157, 266);
            this.stockStatusLabel.Name = "stockStatusLabel";
            this.stockStatusLabel.Size = new System.Drawing.Size(71, 13);
            this.stockStatusLabel.TabIndex = 10;
            this.stockStatusLabel.Text = " Stock Status";
            // 
            // newStockStatusBox
            // 
            this.newStockStatusBox.Location = new System.Drawing.Point(426, 254);
            this.newStockStatusBox.Multiline = true;
            this.newStockStatusBox.Name = "newStockStatusBox";
            this.newStockStatusBox.Size = new System.Drawing.Size(164, 25);
            this.newStockStatusBox.TabIndex = 11;
            // 
            // editProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.newStockStatusBox);
            this.Controls.Add(this.stockStatusLabel);
            this.Controls.Add(this.editProductLabel);
            this.Controls.Add(this.oldStockStatusBox);
            this.Controls.Add(this.oldPriceBox);
            this.Controls.Add(this.oldProductNameBox);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.renamePriceLabel);
            this.Controls.Add(this.renameProductLabel);
            this.Controls.Add(this.renamePriceBox);
            this.Controls.Add(this.renameProductBox);
            this.Name = "editProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox renameProductBox;
        private System.Windows.Forms.TextBox renamePriceBox;
        private System.Windows.Forms.Label renameProductLabel;
        private System.Windows.Forms.Label renamePriceLabel;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.TextBox oldProductNameBox;
        private System.Windows.Forms.TextBox oldPriceBox;
        private System.Windows.Forms.TextBox oldStockStatusBox;
        private System.Windows.Forms.Label editProductLabel;
        private System.Windows.Forms.Label stockStatusLabel;
        private System.Windows.Forms.TextBox newStockStatusBox;
    }
}