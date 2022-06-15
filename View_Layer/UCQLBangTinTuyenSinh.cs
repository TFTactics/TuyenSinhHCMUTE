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
    public partial class UCQLBangTinTuyenSinh : UserControl
    {
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

    }
}
