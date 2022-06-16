using System.Data;
using UI.BD_Layer;
using System;

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
        public bool ThemTimeLine(string TenSuKien, DateTime BatDau,DateTime KetThuc, string HeDaoTao, string NoiDung, ref string err)
        {
            string sqlString = "Insert into TimeLine values (" + "N'" + TenSuKien + "',N'" + BatDau.ToString("yyyy-MM-dd") + "',N'" + KetThuc.ToString("yyyy-MM-dd") + "',N'" + HeDaoTao + "',N'" + NoiDung + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaBangTin(ref string err, string TieuDe, string NoiDung, string NgayDang)
        {
            string sqlString = "delete from TuyenSinh where TieuDe=N'" + TieuDe + "' and NgayDang='" + NgayDang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
