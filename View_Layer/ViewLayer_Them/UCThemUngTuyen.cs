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

namespace UI.View_Layer.ViewLayer_Them
{
    public partial class UCThemUngTuyen : UserControl
    {
        string err;

        public UCThemUngTuyen()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BS_Layer.BLDanhSachUngTuyen blDSUT = new BS_Layer.BLDanhSachUngTuyen();
                blDSUT.ThemDanhSachUngTuyen(txtHoTen.Text, txtEmail.Text, txtSDT.Text, Convert.ToInt32(txtMaHS.Text), Convert.ToInt32(txtMaNV.Text), txtNganhUT.Text, cbbTrangThai.Text, cbbPhuongThuc.Text, ref err);
                MessageBox.Show("Done!");
                txtEmail.Clear();
                txtHoTen.Clear();
                txtMaHS.Clear();
                txtMaNV.Clear();
                txtNganhUT.Clear();
                txtSDT.Clear();
            }
            catch
            {
                MessageBox.Show("Sai Cú Pháp");
            }
        }

        public void LoadCbb()
        {
            // Load database vào combobox
            DBMain db = new DBMain();
            var cmd1 = new SqlCommand("select * from PhuongThucXetTuyen", db.conn);

            db.conn.Open();
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cbbPhuongThuc.DisplayMember = "TenPhuongThuc";
            cbbPhuongThuc.DataSource = dt1;

            
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void UCThemUngTuyen_Click(object sender, EventArgs e)
        {
            LoadCbb();
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            LoadCbb();
        }

        private void UCThemUngTuyen_Load(object sender, EventArgs e)
        {
            LoadCbb();
        }
    }
}
