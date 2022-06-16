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
    }
}
