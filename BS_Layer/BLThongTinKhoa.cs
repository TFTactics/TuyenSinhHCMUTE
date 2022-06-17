using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLThongTinKhoa
    {
        DBMain db = null;
        public BLThongTinKhoa()
        {
            db=new DBMain();
        }
        public DataSet LayThongTinKhoa()
        {
            return db.ExecuteQueryDataSet("select * from ThongTinKhoa", CommandType.Text);
        }
        public bool ThemThongTinKhoa(string TenKhoa, string GioiThieu, ref string err)
        {
            string sqlString = "Insert into ThongTinKhoa values (" + "N'" + TenKhoa + "',N'" + GioiThieu + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaThongTinKhoa(ref string err, string TenKhoa)
        {
            string sqlString = "delete from ThongTinKhoa where TenKhoa=N'" + TenKhoa+ "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
