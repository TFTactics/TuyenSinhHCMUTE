using System;
using System.Windows.Forms;

namespace UI.View_Layer.ViewLayer_Them
{
    public partial class UCThemPTXT : UserControl
    {
        string err = "";
        public UCThemPTXT()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BS_Layer.BLPhuongThucXetTuyen bdPTTX = new BS_Layer.BLPhuongThucXetTuyen();
            bdPTTX.ThemPhuongThucXetTuyen(txtTenPT.Text, txtMaPT.Text, cbbHeDaoTao.Text, Convert.ToDateTime(dtTGBatDau.Value.ToString()).Date, Convert.ToDateTime(dtTGKetThuc.Value.ToString()).Date, txtAnh.Text, txtNoiDungPT.Text, cbbPTcha.Text,ref err);
            MessageBox.Show(dtTGBatDau.Value.ToString("yyyy-MM-dd"));
            
        }
    }
}
