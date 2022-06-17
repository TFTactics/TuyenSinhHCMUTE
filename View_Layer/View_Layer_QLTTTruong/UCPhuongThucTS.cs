using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCPhuongThucTS : UserControl
    {
        DataTable dtPhuongThucTuyenSinh = null;
        BLPhuongThucXetTuyen dbPhuongThucXetTuyen = new BLPhuongThucXetTuyen();
        string err = "";

        public UCPhuongThucTS()
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
        private void UCPhuongThucTS_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dtPhuongThucTuyenSinh = new DataTable();
                dtPhuongThucTuyenSinh.Clear();

                DataSet ds = dbPhuongThucXetTuyen.LayPhuongThucXetTuyen();
                dtPhuongThucTuyenSinh = ds.Tables[0];
                dgvPhuongThucTS.DataSource = dtPhuongThucTuyenSinh;

                dgvPhuongThucTS.AutoResizeColumns();
                HideBtn(true);
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Phuong thuc xet tuyen");
            }
        }    
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemPTXT1.Dock = DockStyle.Fill;
            ucThemPTXT1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer.BringToFront();
            LoadData();
        }

        private void dgvPhuongThucTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvPhuongThucTS.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvPhuongThucTS.CurrentCell.EditedFormattedValue);
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
        /// Xóa TimeLine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvPhuongThucTS.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbPhuongThucXetTuyen.XoaPhuongThucXetTuyen(ref err, dr.Cells[2].Value.ToString());
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
            foreach (DataGridViewRow dr in dgvPhuongThucTS.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbPhuongThucXetTuyen.SuaPhuongThuc(ref err,dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(),Convert.ToDateTime(dr.Cells[4].Value.ToString()),Convert.ToDateTime(dr.Cells[5].Value.ToString()), dr.Cells[6].Value.ToString(), dr.Cells[7].Value.ToString(), dr.Cells[8].Value.ToString());
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
