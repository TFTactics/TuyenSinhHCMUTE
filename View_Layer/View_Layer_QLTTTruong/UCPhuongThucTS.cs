using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCPhuongThucTS : UserControl
    {
        DataTable dtPhuongThucTuyenSinh = null;
        BLPhuongThucXetTuyen dbPhuongThucXetTuyen = new BLPhuongThucXetTuyen();
        private bool checkUC = false;

        public UCPhuongThucTS()
        {
            InitializeComponent();
        }

        private void UCPhuongThucTS_Load(object sender, EventArgs e)
        {
            try
            {
                dtPhuongThucTuyenSinh = new DataTable();
                dtPhuongThucTuyenSinh.Clear();

                DataSet ds = dbPhuongThucXetTuyen.LayPhuongThucXetTuyen();
                dtPhuongThucTuyenSinh = ds.Tables[0];
                dgvPhuongThucTS.DataSource = dtPhuongThucTuyenSinh;

                dgvPhuongThucTS.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Phuong thuc xet tuyen");
            }
        }
    }
}
