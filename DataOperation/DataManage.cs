using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataOperation
{
    class DataManage
    {
        string connectstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Important File\Programs\Visual Studio\DataOperation\DataOperation\Database.mdf;Integrated Security=True";

        public DataTable GetDataTable(string query)
        {
            SqlConnection con = new SqlConnection(connectstr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public int Execute(string query)
        {
            SqlConnection con = new SqlConnection(connectstr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
