namespace Inventory_Solutions
{
    partial class frmPurchaseProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblerrorproductid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblerrortotalcost = new System.Windows.Forms.Label();
            this.lblerrorpurchasequantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txttotalcost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpurchasequantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblerrorproductid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btncheck);
            this.groupBox1.Controls.Add(this.txtproductid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter product ID";
            // 
            // lblerrorproductid
            // 
            this.lblerrorproductid.AutoSize = true;
            this.lblerrorproductid.Location = new System.Drawing.Point(156, 58);
            this.lblerrorproductid.Name = "lblerrorproductid";
            this.lblerrorproductid.Size = new System.Drawing.Size(0, 16);
            this.lblerrorproductid.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID";
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(369, 33);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(79, 24);
            this.btncheck.TabIndex = 6;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(150, 33);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(170, 22);
            this.txtproductid.TabIndex = 5;
            this.txtproductid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductid_KeyPress);
            this.txtproductid.Leave += new System.EventHandler(this.txtproductid_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtquantity);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtproductname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 191);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(150, 148);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(170, 22);
            this.txtquantity.TabIndex = 8;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(150, 98);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(170, 22);
            this.txtprice.TabIndex = 7;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(150, 42);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(170, 22);
            this.txtproductname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblerrortotalcost);
            this.groupBox3.Controls.Add(this.lblerrorpurchasequantity);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txttotalcost);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtpurchasequantity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(528, 172);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Purchase Quantity";
            // 
            // lblerrortotalcost
            // 
            this.lblerrortotalcost.AutoSize = true;
            this.lblerrortotalcost.Location = new System.Drawing.Point(159, 117);
            this.lblerrortotalcost.Name = "lblerrortotalcost";
            this.lblerrortotalcost.Size = new System.Drawing.Size(0, 16);
            this.lblerrortotalcost.TabIndex = 14;
            // 
            // lblerrorpurchasequantity
            // 
            this.lblerrorpurchasequantity.AutoSize = true;
            this.lblerrorpurchasequantity.Location = new System.Drawing.Point(156, 58);
            this.lblerrorpurchasequantity.Name = "lblerrorpurchasequantity";
            this.lblerrorpurchasequantity.Size = new System.Drawing.Size(0, 16);
            this.lblerrorpurchasequantity.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotalcost
            // 
            this.txttotalcost.Location = new System.Drawing.Point(150, 90);
            this.txttotalcost.Name = "txttotalcost";
            this.txttotalcost.Size = new System.Drawing.Size(170, 22);
            this.txttotalcost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Cost";
            // 
            // txtpurchasequantity
            // 
            this.txtpurchasequantity.Location = new System.Drawing.Point(150, 33);
            this.txtpurchasequantity.Name = "txtpurchasequantity";
            this.txtpurchasequantity.Size = new System.Drawing.Size(170, 22);
            this.txtpurchasequantity.TabIndex = 9;
            this.txtpurchasequantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpurchasequantity_KeyPress);
            this.txtpurchasequantity.Leave += new System.EventHandler(this.txtpurchasequantity_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Purchase Quantity";
            // 
            // frmPurchaseProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPurchaseProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPurchaseProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmPurchaseProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblerrorproductid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotalcost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpurchasequantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblerrortotalcost;
        private System.Windows.Forms.Label lblerrorpurchasequantity;
    }
}