using System.Windows.Forms;

namespace UI.View_Layer
{
    public partial class UCQuanLyDanhSachUngTuyen : UserControl
    {

        public UCQuanLyDanhSachUngTuyen()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            pnlContainer.BringToFront();
        }

        private void btnAddEvent_Click(object sender, System.EventArgs e)
        {
            ucThemUngTuyen1.BringToFront();
            ucThemUngTuyen1.Dock = DockStyle.Fill;
        }
    }
}
