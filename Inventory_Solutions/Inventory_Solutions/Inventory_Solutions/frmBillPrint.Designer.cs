namespace Inventory_Solutions
{
    partial class frmBillPrint
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblerrorcustomername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcustomerage = new System.Windows.Forms.TextBox();
            this.lblerrorcustomerage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.lblerrormobile = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblproductid = new System.Windows.Forms.Label();
            this.lblproductquantity = new System.Windows.Forms.Label();
            this.lbltotalcost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.lblnote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Code Solutions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(70, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name:";
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(238, 86);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(169, 20);
            this.txtcustomername.TabIndex = 5;
            this.txtcustomername.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(70, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(70, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Quantity:";
            // 
            // lblerrorcustomername
            // 
            this.lblerrorcustomername.AutoSize = true;
            this.lblerrorcustomername.Location = new System.Drawing.Point(248, 113);
            this.lblerrorcustomername.Name = "lblerrorcustomername";
            this.lblerrorcustomername.Size = new System.Drawing.Size(0, 13);
            this.lblerrorcustomername.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(70, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Age:";
            // 
            // txtcustomerage
            // 
            this.txtcustomerage.Location = new System.Drawing.Point(238, 129);
            this.txtcustomerage.Name = "txtcustomerage";
            this.txtcustomerage.Size = new System.Drawing.Size(169, 20);
            this.txtcustomerage.TabIndex = 10;
            this.txtcustomerage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustomerage_KeyPress);
            this.txtcustomerage.Leave += new System.EventHandler(this.txtcustomerage_Leave);
            // 
            // lblerrorcustomerage
            // 
            this.lblerrorcustomerage.AutoSize = true;
            this.lblerrorcustomerage.Location = new System.Drawing.Point(248, 155);
            this.lblerrorcustomerage.Name = "lblerrorcustomerage";
            this.lblerrorcustomerage.Size = new System.Drawing.Size(0, 13);
            this.lblerrorcustomerage.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(70, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mobile:";
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(238, 169);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(169, 20);
            this.txtmobile.TabIndex = 13;
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            this.txtmobile.Leave += new System.EventHandler(this.txtmobile_Leave);
            // 
            // lblerrormobile
            // 
            this.lblerrormobile.AutoSize = true;
            this.lblerrormobile.Location = new System.Drawing.Point(248, 202);
            this.lblerrormobile.Name = "lblerrormobile";
            this.lblerrormobile.Size = new System.Drawing.Size(0, 13);
            this.lblerrormobile.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(70, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Cost:";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.ForeColor = System.Drawing.Color.DimGray;
            this.lblproductname.Location = new System.Drawing.Point(235, 243);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(93, 13);
            this.lblproductname.TabIndex = 16;
            this.lblproductname.Text = "lblproductname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(70, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Product Serial No:";
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.ForeColor = System.Drawing.Color.DimGray;
            this.lblproductid.Location = new System.Drawing.Point(235, 216);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(73, 13);
            this.lblproductid.TabIndex = 18;
            this.lblproductid.Text = "lblproductid";
            // 
            // lblproductquantity
            // 
            this.lblproductquantity.AutoSize = true;
            this.lblproductquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductquantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblproductquantity.Location = new System.Drawing.Point(235, 276);
            this.lblproductquantity.Name = "lblproductquantity";
            this.lblproductquantity.Size = new System.Drawing.Size(108, 13);
            this.lblproductquantity.TabIndex = 19;
            this.lblproductquantity.Text = "lblproductquantity";
            // 
            // lbltotalcost
            // 
            this.lbltotalcost.AutoSize = true;
            this.lbltotalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalcost.ForeColor = System.Drawing.Color.DimGray;
            this.lbltotalcost.Location = new System.Drawing.Point(235, 305);
            this.lbltotalcost.Name = "lbltotalcost";
            this.lbltotalcost.Size = new System.Drawing.Size(69, 13);
            this.lbltotalcost.TabIndex = 20;
            this.lbltotalcost.Text = "lbltotalcost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Authorised Signatory";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Customer\'s Signature";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "- - - - - - - - - - - - - - - - - - - - - -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(369, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "- - - - - - - - - - - - - - - - - - - - - -";
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(73, 412);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 25;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.Location = new System.Drawing.Point(23, 460);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(386, 21);
            this.lblnote.TabIndex = 26;
            this.lblnote.Text = "Note: Warranty product can be replaced but not return back";
            // 
            // frmBillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 490);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbltotalcost);
            this.Controls.Add(this.lblproductquantity);
            this.Controls.Add(this.lblproductid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblerrormobile);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblerrorcustomerage);
            this.Controls.Add(this.txtcustomerage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblerrorcustomername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBillPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Print";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBillPrint_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblerrorcustomername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcustomerage;
        private System.Windows.Forms.Label lblerrorcustomerage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label lblerrormobile;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblproductid;
        public System.Windows.Forms.Label lblproductquantity;
        public System.Windows.Forms.Label lbltotalcost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lblnote;
    }
}