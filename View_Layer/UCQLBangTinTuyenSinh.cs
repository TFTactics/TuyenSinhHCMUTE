using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCQLBangTinTuyenSinh : UserControl
    {
        DataTable dtTinTuyenSinh = null;
        BLBangTinTuyenSinh dbTinTuyyenSinh = new BLBangTinTuyenSinh();
        private bool checkUC = false;
        public UCQLBangTinTuyenSinh()
        {
            InitializeComponent();
            ButtonBack();
        }
        private void ButtonBack()
        {
            if (checkUC)
                btnBack.Visible = true;
            else btnBack.Visible = false;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucThemTin1.BringToFront();
            ucThemTin1.Dock = DockStyle.Fill;
            pnlBanTinTuyenSinh.Visible = false;
            btnBack.BringToFront();
            ButtonBack();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            checkUC = false;
            pnlBanTinTuyenSinh.Visible = true;
            btnBack.BringToFront();
            ucThemTin1.SendToBack();
            ButtonBack();
        }

        private void UCQLBangTinTuyenSinh_Load(object sender, EventArgs e)
        {
            try
            {
                dtTinTuyenSinh = new DataTable();
                dtTinTuyenSinh.Clear();

                DataSet ds = dbTinTuyyenSinh.LayBangTin();
                dtTinTuyenSinh = ds.Tables[0];
                dgvTinTuyenSinh.DataSource = dtTinTuyenSinh;

                dgvTinTuyenSinh.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong TinTuyenSinh");
            }
        }
    }
}
