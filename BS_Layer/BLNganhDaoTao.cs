using System.Data;
using System.Text.RegularExpressions;
using UI.BD_Layer;

namespace UI.BS_Layer
{
    internal class BLNganhDaoTao
    {
        DBMain db = null;
        public BLNganhDaoTao()
        {
            db=new DBMain();
        }
        public DataSet LayThongTin()
        {
            return db.ExecuteQueryDataSet("select * from ThongTinChuyenNganh", CommandType.Text);
        }
        public bool ThemNganhDaoTao(string MaNganh, string TenN, string LoaiCT, string Khoa, int ChiTieu, int HocPhi, string MoTa, ref string err)
        {
            string sqlString = "Insert into ThongTinChuyenNganh values (" + "N'" + MaNganh +"',N'"+TenN+ "',N'" + LoaiCT + "',N'" + Khoa + "','" + ChiTieu + "','" + HocPhi + "',N'" + MoTa + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNganh(ref string err, string MaNgang)
        {
            string sqlString = "delete from ThongTinChuyenNganh where MaNganh=N'" + MaNgang +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaNganh(ref string err,string MaNganh, string TenN, string LoaiCT, string Khoa, int ChiTieu,int HocPhi, string MoTa)
        {
            string sqlString = "Update ThongTinChuyenNganh SET TenNganh = N'" + TenN + "',LoaiChuongTrinh =N'" + LoaiCT + "',Khoa=N'" + Khoa + "',ChiTieu='" + ChiTieu+"',HocPhi='"+HocPhi+"',MoTaNganh=N'"+MoTa
                + "'WHERE MaNganh = N'" + MaNganh + "'" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public DataSet SearchNganh(string value)
        {
            string sqlString;
            if (!IsNumber(value))
            {
                sqlString = "select * from ThongTinChuyenNganh where MaNganh like '%"
                    + value + "%' or TenNganh like '%" + value + "%' or LoaiChuongTrinh like '%" + value
                    + "%' or Khoa like '%" + value + "%' or  MoTaNganh like '%" + value + "%'";
                
            }
            else
            {
                sqlString = "select * from ThongTinChuyenNganh where MaNganh like '%"
                    + value + "%' or TenNganh like '%" + value + "%' or LoaiChuongTrinh like '%" + value
                    + "%' or Khoa like '%" + value + "%' or ChiTieu='" + value + "' or HocPhi ='"
                    + value + "' or MoTaNganh like '%" + value + "%'";
            }
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet LocLoaiCT(string value)
        {
            string sqlString = "select * from ThongTinChuyenNganh where LoaiChuongTrinh = '"+value+"'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
