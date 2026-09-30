namespace WinForms_Template
{
    partial class frmMain
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lvReceipt = new System.Windows.Forms.ListView();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(14, 12);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(386, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // lvReceipt
            // 
            this.lvReceipt.HideSelection = false;
            this.lvReceipt.Location = new System.Drawing.Point(16, 40);
            this.lvReceipt.Name = "lvReceipt";
            this.lvReceipt.Size = new System.Drawing.Size(461, 203);
            this.lvReceipt.TabIndex = 1;
            this.lvReceipt.UseCompatibleStateImageBehavior = false;
            // 
            // btnQuantity
            // 
            this.btnQuantity.Location = new System.Drawing.Point(402, 12);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnQuantity.TabIndex = 2;
            this.btnQuantity.Text = "Quantity";
            this.btnQuantity.UseVisualStyleBackColor = true;
            this.btnQuantity.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(489, 261);
            this.Controls.Add(this.btnQuantity);
            this.Controls.Add(this.lvReceipt);
            this.Controls.Add(this.txtProduct);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ListView lvReceipt;
        private System.Windows.Forms.Button btnQuantity;
    }
}

