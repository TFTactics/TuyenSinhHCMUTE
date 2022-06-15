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
    public partial class UCHeDaoTao : UserControl
    {
        DataTable dtHeDaoTao = null;
        BLHeDaoTao dbHeDaoTao = new BLHeDaoTao();
        private bool checkUC = false;

        public UCHeDaoTao()
        {
            InitializeComponent();
        }

        private void UCHeDaoTao_Load(object sender, EventArgs e)
        {
            try
            {
                dtHeDaoTao = new DataTable();
                dtHeDaoTao.Clear();

                DataSet ds = dbHeDaoTao.LayHeDaoTao();
                dtHeDaoTao = ds.Tables[0];
                dgvCTDaoTao.DataSource = dtHeDaoTao;

                dgvCTDaoTao.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }
    }
}
