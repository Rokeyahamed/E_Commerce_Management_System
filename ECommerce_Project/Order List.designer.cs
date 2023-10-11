
namespace ECommerce_Project
{
    partial class Order_List
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
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.orderListLebel = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(202, 24);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.Size = new System.Drawing.Size(621, 378);
            this.orderGridView.TabIndex = 0;
            // 
            // orderListLebel
            // 
            this.orderListLebel.AutoSize = true;
            this.orderListLebel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListLebel.Location = new System.Drawing.Point(57, 24);
            this.orderListLebel.Name = "orderListLebel";
            this.orderListLebel.Size = new System.Drawing.Size(127, 15);
            this.orderListLebel.TabIndex = 1;
            this.orderListLebel.Text = "Order List: ";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(60, 373);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(84, 29);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 430);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.orderListLebel);
            this.Controls.Add(this.orderGridView);
            this.Name = "Order_List";
            this.Text = "Order_List";
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Label orderListLebel;
        private System.Windows.Forms.Button showBtn;
    }
}