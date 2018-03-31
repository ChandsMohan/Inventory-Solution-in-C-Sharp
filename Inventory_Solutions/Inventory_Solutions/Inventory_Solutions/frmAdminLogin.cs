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
    public partial class frmAdminLogin : Form
    {
        DBConnect con = new DBConnect();
        public static string AdminId;
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             string str = "select * from tbl_AdminLogin where AdminId='" + txtadminid.Text + "' and Password='" + txtpwd.Text + "'";
             try
             {
                 con.OpenConnection();
                 SqlCommand cmd = new SqlCommand(str, DBConnect.Connection);
                 SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.HasRows)
                 {
                     while (dr.Read())
                     {
                         frmMDIParent obj = new frmMDIParent();
                         obj.Show();
                         this.Hide();
                         AdminId = txtadminid.Text;
                         obj.label1.Text = "Welcome " +  AdminId;
                     }
                 }
                 else
                 {
                     lblerrorfull.Text = "Invalid Admin Id or Password \n Please Enter Correct Admin Id And Password";
                     lblerrorfull.ForeColor = Color.Red;
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

        private void txtadminid_Leave(object sender, EventArgs e)
        {

            if (txtadminid.Text.Trim().Length.Equals(0))
            {
                lblerroradminid.Visible = true;
                lblerroradminid.Text = "Please Enter Admin Id First";
                lblerroradminid.ForeColor = Color.Red;
                txtadminid.Focus();
            }
            else
            {
                lblerroradminid.Visible = false;
            }
        }

        private void txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text.Trim().Length.Equals(0))
            {
                lblerrorpwd.Visible = true;
                lblerrorpwd.Text = "Please Enter Password First";
                lblerrorpwd.ForeColor = Color.Red;
                txtpwd.Focus();
            }
            else
            {
                lblerrorpwd.Visible = false;
            }
        }

        private void frmAdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
    }
}
