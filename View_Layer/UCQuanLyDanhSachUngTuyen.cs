using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCQuanLyDanhSachUngTuyen : UserControl
    {
        DataTable dtDanhSachUngTuyen = null;
        BLDanhSachUngTuyen dbDSUT = new BLDanhSachUngTuyen();
        string err = "";
        public UCQuanLyDanhSachUngTuyen()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                dtDanhSachUngTuyen = new DataTable();
                dtDanhSachUngTuyen.Clear();

                DataSet ds = dbDSUT.LayDanhSachUngTuyen();
                dtDanhSachUngTuyen = ds.Tables[0];
                dgvDSUngTuyen.DataSource = dtDanhSachUngTuyen;

                dgvDSUngTuyen.AutoResizeColumns();
                HideBtn(true);
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Danh Sach Ung Tuyen");
            }
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
        private void btnHome_Click(object sender, System.EventArgs e)
        {
            pnlContainer1.BringToFront();
            LoadData();
        }

        private void btnAddEvent_Click(object sender, System.EventArgs e)
        {
            ucThemUngTuyen1.BringToFront();
            ucThemUngTuyen1.Dock = DockStyle.Fill;
        }

        private void UCQuanLyDanhSachUngTuyen_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void dgvDSUngTuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvDSUngTuyen.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvDSUngTuyen.CurrentCell.EditedFormattedValue);
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
            foreach (DataGridViewRow dr in dgvDSUngTuyen.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbDSUT.XoaDanhSachUngTuyen(ref err, dr.Cells[2].Value.ToString());
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
            foreach (DataGridViewRow dr in dgvDSUngTuyen.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbDSUT.SuaDanhSachUngTuyen(ref err, dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(),
                            Convert.ToInt32(dr.Cells[4].Value.ToString()),Convert.ToInt32(dr.Cells[5].Value.ToString()), dr.Cells[6].Value.ToString(), dr.Cells[7].Value.ToString());
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
