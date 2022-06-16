using System;
using System.Windows.Forms;

namespace UI.View_Layer
{
    public partial class UCQLThongTinTruong : UserControl
    {
        public UCQLThongTinTruong()
        {
            InitializeComponent();
        }
        public void HidePnlContainer(bool flag)
        {
            if (flag)
                pnlQLThongTinTruong1.Visible = false;
            else pnlQLThongTinTruong1.Visible=true;
        }
        public void HideUC()
        {
            ucctDaoTao1.Visible = false;
            ucDanhSachKhoa1.Visible = false;
            ucGioiThieuChung1.Visible = false;
            ucHeDaoTao1.Visible = false;
            ucHocPhiHocBong1.Visible = false;
            ucLienHe1.Visible = false;
            ucNganhDaoTao1.Visible = false;
            ucPhuongThucTS1.Visible = false;
            ucThongTinNhapHoc1.Visible = false;

        }
        private void pnlGTChung_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucGioiThieuChung1.Visible = true;
            ucGioiThieuChung1.Dock = DockStyle.Fill;
            ucGioiThieuChung1.BringToFront();
        }

        private void pnlCTDaoTao_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucctDaoTao1.Visible=true;
            ucctDaoTao1.Dock = DockStyle.Fill;
            ucctDaoTao1.BringToFront();
        }

        private void pnlPTTuyenSinh_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucPhuongThucTS1.Dock = DockStyle.Fill;
            ucPhuongThucTS1.BringToFront();
            ucPhuongThucTS1.Visible = true;
        }

        private void guna2Panel6_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucHocPhiHocBong1.Dock = DockStyle.Fill;
            ucHocPhiHocBong1.BringToFront();
            ucHocPhiHocBong1.Visible = true;
        }

        private void pnlTTNhapHoc_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucThongTinNhapHoc1.Visible = true;
            ucThongTinNhapHoc1.Dock = DockStyle.Fill;
            ucThongTinNhapHoc1.BringToFront();
            ucThongTinNhapHoc1.Visible = true;
        }


        private void pnlDSKhoa_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucDanhSachKhoa1.Dock = DockStyle.Fill;
            ucDanhSachKhoa1.BringToFront();
            ucDanhSachKhoa1.Visible = true;
        }

        private void pnlNganhDT_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucNganhDaoTao1.Dock = DockStyle.Fill;
            ucNganhDaoTao1.BringToFront();
            ucNganhDaoTao1.Visible = true;
        }

        private void pnlLienHe_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucLienHe1.Dock = DockStyle.Fill;
            ucLienHe1.BringToFront();
            ucLienHe1.Visible = true;
        }

        private void pnlHeDaoTao_Click(object sender, EventArgs e)
        {
            HidePnlContainer(true);
            HideUC();
            ucHeDaoTao1.Dock = DockStyle.Fill;
            ucHeDaoTao1.BringToFront();
            ucHeDaoTao1.Visible = true;
        }

        private void lbHome_Click(object sender, EventArgs e)
        {
            HidePnlContainer(false);
            HideUC();
        }

    }
}
