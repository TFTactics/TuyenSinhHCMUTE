using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLTimeLine
    {
        DBMain db = null;
        public BLTimeLine()
        {
            db=new DBMain();
        }
        public DataSet LayTimeLine()
        {
            return db.ExecuteQueryDataSet("select * from TimeLine", CommandType.Text);
        }
        public bool ThemBangTin(string TieuDe, string NoiDung,string HeDaoTao, string TrangThai, ref string err)
        {
            string sqlString = "Insert into TimeLine value (" + "N'" + TieuDe + "',N'" + NoiDung + "',N'" + HeDaoTao + "',N'" + TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaBangTin(ref string err, string TieuDe, string NoiDung, string NgayDang)
        {
            string sqlString = "delete from TuyenSinh where TieuDe=N'" + TieuDe + "' and NgayDang='" + NgayDang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
