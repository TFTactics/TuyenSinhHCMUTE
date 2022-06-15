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

        private void guna2Button3_Click(object sender, EventArgs e)
        {

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
    }
}
