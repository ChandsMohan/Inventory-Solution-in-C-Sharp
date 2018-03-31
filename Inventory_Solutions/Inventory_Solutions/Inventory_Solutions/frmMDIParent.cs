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
    public partial class frmMDIParent : Form
    {
        public frmMDIParent()
        {
            InitializeComponent();
        }

        private bool CheckForDuplicationForm(Form NewForm)
        {
            bool b = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == NewForm.GetType())
                {
                    frm.Activate();
                    b = true;
                }
            }
            return b;
        }

        private void frmMDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmAdminLogin obj = new frmAdminLogin();
                obj.Show();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            frmAdminLogin obj = new frmAdminLogin();
            obj.Dispose();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To LogOut", "LogOut", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmAdminLogin obj = new frmAdminLogin();
                obj.Show();
                this.Dispose();
            }
            else
            {

            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct obj = new frmAddProduct();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewProduct obj = new frmViewProduct();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void purchaseProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseProduct obj = new frmPurchaseProduct();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void productRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductRecords obj = new frmProductRecords();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }
    }
}
