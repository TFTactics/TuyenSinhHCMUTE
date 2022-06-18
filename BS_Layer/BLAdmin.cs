using System.Data;
using UI.BD_Layer;
using System;
using System.Windows.Forms;

namespace UI.BS_Layer
{
    class BLAdmin
    {
        DBMain db = null;
        public BLAdmin()
        {
            db = new DBMain();
        }
        public bool ThemUser(string User, string Pass1, string Pass2,  ref string err)
        {
            if (Pass1 == Pass2)
            {
                MessageBox.Show("Done!!");
                string sqlString = "insert into Admin values(N'" + User + "',N'" + Pass1 + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            }
            else
                MessageBox.Show("Incorrect!");
            return false;
        }

        public bool CheckUser(string User, string Pass)
        {
            string sqlString = "SELECT Password FROM Admin WHERE Username = N'" + User + "'AND Password =N'" +
                Pass + "'";
            if(db.ExecuteQueryDataSet(sqlString,CommandType.Text).Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool Check(string User)
        {
            string sqlString = "SELECT Username FROM Admin WHERE Username = N'" + User + "'";
            if (db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
