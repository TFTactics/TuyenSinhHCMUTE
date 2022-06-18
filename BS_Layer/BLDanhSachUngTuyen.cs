using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLDanhSachUngTuyen
    {
        DBMain db = null;
        public BLDanhSachUngTuyen()
        {
            db=new DBMain();
        }
        public DataSet LayDanhSachUngTuyen()
        {
            return db.ExecuteQueryDataSet("select * from DanhSachUngTuyen", CommandType.Text);
        }
        public bool ThemDanhSachUngTuyen(string HoTen, string Email,string SDT, int MaHoSo, int MaNguyenVong, string NganhUngTuyen, string TrangThai, string PhuongThuc, ref string err)
        {
            string sqlString = "Insert into DanhSachUngTuyen values (" + "N'" + HoTen + "',N'" + Email + "',N'" + SDT + "','" + MaHoSo + "','" + MaNguyenVong + "',N'" + TrangThai + "',N'" + PhuongThuc + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaDanhSachUngTuyen(ref string err, string TieuDe)
        {
            string sqlString = "delete from TinTuyenSinh where TieuDe=N'" + TieuDe +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaDanhSachUngTuyen(ref string err, string TieuDe, string NoiDung, string HeDaoTao, string TrangThai)
        {
            string sqlString = "Update TinTuyenSinh SET TieuDe=N'" + TieuDe + 
                "',NoiDung=N'" + NoiDung + "',HeDaoTao=N'" + HeDaoTao + "',TrangThai=N'" + TrangThai
                + "'WHERE TieuDe = N'" + TieuDe + "'" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
