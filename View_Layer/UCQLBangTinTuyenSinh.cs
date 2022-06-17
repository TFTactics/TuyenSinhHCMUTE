using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCQLBangTinTuyenSinh : UserControl
    {
        DataTable dtTinTuyenSinh = null;
        BLBangTinTuyenSinh dbTinTuyyenSinh = new BLBangTinTuyenSinh();
        string err;
        private bool checkUC = false;
        public UCQLBangTinTuyenSinh()
        {
            InitializeComponent();
            ButtonBack();
            HideBtn(true);
        }
        public void HideBtn(bool flag)
        {
            if(flag)
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
            else
            {
                btnDelete.Visible = true;
                btnEdit.Visible = true;
            }
        }

        private void ButtonBack()
        {
            if (checkUC)
                btnBack.Visible = true;
            else btnBack.Visible = false;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            UPDATE();   
        }

        private void UPDATE()
        {
            checkUC = true;
            ucThemTin1.BringToFront();
            ucThemTin1.Dock = DockStyle.Fill;
            pnlBanTinTuyenSinh.Visible = false;
            btnBack.BringToFront();
            ButtonBack();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            checkUC = false;
            pnlBanTinTuyenSinh.Visible = true;
            btnBack.BringToFront();
            ucThemTin1.SendToBack();
            ButtonBack();
            LoadData();
        }

        private void UCQLBangTinTuyenSinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtTinTuyenSinh = new DataTable();
                dtTinTuyenSinh.Clear();

                DataSet ds = dbTinTuyyenSinh.LayBangTin();
                dtTinTuyenSinh = ds.Tables[0];
                dgvTinTuyenSinh.DataSource = dtTinTuyenSinh;

                dgvTinTuyenSinh.AutoResizeColumns();
                HideBtn(true);
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong TinTuyenSinh");
            }
        }

        private void dgvTinTuyenSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvTinTuyenSinh.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvTinTuyenSinh.CurrentCell.EditedFormattedValue);
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
        /// <summary>
        /// Xóa Bảng Tin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvTinTuyenSinh.Rows[0].Cells[0].Value.ToString());
            foreach (DataGridViewRow dr in dgvTinTuyenSinh.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if(Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbTinTuyyenSinh.XoaBangTin(ref err, dr.Cells[1].Value.ToString());
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvTinTuyenSinh.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbTinTuyyenSinh.SuaTin(ref err, dr.Cells[1].Value.ToString(),
                                dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(),
                                dr.Cells[4].Value.ToString());
                            LoadData();
                            MessageBox.Show("Done!!");
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
