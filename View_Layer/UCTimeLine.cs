using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;
namespace UI.View_Layer
{
    public partial class UCTimeLine : UserControl
    {
        DataTable dtTimeLine = null;
        BLTimeLine dbTimeLine = new BLTimeLine();
        public UCTimeLine()
        {
            InitializeComponent();
        }

        private void UCTimeLine_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtTimeLine = new DataTable();
                dtTimeLine.Clear();

                DataSet ds = dbTimeLine.LayTimeLine();
                dtTimeLine = ds.Tables[0];
                dgvTimeLine.DataSource = dtTimeLine;

                dgvTimeLine.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }


        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemTimeLine1.BringToFront();
            ucThemTimeLine1.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucThemTimeLine1.SendToBack();
            LoadData();
        }

    }
}
