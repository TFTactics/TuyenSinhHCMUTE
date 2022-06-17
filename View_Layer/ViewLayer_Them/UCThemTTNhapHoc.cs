using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View_Layer.View_Layer_QLTTTruong.TTNhapHoc
{
    public partial class UCThemTTNhapHoc : UserControl
    {
        string err;
        public UCThemTTNhapHoc()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BS_Layer.BLThongTinNhapHoc blTTNH = new BS_Layer.BLThongTinNhapHoc();
            blTTNH.ThemThongTinNhapHoc(txtTenNDNhapHoc.Text, txtBuocSo.Text, txtNDTTNhapHoc.Text, ref err);
            MessageBox.Show("Done!!");
            txtBuocSo.Clear();
            txtNDTTNhapHoc.Clear();
            txtTenNDNhapHoc.Clear();
        }
    }
}
