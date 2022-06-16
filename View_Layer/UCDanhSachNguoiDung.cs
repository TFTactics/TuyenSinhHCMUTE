using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCDanhSachNguoiDung : UserControl
    {
        DataTable dtDanhSachNguoiDung = null;
        BLThongTinNguoiDung dbThongTinNguoiDung = new BLThongTinNguoiDung();

        public UCDanhSachNguoiDung()
        {
            InitializeComponent();
            HideBtn(true);
            
        }

        public void HideBtn(bool flag)
        {
            if (flag)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
        }

        public void LoadData()
        {
            try
            {
                dtDanhSachNguoiDung = new DataTable();
                dtDanhSachNguoiDung.Clear();

                DataSet ds = dbThongTinNguoiDung.LayThongTinNguoiDung();
                dtDanhSachNguoiDung = ds.Tables[0];
                dgvThongTinNguoiDung.DataSource = dtDanhSachNguoiDung;

                dgvThongTinNguoiDung.AutoResizeColumns();
                HideBtn(true);
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }
        private void UCDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucThemNguoiDung1.SendToBack();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucThemNguoiDung1.BringToFront();
            ucThemNguoiDung1.Dock = DockStyle.Fill;
        }

        private void dgvThongTinNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvThongTinNguoiDung.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvThongTinNguoiDung.CurrentCell.EditedFormattedValue);
                //checkBoxStatus gives you whether checkbox cell value of selected row for the
                //"CheckBoxColumn" column value is checked or not. 
                if (checkBoxStatus)
                {
                    //write your code
                    HideBtn(!checkBoxStatus);
                }
                else
                {
                    //write your code
                    HideBtn(!checkBoxStatus);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvThongTinNguoiDung.Rows)
            {
                if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                {
                    // dbThongTinNguoiDung.XoaBangTin(ref err, dr.Cells[1].Value.ToString(), dr.Cells[5].Value.ToString(), dr.Cells[2].Value.ToString());
                    LoadData();
                }

            }
        }
    }
}
