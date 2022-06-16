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
            blTL.ThemTimeLine(txtTieuDe.Text, guna2DateTimePicker1.Value, guna2DateTimePicker2.Value, cbbHeDaoTao.Text, guna2TextBox1.Text, ref err);
            MessageBox.Show(guna2DateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }
    }
}
