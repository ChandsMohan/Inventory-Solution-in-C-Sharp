namespace Inventory_Solutions
{
    partial class frmAddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblerrorproduct_id = new System.Windows.Forms.Label();
            this.lblerrorproductname = new System.Windows.Forms.Label();
            this.lblerrorprice = new System.Windows.Forms.Label();
            this.lblerrorquantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(166, 28);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(170, 20);
            this.txtproductid.TabIndex = 4;
            this.txtproductid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductid_KeyPress);
            this.txtproductid.Leave += new System.EventHandler(this.txtproductid_Leave);
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(166, 75);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(170, 20);
            this.txtproductname.TabIndex = 5;
            this.txtproductname.Leave += new System.EventHandler(this.txtproductname_Leave);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(166, 124);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(170, 20);
            this.txtprice.TabIndex = 6;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            this.txtprice.Leave += new System.EventHandler(this.txtprice_Leave);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(166, 168);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(170, 20);
            this.txtquantity.TabIndex = 7;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            this.txtquantity.Leave += new System.EventHandler(this.txtquantity_Leave);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(166, 222);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblerrorproduct_id
            // 
            this.lblerrorproduct_id.AutoSize = true;
            this.lblerrorproduct_id.Location = new System.Drawing.Point(170, 51);
            this.lblerrorproduct_id.Name = "lblerrorproduct_id";
            this.lblerrorproduct_id.Size = new System.Drawing.Size(0, 13);
            this.lblerrorproduct_id.TabIndex = 9;
            // 
            // lblerrorproductname
            // 
            this.lblerrorproductname.AutoSize = true;
            this.lblerrorproductname.Location = new System.Drawing.Point(170, 98);
            this.lblerrorproductname.Name = "lblerrorproductname";
            this.lblerrorproductname.Size = new System.Drawing.Size(0, 13);
            this.lblerrorproductname.TabIndex = 10;
            // 
            // lblerrorprice
            // 
            this.lblerrorprice.AutoSize = true;
            this.lblerrorprice.Location = new System.Drawing.Point(170, 152);
            this.lblerrorprice.Name = "lblerrorprice";
            this.lblerrorprice.Size = new System.Drawing.Size(0, 13);
            this.lblerrorprice.TabIndex = 11;
            // 
            // lblerrorquantity
            // 
            this.lblerrorquantity.AutoSize = true;
            this.lblerrorquantity.Location = new System.Drawing.Point(163, 191);
            this.lblerrorquantity.Name = "lblerrorquantity";
            this.lblerrorquantity.Size = new System.Drawing.Size(0, 13);
            this.lblerrorquantity.TabIndex = 12;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 313);
            this.Controls.Add(this.lblerrorquantity);
            this.Controls.Add(this.lblerrorprice);
            this.Controls.Add(this.lblerrorproductname);
            this.Controls.Add(this.lblerrorproduct_id);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProduct_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblerrorproduct_id;
        private System.Windows.Forms.Label lblerrorproductname;
        private System.Windows.Forms.Label lblerrorprice;
        private System.Windows.Forms.Label lblerrorquantity;
    }
}