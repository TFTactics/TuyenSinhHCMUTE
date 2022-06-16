﻿using System.Data;
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
        public bool XoaBangTin(ref string err, string TieuDe, string NoiDung, string NgayDang)
        {
            string sqlString = "delete from TuyenSinh where TieuDe=N'" + TieuDe + "' and NgayDang='" + NgayDang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
