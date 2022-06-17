using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCCTDaoTao : UserControl
    {
        DataTable dtCTDT = null;
        BLChuongTrinhDaoTao dbCTDT = new BLChuongTrinhDaoTao();
        string err;

        public UCCTDaoTao()
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
        private void UCCTDaoTao_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        public void LoadData()
        {
            try
            {
                dtCTDT = new DataTable();
                dtCTDT.Clear();

                DataSet ds = dbCTDT.LayChuongTrinhDaoTao();
                dtCTDT = ds.Tables[0];
                dgvCTDaoTao.DataSource = dtCTDT;

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
            ucThemCTDaoTao1.BringToFront();
            ucThemCTDaoTao1.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer1.BringToFront();
            LoadData();
        }

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
                            dbCTDT.XoaChuongTrinhDaoTao(ref err, dr.Cells[1].Value.ToString());
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
    }
}
