using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace UI.View_Layer.View_Layer_QLTimeLine
{
    public partial class UCThemTimeLine : UserControl
    {
        DataTable dtTimeLine = null;
        string err;
        public UCThemTimeLine()
        {
            InitializeComponent();
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            BS_Layer.BLTimeLine blTL = new BS_Layer.BLTimeLine();
            blTL.ThemTimeLine(txtTenSK.Text, dtTGBatDau.Value, dtTGKetThuc.Value, cbbHeDaoTao.Text, txtHeDaoTao.Text, ref err);
            MessageBox.Show(dtTGBatDau.Value.ToString("yyyy-MM-dd"));
        }
    }
}
