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
    public partial class Form1 : Form
    {
        public bool mode = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void DarkMode_Click(object sender, EventArgs e)
        {
            if (mode)
            {
                DarkMode.BackgroundImage = Properties.Resources.lamp;
                mode = false;
            }
            else
            {
                DarkMode.BackgroundImage = Properties.Resources.LightMode;
                mode = true;
            }
        }
    }
}
