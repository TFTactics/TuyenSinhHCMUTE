using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View_Layer.View_Layer_QLTTTruong.NganhDaoTao
{
    public partial class UCNDaoTao : UserControl
    {
        string err;
        public UCNDaoTao()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BS_Layer.BLNganhDaoTao dbNganhDT = new BS_Layer.BLNganhDaoTao();
            dbNganhDT.ThemNganhDaoTao(txtMaNganh.Text,txtTenNganh.Text, cbbLoaiCT.Text, cbbKhoa.Text, Convert.ToInt32(txtChiTieu.Text), Convert.ToInt32(txtHocPhi.Text), txtMoTaNganh.Text,ref err);
            MessageBox.Show("Done");
            txtTenNganh.Clear();
            txtMoTaNganh.Clear();
            txtChiTieu.Clear();
            txtHocPhi.Clear();
            txtMoTaNganh.Clear();
        }
    }
}
