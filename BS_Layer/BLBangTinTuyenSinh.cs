using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLBangTinTuyenSinh
    {
        DBMain db = null;
        public BLBangTinTuyenSinh()
        {
            db=new DBMain();
        }
        public DataSet LayBangTin()
        {
            return db.ExecuteQueryDataSet("select * from TinTuyenSinh", CommandType.Text);
        }
        public bool ThemBangTin(string TieuDe, string NoiDung,string HeDaoTao, string TrangThai, ref string err)
        {
            string sqlString = "Insert into TinTuyenSinh values (" + "N'" + TieuDe + "',N'" + NoiDung + "',N'" + HeDaoTao + "',N'" + TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaBangTin(ref string err, string TieuDe)
        {
            string sqlString = "delete from TinTuyenSinh where TieuDe=N'" + TieuDe +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaTin(ref string err, string TieuDe, string NoiDung, string HeDaoTao, string TrangThai)
        {
            string sqlString = "Update TinTuyenSinh SET TieuDe=N'" + TieuDe + 
                "',NoiDung=N'" + NoiDung + "',HeDaoTao=N'" + HeDaoTao + "',TrangThai=N'" + TrangThai
                + "'WHERE TieuDe = N'" + TieuDe + "'" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
