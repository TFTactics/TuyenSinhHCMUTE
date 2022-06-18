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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Form1.SignIn = true;
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            ucDangNhap1.BringToFront();
            ucDangNhap1.Dock=DockStyle.Fill;
            pnlE.BringToFront();
            lbx.Text = "Register";
            lbx.BringToFront();
        }

        private void lbx_Click(object sender, EventArgs e)
        {
            if (lbx.Text == "Register")
            {
                ucDangKi1.BringToFront();
                ucDangKi1.Dock = DockStyle.Fill;
                pnlE.BringToFront();
                lbx.Text = "Login";
                lbx.BringToFront();
            }
            else
            {
                ucDangNhap1.BringToFront();
                ucDangNhap1.Dock = DockStyle.Fill;
                pnlE.BringToFront();
                lbx.Text = "Register";
                lbx.BringToFront();
            }
        }

    }
}
