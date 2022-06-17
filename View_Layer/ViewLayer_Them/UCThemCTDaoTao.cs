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

namespace UI.View_Layer.View_Layer_QLTTTruong.CTDaoTao
{
    public partial class UCThemCTDaoTao : UserControl
    {
        string err;
        public UCThemCTDaoTao()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BS_Layer.BLChuongTrinhDaoTao blCTDT = new BS_Layer.BLChuongTrinhDaoTao();
            blCTDT.ThemChuongTrinhDaoTao(txtTenCT.Text, cbbNganhDT.Text, cbbHeDaoTao.Text, txtLinkPDF.Text, txtNoiDungCT.Text, ref err);
            MessageBox.Show("Done!!");
            txtNoiDungCT.Clear();
            txtLinkPDF.Clear();
            txtTenCT.Clear();
        }

        private void UCThemCTDaoTao_Load(object sender, EventArgs e)
        {
            LoadCbb();
        }

        public void LoadCbb()
        {
            // Load database vào combobox
            DBMain db = new DBMain();
            var cmd1 = new SqlCommand("select * from ThongTinChuyenNganh", db.conn);
            var cmd2 = new SqlCommand("select * from HeDaoTao", db.conn);

            db.conn.Open();
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cbbNganhDT.DisplayMember = "TenNghanh";
            cbbNganhDT.DataSource = dt1;

            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cbbHeDaoTao.DisplayMember = "TenHeDaoTao";
            cbbHeDaoTao.DataSource = dt2;
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            LoadCbb();

        }

        private void UCThemCTDaoTao_Click(object sender, EventArgs e)
        {
            LoadCbb();
        }
    }
}
