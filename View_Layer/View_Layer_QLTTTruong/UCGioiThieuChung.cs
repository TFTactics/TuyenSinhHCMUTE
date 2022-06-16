using System.Windows.Forms;
using System;

namespace UI.View_Layer
{
    public partial class UCGioiThieuChung : UserControl
    {
        BS_Layer.BLThongTinTruong blTT = new BS_Layer.BLThongTinTruong();
        string err;
        public UCGioiThieuChung()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            blTT.SuaBangTin(guna2TextBox1.Text, Convert.ToInt32(txtGS.Text.Trim()),
                Convert.ToInt32(txtPGS.Text.Trim()), Convert.ToInt32(txtTSTS.Text.Trim()), 
                Convert.ToInt32(txtNganhTS.Text.Trim()), 
                Convert.ToInt32(txtNganhThacSi.Text.Trim()), Convert.ToInt32(txtNganhCN.Text.Trim()), 
                txtVideoGT.Text, ref err);
            MessageBox.Show("Done!!");
        }

        private void UCGioiThieuChung_Load(object sender, EventArgs e)
        {
            string GTC = "", vid = "";
            int SGS = 0, PGS = 0, TSTS = 0, NTS = 0, NS = 0, CN = 0;
            blTT.LayDuLieu(ref GTC,ref SGS,ref PGS, ref TSTS, ref NTS, ref NS, ref CN, ref vid);
            guna2TextBox1.Text = GTC;
            txtGS.Text = SGS.ToString();
            txtPGS.Text = PGS.ToString();
            txtTSTS.Text = TSTS.ToString();
            txtNganhThacSi.Text = NTS.ToString();
            txtNganhTS.Text = NS.ToString();
            txtNganhCN.Text = CN.ToString();
            txtVideoGT.Text = vid;
        }
    }
}