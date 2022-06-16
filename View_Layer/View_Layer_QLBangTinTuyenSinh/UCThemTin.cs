using System.Data;
using System.Windows.Forms;

namespace UI.View_Layer.View_Layer_QLBangTinTuyenSinh
{
    public partial class UCThemTin : UserControl
    {
        DataTable dtTinTuyenSinh = null;
        bool Them = false;
        string err;
        
        public UCThemTin()
        {
            InitializeComponent();
        }

        private void btnDangBai_Click(object sender, System.EventArgs e)
        {
            BS_Layer.BLBangTinTuyenSinh blTS = new BS_Layer.BLBangTinTuyenSinh();
            blTS.ThemBangTin(txtTieuDe.Text, txtNDBaiViet.Text, cbbHeDaoTao.Text, cbbTrangThai.Text, ref err);
            MessageBox.Show("Done!!");
            txtTieuDe.Clear();
            txtNDBaiViet.Clear();
        }
    }
}
