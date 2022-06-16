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
        public bool XoaBangTin(ref string err, string TieuDe, string NoiDung, string NgayDang)
        {
            string sqlString = "delete from TuyenSinh where TieuDe=N'" + TieuDe + "' and NgayDang='" + NgayDang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
