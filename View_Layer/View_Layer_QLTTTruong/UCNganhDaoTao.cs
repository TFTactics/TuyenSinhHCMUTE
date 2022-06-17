using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCNganhDaoTao : UserControl
    {
        DataTable dtNganhDT = null;
        BLNganhDaoTao dbNganhDT = new BLNganhDaoTao();
        string err;
        public UCNganhDaoTao()
        {
            InitializeComponent();
            LoadCombobox();
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
        private void btnAddEvent_Click(object sender, System.EventArgs e)
        {
            ucnDaoTao1.Dock = DockStyle.Fill;
            ucnDaoTao1.BringToFront();
            ucnDaoTao1.Visible = true;
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            ucnDaoTao1.Visible = false;
            LoadData();
        }

        private void UCNganhDaoTao_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dtNganhDT= new DataTable();
                dtNganhDT.Clear();

                DataSet ds = dbNganhDT.LayThongTin();
                dtNganhDT = ds.Tables[0];
                dgvDSNganh.DataSource = dtNganhDT;

                dgvDSNganh.AutoResizeColumns();
                HideBtn(true);
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }

        private void dgvDSNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvDSNganh.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvDSNganh.CurrentCell.EditedFormattedValue);
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
            foreach (DataGridViewRow dr in dgvDSNganh.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbNganhDT.XoaNganh(ref err, dr.Cells[1].Value.ToString());
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
            foreach (DataGridViewRow dr in dgvDSNganh.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbNganhDT.SuaNganh(ref err, dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(),
                                dr.Cells[3].Value.ToString(), dr.Cells[4].Value.ToString(), Convert.ToInt32(dr.Cells[5].Value.ToString()),
                                Convert.ToInt32(dr.Cells[6].Value.ToString()), dr.Cells[7].Value.ToString());
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

        public void Search()
        {
            if (txtSearch.Text != "")
            {
                DataSet ds = dbNganhDT.SearchNganh(txtSearch.Text);
                dtNganhDT = new DataTable();
                dtNganhDT.Clear();
                dtNganhDT = ds.Tables[0];
                dgvDSNganh.DataSource = dtNganhDT;
                dgvDSNganh.AutoResizeColumns();
                HideBtn(true);
            }
            else LoadData();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        public void LoadCombobox()
        {
            BS_Layer.BLChuongTrinhDaoTao dbCTDT = new BLChuongTrinhDaoTao();
            DataTable dt = dbCTDT.LayTenChuongTrinh();

            DataRow row = dt.NewRow();
            row["TenChuongTrinh"] = "Tất cả";
            dt.Rows.Add(row);

            cbbLoaiCT.DisplayMember = "TenChuongTrinh";
            cbbLoaiCT.DataSource = dt;
            cbbLoaiCT.Text = "Tất cả";
            
        }


        private void cbbLoaiCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiCT.Text == "Tất cả")
                LoadData();
            else
            {
                dtNganhDT = new DataTable();
                dtNganhDT.Clear();
                DataSet ds = dbNganhDT.LocLoaiCT(cbbLoaiCT.Text);
                dtNganhDT = ds.Tables[0];
                dgvDSNganh.DataSource = dtNganhDT;
                dgvDSNganh.AutoResizeColumns();
                HideBtn(true);
            }
        }
    }
}
