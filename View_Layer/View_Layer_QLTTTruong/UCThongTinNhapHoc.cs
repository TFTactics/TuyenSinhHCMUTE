using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCThongTinNhapHoc : UserControl
    {
        DataTable dtThongTinNhapHoc = null;
        BLThongTinNhapHoc dbThongTinNhapHoc = new BLThongTinNhapHoc();
        private bool checkUC = false;
        public UCThongTinNhapHoc()
        {
            InitializeComponent();
        }

        private void UCThongTinNhapHoc_Load(object sender, EventArgs e)
        {
            try
            {
                dtThongTinNhapHoc = new DataTable();
                dtThongTinNhapHoc.Clear();

                DataSet ds = dbThongTinNhapHoc.LayThongTinNhapHoc();
                dtThongTinNhapHoc = ds.Tables[0];
                dgvTTNhapHoc.DataSource = dtThongTinNhapHoc;

                dgvTTNhapHoc.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Thong Tin Nhap Hoc");
            }
        }
    }
}
