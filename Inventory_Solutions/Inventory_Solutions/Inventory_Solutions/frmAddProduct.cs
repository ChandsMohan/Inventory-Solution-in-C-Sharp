using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Solutions
{
    public partial class frmAddProduct : Form
    {
        DBConnect con = new DBConnect();
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void txtproductid_Leave(object sender, EventArgs e)
        {
            if (txtproductid.Text.Trim().Length.Equals(0))
            {
                lblerrorproduct_id.Visible = true;
                lblerrorproduct_id.Text = "Please Enter Product ID";
                lblerrorproduct_id.ForeColor = Color.Red;
                txtproductid.Focus();
            }
            else
            {
                lblerrorproduct_id.Visible = false;
            }
        }

        private void txtproductname_Leave(object sender, EventArgs e)
        {
            if (txtproductname.Text.Trim().Length.Equals(0))
            {
                lblerrorproductname.Visible = true;
                lblerrorproductname.Text = "Please Enter Product Name";
                lblerrorproductname.ForeColor = Color.Red;
                txtproductname.Focus();
            }
            else
            {
                lblerrorproductname.Visible = false;
            }
        }

        private void txtprice_Leave(object sender, EventArgs e)
        {
            if (txtprice.Text.Trim().Length.Equals(0))
            {
                lblerrorprice.Visible = true;
                lblerrorprice.Text = "Please Enter Price";
                lblerrorprice.ForeColor = Color.Red;
                txtprice.Focus();
            }
            else
            {
                lblerrorprice.Visible = false;
            }
        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {
            if (txtquantity.Text.Trim().Length.Equals(0))
            {
                lblerrorquantity.Visible = true;
                lblerrorquantity.Text = "Please Enter Quantity First";
                lblerrorquantity.ForeColor = Color.Red;
                txtquantity.Focus();
            }
            else
            {
                lblerrorquantity.Visible = false;
            }
        }

        private void frmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            string str = "insert into tbl_ProductRecords (Product_Id,Product_Name,Price,Quantity) values ('" + txtproductid.Text + "','" + txtproductname.Text + "','" + txtprice.Text + "','" + txtquantity.Text + "')";
            try
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand(str, DBConnect.Connection);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Data Successfully Added");
                    txtproductid.Clear();
                    txtproductname.Clear();
                    txtprice.Clear();
                    txtquantity.Clear();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtproductid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
