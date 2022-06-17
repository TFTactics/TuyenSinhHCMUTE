using System.Windows.Forms;
using System.Data.SqlClient;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCLienHe : UserControl
    {
        BLLienHe dbLienHe = new BLLienHe();
        string err;
        public UCLienHe()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            try
            {
                dbLienHe.SuaLienHe(txtDDLienHe.Text,txtSDT.Text, txtEmail.Text, txtFanpage.Text,txtTenPhongBanLH.Text,txtVanPhong.Text, ref err);
                MessageBox.Show("Done");
            }
            catch
            {
                MessageBox.Show("Chỉnh sửa thất bại.");
            }
        }

        private void UCLienHe_Load(object sender, System.EventArgs e)
        {
            string DD = "", SDT = "", Email = "", Fanpage = "", TenPB = "", VanPhong = "";
            dbLienHe.LayDuLieu(ref DD, ref SDT, ref Email, ref Fanpage, ref TenPB, ref VanPhong);
            txtDDLienHe.Text = DD;
            txtSDT.Text = SDT;
            txtEmail.Text = Email;
            txtFanpage.Text = Fanpage;
            txtTenPhongBanLH.Text = TenPB;
            txtVanPhong.Text= VanPhong;
        }
    }
}
