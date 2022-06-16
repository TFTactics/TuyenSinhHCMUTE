using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLThongTinNguoiDung
    {
        DBMain db = null;
        public BLThongTinNguoiDung()
        {
            db=new DBMain();
        }
        public DataSet LayThongTinNguoiDung()
        {
            return db.ExecuteQueryDataSet("select * from ThongTinNguoiDung", CommandType.Text);
        }
        public bool ThemNguoiDung(string HoTen, string DienThoai,string Email, string LoaiNGuoiDung, ref string err)
        {
            string sqlString = "Insert into ThongTinNguoiDung values (" + "N'" + HoTen + "',N'" + DienThoai + "',N'" + Email + "',N'" + LoaiNGuoiDung + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaBangTin(ref string err, string TieuDe, string NoiDung, string NgayDang)
        {
            string sqlString = "delete from TuyenSinh where TieuDe=N'" + TieuDe + "' and NgayDang='" + NgayDang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
