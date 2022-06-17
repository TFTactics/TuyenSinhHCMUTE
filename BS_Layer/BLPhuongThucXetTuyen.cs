using System.Data;
using UI.BD_Layer;
using System;

namespace UI.BS_Layer
{
    internal class BLPhuongThucXetTuyen
    {
        DBMain db = null;
        public BLPhuongThucXetTuyen()
        {
            db=new DBMain();
        }
        public DataSet LayPhuongThucXetTuyen()
        {
            return db.ExecuteQueryDataSet("select * from PhuongThucXetTuyen", CommandType.Text);
        }
        public bool ThemPhuongThucXetTuyen(string TenPT, string MaPT, string HeDT, DateTime TGBD , DateTime TGKT, string Anh, string NoiDung, string PTCha,ref string err)
        {
            string sqlString = "Insert into PhuongThucXetTuyen values (" + "N'" + TenPT + "',N'" + MaPT + "',N'" + HeDT + "','" + TGBD.Date + "','" + TGKT.Date + "',N'" + Anh + "',N'" + NoiDung + "',N'" + PTCha + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhuongThucXetTuyen(ref string err, string MaPhuongThuc)
        {
            string sqlString = "delete from PhuongThucXetTuyen where MaPhuongThuc=N'" + MaPhuongThuc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaPhuongThuc(ref string err, string TenPT, string MaPT, string HeDT, DateTime TGBD, DateTime TGKT, string Anh, string NoiDung, string PTCha)
        {
            string sqlString = "UPDATE PhuongThucXetTuyen SET TenPhuongThuc=N'"+TenPT+"',HeDaoTao=N'"+HeDT+"',ThoiGianBatDau=N'"+TGBD.Date
                +"',ThoiGianKetThuc = N'"+TGKT.Date+"',HinhAnh = N'"+Anh+"',NoiDung = N'"+NoiDung
                +"',PhuongThucCha = N'"+PTCha+"' WHERE MaPhuongThuc = N'"+MaPT+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
