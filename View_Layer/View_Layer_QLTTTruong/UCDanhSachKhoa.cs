using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCDanhSachKhoa : UserControl
    {
        DataTable dtThongTinKhoa = null;
        BLThongTinKhoa dbTTK = new BLThongTinKhoa();
        string err;

        public UCDanhSachKhoa()
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

        private void UCDanhSachKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                dtThongTinKhoa = new DataTable();
                dtThongTinKhoa.Clear();

                DataSet ds = dbTTK.LayThongTinKhoa();
                dtThongTinKhoa = ds.Tables[0];
                dgvDanhSachKhoa.DataSource = dtThongTinKhoa;

                dgvDanhSachKhoa.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Thong Tin Khoa");
            }
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemKhoa1.Dock = DockStyle.Fill;
            ucThemKhoa1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer.BringToFront();
            LoadData();
        }

        /// <summary>
        /// Xóa DS Khoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvDanhSachKhoa.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbTTK.XoaThongTinKhoa(ref err, dr.Cells[1].Value.ToString());
                            LoadData();
                            MessageBox.Show("Done");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Không xóa được!");
                        }
                    }
                }
            }
        }

        private void dgvDanhSachKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvDanhSachKhoa.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvDanhSachKhoa.CurrentCell.EditedFormattedValue);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvDanhSachKhoa.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbTTK.SuaThongTinKhoa(ref err, dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString());
                            LoadData();
                            MessageBox.Show("Done");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Không xóa được!");
                        }
                    }
                }
            }
        }
    }
}
