using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View_Layer.View_Layer_QLTTTruong.DSKhoa
{
    public partial class UCThemKhoa : UserControl
    {
        string err;
        public UCThemKhoa()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BS_Layer.BLThongTinKhoa blTTK = new BS_Layer.BLThongTinKhoa();
            blTTK.ThemThongTinKhoa(txtTenKhoa.Text, txtGTKhoa.Text, ref err);
            MessageBox.Show("Done!!");
            txtGTKhoa.Clear();
            txtTenKhoa.Clear();
        }

        private void UCThemKhoa_Load(object sender, EventArgs e)
        {

        }
    }
}
