using System.Windows.Forms;

namespace UI.View_Layer
{
    public partial class UCNganhDaoTao : UserControl
    {
        public UCNganhDaoTao()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, System.EventArgs e)
        {
            ucnDaoTao1.Dock = DockStyle.Fill;
            ucnDaoTao1.BringToFront();
            ucnDaoTao1.Visible = true;
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            ucnDaoTao1.Visible = false;
        }
    }
}
