using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UCDangNhap : UserControl
    {
        public UCDangNhap()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            BS_Layer.BLAdmin ad = new BS_Layer.BLAdmin();
            if (ad.CheckUser(username.Text, password.Text))
            {
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect!!");
        }
    }
}
