using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BD_Layer;

namespace UI.View_Layer.View_Layer_QLTimeLine
{
    public partial class UCThemTimeLine : UserControl
    {
        string err;
        public UCThemTimeLine()
        {
            InitializeComponent();
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            BS_Layer.BLTimeLine blTL = new BS_Layer.BLTimeLine();
            blTL.ThemTimeLine(txtTenSK.Text, dtTGBatDau.Value, dtTGKetThuc.Value, cbbHeDaoTao.Text,txtNoiDung.Text, ref err);
            MessageBox.Show(dtTGBatDau.Value.ToString("yyyy-MM-dd"));
        }

        public void LoadCbb()
        {
            // Load database vào combobox
            DBMain db = new DBMain();
            var cmd = new SqlCommand("select * from HeDaoTao", db.conn);
            db.conn.Open();
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbHeDaoTao.DisplayMember = "TenHeDaoTao";
            cbbHeDaoTao.DataSource = dt;
        }

        private void UCThemTimeLine_Load(object sender, EventArgs e)
        {
            LoadCbb();
        }


        private void pnlContainer_Click(object sender, EventArgs e)
        {
            LoadCbb();

        }

        private void UCThemTimeLine_Click(object sender, EventArgs e)
        {
            LoadCbb();

        }
    }
}
