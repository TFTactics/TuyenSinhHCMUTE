using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View_Layer
{
    public partial class UCQLThongTinTruong : UserControl
    {
        public UCQLThongTinTruong()
        {
            InitializeComponent();
        }

        private void pnlGTChung_Click(object sender, EventArgs e)
        {
            ucGioiThieuChung1.Dock = DockStyle.Fill;
            ucGioiThieuChung1.BringToFront();
        }

        private void pnlCTDaoTao_Click(object sender, EventArgs e)
        {
            ucctDaoTao1.Dock = DockStyle.Fill;
            ucctDaoTao1.BringToFront();
        }

        private void pnlPTTuyenSinh_Click(object sender, EventArgs e)
        {
            ucPhuongThucTS1.Dock = DockStyle.Fill;
            ucPhuongThucTS1.BringToFront();
        }

        private void guna2Panel6_Click(object sender, EventArgs e)
        {
            ucHocPhiHocBong1.Dock = DockStyle.Fill;
            ucHocPhiHocBong1.BringToFront();
        }

        private void pnlTTNhapHoc_Click(object sender, EventArgs e)
        {
            ucThongTinNhapHoc1.Dock = DockStyle.Fill;
            ucThongTinNhapHoc1.BringToFront();
        }


        private void pnlDSKhoa_Click(object sender, EventArgs e)
        {
            ucDanhSachKhoa1.Dock = DockStyle.Fill;
            ucDanhSachKhoa1.BringToFront();
        }

        private void pnlNganhDT_Click(object sender, EventArgs e)
        {
            ucNganhDaoTao1.Dock = DockStyle.Fill;
            ucNganhDaoTao1.BringToFront();
        }

        private void pnlLienHe_Click(object sender, EventArgs e)
        {
            ucLienHe1.Dock = DockStyle.Fill;
            ucLienHe1.BringToFront();
        }

        private void pnlHeDaoTao_Click(object sender, EventArgs e)
        {
            ucHeDaoTao1.Dock = DockStyle.Fill;
            ucHeDaoTao1.BringToFront();
        }

        private void lbHome_Click(object sender, EventArgs e)
        {
            pnlQLThongTinTruong1.BringToFront();
        }

    }
}
