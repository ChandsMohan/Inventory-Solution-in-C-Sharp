using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Solutions
{
    public partial class frmstart : Form
    {
        Timer timer1 = new Timer();
        public frmstart()
        {
            InitializeComponent();
        }

        private void frmstart_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
            timer1.Enabled = false;
            frmAdminLogin obj = new frmAdminLogin();
            this.Visible = false;
            obj.Show();

        }
    }
}
