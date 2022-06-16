using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View_Layer.View_Layer_QLTTTruong.CTDaoTao
{
    public partial class UCThemCTDaoTao : UserControl
    {
        string err;
        public UCThemCTDaoTao()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BS_Layer.BLChuongTrinhDaoTao blCTDT = new BS_Layer.BLChuongTrinhDaoTao();
            blCTDT.ThemChuongTrinhDaoTao(txtTenCT.Text, cbbNganhDT.Text, cbbHeDaoTao.Text, txtLinkPDF.Text, txtNoiDungCT.Text, ref err);
            MessageBox.Show("Done!!");
            txtNoiDungCT.Clear();
            txtLinkPDF.Clear();
            txtTenCT.Clear();
        }
    }
}
