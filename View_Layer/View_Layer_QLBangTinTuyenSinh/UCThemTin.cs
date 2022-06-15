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

        private void UCThemTin_Load(object sender, EventArgs e)
        {
        }
    }
}
