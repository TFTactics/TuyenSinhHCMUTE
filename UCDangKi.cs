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
    public partial class UCDangKi : UserControl
    {
        public string err;

        public UCDangKi()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            BS_Layer.BLAdmin ad = new BS_Layer.BLAdmin();
            if (!ad.Check(username.Text))
            {
                ad.ThemUser(username.Text, password.Text, password2.Text, ref err);
            }
            else if (ad.Check(username.Text))
                MessageBox.Show("Da Co User");
            else
                MessageBox.Show("Incorrect!!");
        }
    }
}
