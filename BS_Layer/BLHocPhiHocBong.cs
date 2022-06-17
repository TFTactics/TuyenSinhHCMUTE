using System;
using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLHocPhiHocBong
    {
        DBMain db = null;
        public BLHocPhiHocBong()
        {
            db = new DBMain();
        }
        public DataSet LayThongTin()
        {
            return db.ExecuteQueryDataSet("select * from HocPhiHocBong", CommandType.Text);
        }
        public bool SuaThongTin(string noidung, ref string err)
        {
            string sqlString = "UPDATE HocPhiHocBong SET " + "NoiDung = " +
                "N'" + noidung + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public void LayDuLieu(ref string GTC)
        {
            DataSet ds = LayThongTin();
            DataTable dtGTC = new DataTable();
            dtGTC.Clear();
            dtGTC = ds.Tables[0];
            GTC = dtGTC.Rows[0][0].ToString();
            
        }
    }
}
