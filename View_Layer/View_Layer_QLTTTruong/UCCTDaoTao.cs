using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCCTDaoTao : UserControl
    {
        DataTable dtCTDT = null;
        BLChuongTrinhDaoTao dbCTDT = new BLChuongTrinhDaoTao();

        public UCCTDaoTao()
        {
            InitializeComponent();
        }

        private void UCCTDaoTao_Load(object sender, EventArgs e)
        {
            try
            {
                dtCTDT = new DataTable();
                dtCTDT.Clear();

                DataSet ds = dbCTDT.LayChuongTrinhDaoTao();
                dtCTDT = ds.Tables[0];
                dgvCTDaoTao.DataSource = dtCTDT;

                dgvCTDaoTao.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemCTDaoTao1.BringToFront();
            ucThemCTDaoTao1.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer1.BringToFront();
        }
    }
}
