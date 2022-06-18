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
            string sqlString = "Insert into DanhSachUngTuyen values (" + "N'" + HoTen + "',N'" + Email + "',N'" + SDT + "','" + MaHoSo + "','" + MaNguyenVong + "',N'" + NganhUngTuyen + "',N'" + TrangThai + "',N'" + PhuongThuc + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaDanhSachUngTuyen(ref string err, string email)
        {
            string sqlString = "delete from DanhSachUngTuyen where Email=N'" + email +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaDanhSachUngTuyen(ref string err, string Hoten, string email, string sdt,int MaHS,int MaNV, string TrangThai, string PT)
        {
            string sqlString = "Update DanhSachUngTuyen SET HoTen=N'" + Hoten + 
                "',SDT=N'" + sdt +"',MaHoSo='"+MaHS+"',MaNguyenVong='"+MaNV+ "',TrangThai=N'" + TrangThai+"',PhuongThuc=N'"+PT
                + "'WHERE Email = N'" + email + "'" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
