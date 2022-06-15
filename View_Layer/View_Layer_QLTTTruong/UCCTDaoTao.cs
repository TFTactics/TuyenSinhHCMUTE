using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
