using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.BD_Layer;

namespace UI.View_Layer.View_Layer_QLTTTruong.NganhDaoTao
{
    public partial class UCNDaoTao : UserControl
    {
        string err;
        public UCNDaoTao()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BS_Layer.BLNganhDaoTao dbNganhDT = new BS_Layer.BLNganhDaoTao();
            dbNganhDT.ThemNganhDaoTao(txtMaNganh.Text,txtTenNganh.Text, cbbLoaiCT.Text, cbbKhoa.Text, Convert.ToInt32(txtChiTieu.Text), Convert.ToInt32(txtHocPhi.Text), txtMoTaNganh.Text,ref err);
            MessageBox.Show("Done");
            txtTenNganh.Clear();
            txtMoTaNganh.Clear();
            txtChiTieu.Clear();
            txtHocPhi.Clear();
            txtMoTaNganh.Clear();
        }

        private void UCNDaoTao_Load(object sender, EventArgs e)
        {
            LoadCbb();
        }

        public void LoadCbb()
        {
            // Load database vào combobox
            DBMain db = new DBMain();
            var cmd1 = new SqlCommand("select * from ChuongTrinhDaoTao", db.conn);
            var cmd2 = new SqlCommand("select * from ThongTinKhoa", db.conn);

            db.conn.Open();
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cbbLoaiCT.DisplayMember = "TenChuongTrinh";
            cbbLoaiCT.DataSource = dt1;

            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.DataSource = dt2;
        }

        private void UCNDaoTao_Click(object sender, EventArgs e)
        {
            LoadCbb();
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            LoadCbb();
        }
    }
}
