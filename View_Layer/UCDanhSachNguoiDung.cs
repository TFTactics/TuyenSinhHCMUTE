using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCDanhSachNguoiDung : UserControl
    {
        DataTable dtDanhSachNguoiDung = null;
        BLThongTinNguoiDung dbThongTinNguoiDung = new BLThongTinNguoiDung();
        private bool checkUC = false;

        public UCDanhSachNguoiDung()
        {
            InitializeComponent();
        }

        private void UCDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                dtDanhSachNguoiDung = new DataTable();
                dtDanhSachNguoiDung.Clear();

                DataSet ds = dbThongTinNguoiDung.LayThongTinNguoiDung();
                dtDanhSachNguoiDung = ds.Tables[0];
                dgvThongTinNguoiDung.DataSource = dtDanhSachNguoiDung;

                dgvThongTinNguoiDung.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucThemNguoiDung1.SendToBack();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucThemNguoiDung1.BringToFront();
            ucThemNguoiDung1.Dock = DockStyle.Fill;
        }
    }
}
