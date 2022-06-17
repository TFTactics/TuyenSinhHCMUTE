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
        public bool XoaBangTin(ref string err, string TieuDe)
        {
            string sqlString = "delete from TimeLine where TenSuKien=N'" + TieuDe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaBangTin(ref string err, string TieuDe, string NgayDang, string KetThuc, string HDT, string NoiDung)
        {
            string sqlString = "UPDATE TimeLine SET ThoiGianBatDau=N'" + NgayDang + "',ThoiGianKetThuc=N'"
                + KetThuc + "',HeDaoTao=N'" + HDT + "',NoiDung=N'" + NoiDung + "'WHERE TenSuKien=N'" + TieuDe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
