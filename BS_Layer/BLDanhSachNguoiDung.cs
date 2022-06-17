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
        public bool XoaNguoiDung(ref string err, string HoTen)
        {
            string sqlString = "delete from ThongTinNguoiDung where HoTen=N'" + HoTen+ "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaThongTin(ref string err, string HoTen, string DienThoai, string Email, string LoaiNGuoiDung)
        {
            string sqlString = "UPDATE ThongTinNguoiDung SET DienThoai=N'" + DienThoai + "',Email=N'"
                + Email + "',LoaiNguoiDung=N'" + LoaiNGuoiDung + "' Where HoTen=N'"+HoTen+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
