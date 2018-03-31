namespace Inventory_Solutions
{
    partial class frmAdminLogin
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
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.lblerrorpwd = new System.Windows.Forms.Label();
            this.lblerroradminid = new System.Windows.Forms.Label();
            this.lblerrorfull = new System.Windows.Forms.Label();
            this.txtadminid = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminId.Location = new System.Drawing.Point(24, 23);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(67, 17);
            this.lblAdminId.TabIndex = 0;
            this.lblAdminId.Text = "Admin ID";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwd.Location = new System.Drawing.Point(25, 74);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(66, 17);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "Password";
            // 
            // lblerrorpwd
            // 
            this.lblerrorpwd.AutoSize = true;
            this.lblerrorpwd.Location = new System.Drawing.Point(132, 100);
            this.lblerrorpwd.Name = "lblerrorpwd";
            this.lblerrorpwd.Size = new System.Drawing.Size(0, 13);
            this.lblerrorpwd.TabIndex = 2;
            // 
            // lblerroradminid
            // 
            this.lblerroradminid.AutoSize = true;
            this.lblerroradminid.Location = new System.Drawing.Point(132, 48);
            this.lblerroradminid.Name = "lblerroradminid";
            this.lblerroradminid.Size = new System.Drawing.Size(0, 13);
            this.lblerroradminid.TabIndex = 3;
            // 
            // lblerrorfull
            // 
            this.lblerrorfull.AutoSize = true;
            this.lblerrorfull.Location = new System.Drawing.Point(132, 160);
            this.lblerrorfull.Name = "lblerrorfull";
            this.lblerrorfull.Size = new System.Drawing.Size(0, 13);
            this.lblerrorfull.TabIndex = 4;
            // 
            // txtadminid
            // 
            this.txtadminid.Location = new System.Drawing.Point(129, 23);
            this.txtadminid.Name = "txtadminid";
            this.txtadminid.Size = new System.Drawing.Size(118, 20);
            this.txtadminid.TabIndex = 5;
            this.txtadminid.Leave += new System.EventHandler(this.txtadminid_Leave);
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(129, 74);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(118, 20);
            this.txtpwd.TabIndex = 6;
            this.txtpwd.UseSystemPasswordChar = true;
            this.txtpwd.Leave += new System.EventHandler(this.txtpwd_Leave);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(129, 116);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 211);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtadminid);
            this.Controls.Add(this.lblerrorfull);
            this.Controls.Add(this.lblerroradminid);
            this.Controls.Add(this.lblerrorpwd);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblAdminId);
            this.Name = "frmAdminLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.Label lblerrorpwd;
        private System.Windows.Forms.Label lblerroradminid;
        private System.Windows.Forms.Label lblerrorfull;
        private System.Windows.Forms.TextBox txtadminid;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btnlogin;
    }
}