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
    public partial class frmViewProduct : Form
    {
        DBConnect con = new DBConnect();
        public frmViewProduct()
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
                        txtproductname.Text = dr.GetValue(1).ToString();
                        txtprice.Text = dr.GetValue(2).ToString();
                        txtquantity.Text = dr.GetValue(3).ToString();
                        txtproductid.ReadOnly = true;
                    }
                }
                else
                {
                    lblerrorproductid.Visible = true;
                    lblerrorproductid.Text = "Record Not Found,\nPlease Enter Corrct Product ID";
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

        private void frmViewProduct_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmViewProduct_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}
