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
        private bool checkUC = false;
        public UCQLThongTinTruong()
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

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            checkUC = false;
            pnlQLThongTinTruong1.BringToFront();
            ButtonBack();
        }

        private void pnlGTChung_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucGioiThieuChung1.Dock = DockStyle.Fill;
            ucGioiThieuChung1.BringToFront();
            ButtonBack();
        }

        private void pnlCTDaoTao_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucctDaoTao1.Dock = DockStyle.Fill;
            ucctDaoTao1.BringToFront();
            ButtonBack();
        }

        private void pnlPTTuyenSinh_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucPhuongThucTS1.Dock = DockStyle.Fill;
            ucPhuongThucTS1.BringToFront();
            ButtonBack();
        }

        private void guna2Panel6_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucHocPhiHocBong1.Dock = DockStyle.Fill;
            ucHocPhiHocBong1.BringToFront();
            ButtonBack();
        }

        private void guna2Panel5_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucCacVanBanLienQuan1.Dock = DockStyle.Fill;
            ucCacVanBanLienQuan1.BringToFront();
            ButtonBack();
        }

        private void guna2Panel4_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucDiemChuanHangNam1.Dock = DockStyle.Fill;
            ucDiemChuanHangNam1.BringToFront();
            ButtonBack();
        }

        private void pnlTTNhapHoc_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucThongTinNhapHoc1.Dock = DockStyle.Fill;
            ucThongTinNhapHoc1.BringToFront();
            ButtonBack();
        }

        private void pnlCauHoiTG_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucCauHoiThuongGap1.Dock = DockStyle.Fill;
            ucCauHoiThuongGap1.BringToFront();
            ButtonBack();
        }

        private void pnlDSKhoa_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucDanhSachKhoa1.Dock = DockStyle.Fill;
            ucDanhSachKhoa1.BringToFront();
            ButtonBack();
        }

        private void pnlNganhDT_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucNganhDaoTao1.Dock = DockStyle.Fill;
            ucNganhDaoTao1.BringToFront();
            ButtonBack();
        }

        private void pnlLienHe_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucLienHe1.Dock = DockStyle.Fill;
            ucLienHe1.BringToFront();
            ButtonBack();
        }

        private void pnlHeDaoTao_Click(object sender, EventArgs e)
        {
            checkUC = true;
            ucHeDaoTao1.Dock = DockStyle.Fill;
            ucHeDaoTao1.BringToFront();
            ButtonBack();
        }
    }
}
