using System.Data;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLHeDaoTao
    {
        DBMain db = null;
        public BLHeDaoTao()
        {
            db=new DBMain();
        }
        public DataSet LayHeDaoTao()
        {
            return db.ExecuteQueryDataSet("select * from HeDaoTao", CommandType.Text);
        }
        public bool ThemHeDaoTao(string MaHDT, string TenHDT,string GioiThieu, ref string err)
        {
            string sqlString = "Insert into HeDaoTao values (" + "N'" + MaHDT + "',N'" + TenHDT + "',N'" + GioiThieu + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHeDaoTao(ref string err, string MaHDT)
        {
            string sqlString = "delete from HeDaoTao where MaHeDaoTao=N'" + MaHDT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
