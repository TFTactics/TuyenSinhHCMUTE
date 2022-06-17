using System;
using System.Windows.Forms;

namespace UI.View_Layer.View_Layer_QLTimeLine
{
    public partial class UCThemTimeLine : UserControl
    {
        string err;
        public UCThemTimeLine()
        {
            InitializeComponent();
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            BS_Layer.BLTimeLine blTL = new BS_Layer.BLTimeLine();
            blTL.ThemTimeLine(txtTenSK.Text, dtTGBatDau.Value, dtTGKetThuc.Value, cbbHeDaoTao.Text,txtNoiDung.Text, ref err);
            MessageBox.Show(dtTGBatDau.Value.ToString("yyyy-MM-dd"));
        }
    }
}
