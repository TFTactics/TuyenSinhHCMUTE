using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View_Layer.ViewLayer_Them
{
    public partial class UCThemUngTuyen : UserControl
    {
        string err;

        public UCThemUngTuyen()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           /* BS_Layer.BLDanhSachUngTuyen blDSUT = new BS_Layer.BLDanhSachUngTuyen();
            blDSUT.ThemDanhSachUngTuyen(txtTenSK.Text, dtTGBatDau.Value, dtTGKetThuc.Value, cbbHeDaoTao.Text, txtNoiDung.Text, ref err);
            MessageBox.Show(dtTGBatDau.Value.ToString("yyyy-MM-dd"));*/
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

    }
}
