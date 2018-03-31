using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace Inventory_Solutions
{
    class DBConnect
    {
        public static SqlConnection Connection;

        public bool OpenConnection()
        {
            string StrCn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string str_cn_new = StrCn;
            Connection = new SqlConnection(str_cn_new);
            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
