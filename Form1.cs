using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.View_Layer;

namespace UI
{
    public partial class Form1 : Form
    {
        public bool mode = true;
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }    
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }
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
        #region UserControl

        /// <summary>
        /// Load Trang Chủ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            UCHome uch = new UCHome();
            pnlContainer.Controls.Add(uch);

        }
        /// <summary>
        /// Mở menu TimeLine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimeLine_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCTimeLine"))
            {
                UCTimeLine uctl = new UCTimeLine();
                uctl.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(uctl);
            }
            Form1.Instance.PnlContainer.Controls["UCTimeLine"].BringToFront();
        }

        /// <summary>
        /// Quản lí menu Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCHome"))
            {
                UCHome uc = new UCHome();
                uc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(uc);
            }
            Form1.Instance.PnlContainer.Controls["UCHome"].BringToFront();
        }

        /// <summary>
        /// Mở menu Quản lí danh sách ứng tuyển
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQLDSUngTuyen_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQuanLyDanhSachUngTuyen"))
            {
                UCQuanLyDanhSachUngTuyen ucql = new UCQuanLyDanhSachUngTuyen();
                ucql.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ucql);
            }
            Form1.Instance.PnlContainer.Controls["UCQuanLyDanhSachUngTuyen"].BringToFront();
        }

        private void btnDSNguoiDung_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCDanhSachNguoiDung"))
            {
                UCDanhSachNguoiDung ucds = new UCDanhSachNguoiDung();
                ucds.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ucds);
            }
            Form1.Instance.PnlContainer.Controls["UCDanhSachNguoiDung"].BringToFront();
        }

        private void btnQLTinTruong_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQLThongTinTruong"))
            {
                UCQLThongTinTruong ucql = new UCQLThongTinTruong();
                ucql.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ucql);
            }
            Form1.Instance.PnlContainer.Controls["UCQLThongTinTruong"].BringToFront();
        }

        private void btnQLTuyenSinh_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQLBangTinTuyenSinh"))
            {
                UCQLBangTinTuyenSinh ucql = new UCQLBangTinTuyenSinh();
                ucql.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ucql);
            }
            Form1.Instance.PnlContainer.Controls["UCQLBangTinTuyenSinh"].BringToFront();
        }
        #endregion
    }

}
