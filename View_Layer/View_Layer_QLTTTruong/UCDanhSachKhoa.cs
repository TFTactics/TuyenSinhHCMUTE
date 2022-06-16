using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCDanhSachKhoa : UserControl
    {
        DataTable dtThongTinKhoa = null;
        BLThongTinKhoa dbTTK = new BLThongTinKhoa();
        private bool checkUC = false;

        public UCDanhSachKhoa()
        {
            InitializeComponent();
        }

        private void UCDanhSachKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                dtThongTinKhoa = new DataTable();
                dtThongTinKhoa.Clear();

                DataSet ds = dbTTK.LayThongTinKhoa();
                dtThongTinKhoa = ds.Tables[0];
                dgvDanhSachKhoa.DataSource = dtThongTinKhoa;

                dgvDanhSachKhoa.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Thong Tin Khoa");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemKhoa1.Dock = DockStyle.Fill;
            ucThemKhoa1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer.BringToFront();
        }
    }
}
