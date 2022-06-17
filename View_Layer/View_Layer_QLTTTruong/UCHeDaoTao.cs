using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCHeDaoTao : UserControl
    {
        DataTable dtHeDaoTao = null;
        BLHeDaoTao dbHeDaoTao = new BLHeDaoTao();
        string err;

        public UCHeDaoTao()
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

        private void UCHeDaoTao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                dtHeDaoTao = new DataTable();
                dtHeDaoTao.Clear();

                DataSet ds = dbHeDaoTao.LayHeDaoTao();
                dtHeDaoTao = ds.Tables[0];
                dgvCTDaoTao.DataSource = dtHeDaoTao;

                dgvCTDaoTao.AutoResizeColumns();
                HideBtn(true);
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }    

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemHDaoTao1.Dock = DockStyle.Fill;
            ucThemHDaoTao1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer.BringToFront();
            LoadData();
        }

        private void dgvCTDaoTao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvCTDaoTao.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvCTDaoTao.CurrentCell.EditedFormattedValue);
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
        /// Xóa Hệ Đào Tạo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvCTDaoTao.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbHeDaoTao.XoaHeDaoTao(ref err, dr.Cells[1].Value.ToString());
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
            foreach (DataGridViewRow dr in dgvCTDaoTao.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            dbHeDaoTao.SuaHeDaoTao(ref err, dr.Cells[1].Value.ToString(),
                                dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString());
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
