using System.Windows.Forms;
using System.Data.SqlClient;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCHocPhiHocBong : UserControl
    {
        BLHocPhiHocBong dbHPHB=new BLHocPhiHocBong();
        string err;
        public UCHocPhiHocBong()
        {
            InitializeComponent();
        }


        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            try
            {
                dbHPHB.SuaThongTin(txtNoiDung.Text, ref err);
                MessageBox.Show("Done");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Chỉnh sửa thất bại.");
            }
        }

        private void UCHocPhiHocBong_Load(object sender, System.EventArgs e)
        {
            string Content = "";
            dbHPHB.LayDuLieu(ref Content);
            txtNoiDung.Text = Content;
        }
    }
}
