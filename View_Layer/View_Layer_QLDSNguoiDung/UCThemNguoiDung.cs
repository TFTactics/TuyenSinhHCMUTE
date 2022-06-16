using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View_Layer.View_Layer_QLDSNguoiDung
{
    public partial class UCThemNguoiDung : UserControl
    {
        string err;
        public UCThemNguoiDung()
        {
            InitializeComponent();
        }

        private void UCThemNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BS_Layer.BLThongTinNguoiDung blTTND = new BS_Layer.BLThongTinNguoiDung();
            blTTND.ThemNguoiDung(txtHoTen.Text, txtSĐT.Text, txtEmail.Text, cbbLoaiCV.Text, ref err);
            MessageBox.Show("Done!!");
            txtEmail.Clear();
            txtHoTen.Clear();
            txtSĐT.Clear();
        }
    }
}
