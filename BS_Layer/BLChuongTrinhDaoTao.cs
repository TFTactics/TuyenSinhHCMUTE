using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLChuongTrinhDaoTao
    {
        DBMain db = null;
        public BLChuongTrinhDaoTao()
        {
            db=new DBMain();
        }
        public DataSet LayChuongTrinhDaoTao()
        {
            return db.ExecuteQueryDataSet("select * from ChuongTrinhDaoTao", CommandType.Text);
        }
        public bool ThemChuongTrinhDaoTao(string TenCTDT, string NganhDaoTao,string HeDaoTao, string PDFDaoTao, string NoiDung, ref string err)
        {
            string sqlString = "Insert into ChuongTrinhDaoTao values (" + "N'" + TenCTDT + "',N'" + NganhDaoTao + "',N'" + HeDaoTao + "',N'" + PDFDaoTao + "',N'" + NoiDung + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChuongTrinhDaoTao(ref string err, string TieuDe)
        {
            string sqlString = "delete from ChuongTrinhDaoTao where NganhDaoTao=N'" + TieuDe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaChuongTrinh(ref string err, string TCT, string NDT, string HDT, string PDF, string ND)
        {
            string sqlString = "UPDATE ChuongTrinhDaoTao SET TenChuongTrinh=N'" + TCT + 
                "',NganhDaoTao=N'" + NDT + "',HeDaoTao=N'" + HDT + "',PDFDaoTao=N'" + PDF +
                "',NoiDung=N'" + ND + "'WHERE TenChuongTrinh = N'" + TCT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataTable LayTenChuongTrinh()
        {
            string sqlString = "Select TenChuongTrinh from ChuongTrinhDaoTao";
            DataSet ds = db.ExecuteQueryDataSet(sqlString,CommandType.Text);
            return ds.Tables[0];
        }
    }
}
