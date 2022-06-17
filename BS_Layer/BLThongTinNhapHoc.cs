using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLThongTinNhapHoc
    {
        DBMain db = null;
        public BLThongTinNhapHoc()
        {
            db=new DBMain();
        }
        public DataSet LayThongTinNhapHoc()
        {
            return db.ExecuteQueryDataSet("select * from ThongTinNhapHoc", CommandType.Text);
        }
        public bool ThemThongTinNhapHoc(string NDNhapHoc, string BuocSo,string NoiDung, ref string err)
        {
            string sqlString = "Insert into ThongTinNhapHoc values (" + "N'" + NDNhapHoc + "',N'" + BuocSo + "',N'" + NoiDung + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaThongTin(ref string err, string NoiDungNhapHoc)
        {
            string sqlString = "delete from ThongTinNhapHoc where NoiDungNhapHoc=N'" + NoiDungNhapHoc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaThongTin(string NDNhapHoc, string BuocSo, string NoiDung, ref string err)
        {
            string sqlString = "UPDATE ThongTinNhapHoc SET BuocSo=N'" + BuocSo + "',NoiDung=N'" 
                + NoiDung + "'WHERE NoiDungNhapHoc=N'" + NDNhapHoc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
