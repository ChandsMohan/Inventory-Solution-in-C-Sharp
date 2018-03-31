using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Solutions
{
    public partial class frmPurchaseProduct : Form
    {
        DBConnect con = new DBConnect();
        public frmPurchaseProduct()
        {
            InitializeComponent();
        }

        private void txtproductid_Leave(object sender, EventArgs e)
        {
            if (txtproductid.Text.Trim().Length.Equals(0))
                {
                    lblerrorproductid.Visible = true;
                    lblerrorproductid.Text = "Please Enter Product ID";
                    lblerrorproductid.ForeColor = Color.Red;
                    txtproductid.Focus();
                }
                else
                {
                    lblerrorproductid.Visible = false;
                }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            string str = "select * from tbl_ProductRecords where Product_Id=" + txtproductid.Text + "";
            try
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand(str, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        groupBox2.Visible = true;
                        groupBox3.Visible = true;
                        txtproductname.Text = dr.GetValue(1).ToString();
                        txtprice.Text = dr.GetValue(2).ToString();
                        txtquantity.Text = dr.GetValue(3).ToString();
                        txtproductid.ReadOnly = true;
                        txtproductname.ReadOnly = true;
                        txtprice.ReadOnly = true;
                        txtquantity.ReadOnly = true;
                    }
                }
                else
                {
                    lblerrorproductid.Visible = true;
                    lblerrorproductid.Text = "Record Not Found,\n Please Enter Corrct Product ID";
                    lblerrorproductid.ForeColor = Color.Red;
                    txtproductid.Focus();
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

        private void txtpurchasequantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpurchasequantity_Leave(object sender, EventArgs e)
        {
            if (txtpurchasequantity.Text.Trim().Length.Equals(0))
            {
                lblerrorpurchasequantity.Visible = true;
                lblerrorpurchasequantity.Text = "Please Enter Quantity You Want to Purchase";
                lblerrorpurchasequantity.ForeColor = Color.Red;
                txtpurchasequantity.Focus();
            }
            else if (Convert.ToInt32(txtpurchasequantity.Text) > (Convert.ToInt32(txtquantity.Text)))
            {
                lblerrorpurchasequantity.Visible = true;
                lblerrorpurchasequantity.Text = "Purchase Quantity Must Be Less Than of Product Quantity";
                lblerrorpurchasequantity.ForeColor = Color.Red;
                txtpurchasequantity.Focus();
            }
            else
            {
                lblerrorpurchasequantity.Visible = false;
                txttotalcost.Text = (Int32.Parse(txtpurchasequantity.Text) * double.Parse(txtprice.Text)).ToString();
                txttotalcost.ReadOnly = true;
                //txtpurchasequantity.ReadOnly = true;
            }
        }

        private void frmPurchaseProduct_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "update tbl_ProductRecords set Quantity=" + (Int32.Parse(txtquantity.Text) - Int32.Parse(txtpurchasequantity.Text)) + " where Product_Id=" + txtproductid.Text + "";
            try
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand(str, DBConnect.Connection);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    frmBillPrint obj = new frmBillPrint();
                    obj.lblproductid.Text = txtproductid.Text;
                    obj.lblproductname.Text = txtproductname.Text;
                    obj.lblproductquantity.Text = txtpurchasequantity.Text;
                    obj.lbltotalcost.Text = txttotalcost.Text;
                    obj.Show();
                    this.Hide();
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

        private void frmPurchaseProduct_FormClosing(object sender, FormClosingEventArgs e)
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
