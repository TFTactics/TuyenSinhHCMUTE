using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer.View_Layer_QLTTTruong.HDaoTao
{
    public partial class UCThemHDaoTao : UserControl
    {
        BLHeDaoTao dbHDT = new BS_Layer.BLHeDaoTao();
        string err;
        public UCThemHDaoTao()
        {
            InitializeComponent();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            dbHDT.ThemHeDaoTao(txtMaHDT.Text, txtTenHDT.Text,txtGTHDT.Text, ref err);
            MessageBox.Show("Done!!");
            txtMaHDT.Clear();
            txtTenHDT.Clear();
            txtGTHDT.Clear();
        }
    }
}
