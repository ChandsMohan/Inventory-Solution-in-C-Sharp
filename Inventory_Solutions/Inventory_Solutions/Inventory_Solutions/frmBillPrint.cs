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
    public partial class frmBillPrint : Form
    {
        public frmBillPrint()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtcustomername.Text.Trim().Length.Equals(0))
            {
                lblerrorcustomername.Visible = true;
                lblerrorcustomername.Text = "Please Enter Customer Name";
                lblerrorcustomername.ForeColor = Color.Red;
                txtcustomername.Focus();
            }
            else
            {
                lblerrorcustomername.Visible = false;
            }
        }

        private void txtcustomerage_Leave(object sender, EventArgs e)
        {
            if (txtcustomerage.Text.Trim().Length.Equals(0))
            {
                lblerrorcustomerage.Visible = true;
                lblerrorcustomerage.Text = "Please Enter Customer Name";
                lblerrorcustomerage.ForeColor = Color.Red;
                txtcustomerage.Focus();
            }
            else
            {
                lblerrorcustomerage.Visible = false;
            }
        }

        private void txtcustomerage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && ((int)e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && ((int)e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtmobile_Leave(object sender, EventArgs e)
        {
            if (txtmobile.Text.Trim().Length.Equals(0))
            {
                lblerrormobile.Visible = true;
                lblerrormobile.Text = "Please Enter Mobile Number";
                lblerrormobile.ForeColor = Color.Red;
                txtmobile.Focus();
            }

            else if (txtmobile.Text.Trim().Length < 10)
            {
                lblerrormobile.Visible = true;
                lblerrormobile.Text = "Please Enter Correct Mobile Number";
                lblerrormobile.ForeColor = Color.Red;
                txtmobile.Focus();
            }
            else
            {
                lblerrormobile.Visible = false;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDialog pd1 = new PrintDialog();
            pd1.ShowDialog();
        }

        private void frmBillPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
