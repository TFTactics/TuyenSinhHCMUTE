using System.Data.SqlClient;
using System.Data;

namespace UI.BD_Layer
{
    internal class DBMain
    {
        //public string ConnStr = @"Data Source=LAPTOP-4EFUU78K\SQLEXPRESS01;Initial Catalog=TuyenSinh;Integrated Security=True";
        public string ConnStr = @"Data Source=TRANHUYNHTANPHA;Initial Catalog=TuyenSinh;Integrated Security=True";
        //public string ConnStr = @"Data Source=NGUIT;Initial Catalog=TuyenSinh;Integrated Security=True";
        public SqlConnection conn = null;
        public SqlCommand comm = null;
        public SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
