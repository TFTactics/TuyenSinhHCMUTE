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
    public partial class UCCacVanBanLienQuan : UserControl
    {
        DataTable dtThongTinVanBan = null;
        BLThongTinVanBan dbTTVB = new BLThongTinVanBan();
        private bool checkUC = false;

        public UCCacVanBanLienQuan()
        {
            InitializeComponent();
        }

        private void dgvCacVanBanLienQuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UCCacVanBanLienQuan_Load(object sender, EventArgs e)
        {
            try
            {
                dtThongTinVanBan = new DataTable();
                dtThongTinVanBan.Clear();

                DataSet ds = dbTTVB.LayThongTinVanBan();
                dtThongTinVanBan = ds.Tables[0];
                dgvCacVanBanLienQuan.DataSource = dtThongTinVanBan;

                dgvCacVanBanLienQuan.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Thong Tin Van Ban");
            }
        }
    }
}
