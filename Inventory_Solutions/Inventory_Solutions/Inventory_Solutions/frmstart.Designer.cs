namespace Inventory_Solutions
{
    partial class frmstart
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
            this.lblintorycode = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblintorycode
            // 
            this.lblintorycode.AutoSize = true;
            this.lblintorycode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintorycode.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblintorycode.Location = new System.Drawing.Point(6, 9);
            this.lblintorycode.MaximumSize = new System.Drawing.Size(390, 40);
            this.lblintorycode.MinimumSize = new System.Drawing.Size(390, 40);
            this.lblintorycode.Name = "lblintorycode";
            this.lblintorycode.Size = new System.Drawing.Size(390, 40);
            this.lblintorycode.TabIndex = 1;
            this.lblintorycode.Text = "Inventory Code";
            this.lblintorycode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 104);
            this.progressBar1.MarqueeAnimationSpeed = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            // 
            // frmstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 231);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblintorycode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmstart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Screen";
            this.Load += new System.EventHandler(this.frmstart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblintorycode;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

