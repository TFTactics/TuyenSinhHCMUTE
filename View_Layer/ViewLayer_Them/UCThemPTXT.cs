using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BD_Layer;

namespace UI.View_Layer.ViewLayer_Them
{
    public partial class UCThemPTXT : UserControl
    {
        string err = "";
        public UCThemPTXT()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BS_Layer.BLPhuongThucXetTuyen bdPTTX = new BS_Layer.BLPhuongThucXetTuyen();
            bdPTTX.ThemPhuongThucXetTuyen(txtTenPT.Text, txtMaPT.Text, cbbHeDaoTao.Text, Convert.ToDateTime(dtTGBatDau.Value.ToString()).Date, Convert.ToDateTime(dtTGKetThuc.Value.ToString()).Date, txtAnh.Text, txtNoiDungPT.Text, cbbPTcha.Text,ref err);
            MessageBox.Show(dtTGBatDau.Value.ToString("yyyy-MM-dd"));
            
        }

        private void UCThemPTXT_Load(object sender, EventArgs e)
        {
            LoadCbb();
        }

        public void LoadCbb()
        {
            // Load database vào combobox
            DBMain db = new DBMain();
            var cmd1 = new SqlCommand("select * from HeDaoTao", db.conn);
            //var cmd2 = new SqlCommand("select * from ThongTinKhoa", db.conn);

            db.conn.Open();
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cbbHeDaoTao.DisplayMember = "TenHeDaoTao";
            cbbHeDaoTao.DataSource = dt1;

            /*var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.DataSource = dt2;*/
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            LoadCbb();

        }

        private void UCThemPTXT_Click(object sender, EventArgs e)
        {
            LoadCbb();

        }
    }
}
