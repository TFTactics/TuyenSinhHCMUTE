using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BD_Layer;

namespace UI.View_Layer.View_Layer_QLBangTinTuyenSinh
{
    public partial class UCThemTin : UserControl
    {
        private string err;
        public UCThemTin()
        {
            InitializeComponent();
        }

        private void btnDangBai_Click(object sender, System.EventArgs e)
        {
            BS_Layer.BLBangTinTuyenSinh blTS = new BS_Layer.BLBangTinTuyenSinh();
            blTS.ThemBangTin(txtTieuDe.Text, txtNDBaiViet.Text, cbbHeDaoTao.Text, cbbTrangThai.Text, ref err);
            MessageBox.Show("Done!!");
            txtTieuDe.Clear();
            txtNDBaiViet.Clear();
        }

        private void UCThemTin_Load(object sender, System.EventArgs e)
        {
            LoadCbb();
        }

        public void LoadCbb()
        {
            // Load database vào combobox
            DBMain db = new DBMain();
            var cmd1 = new SqlCommand("select * from HeDaoTao", db.conn);

            db.conn.Open();
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cbbHeDaoTao.DisplayMember = "TenHeDaoTao";
            cbbHeDaoTao.DataSource = dt1;
        }

        // reload lại cbb
        private void UCThemTin_Click(object sender, System.EventArgs e)
        {
            LoadCbb();
        }

        private void pnlContainer_Click(object sender, System.EventArgs e)
        {
            LoadCbb();
        }
    }
}
