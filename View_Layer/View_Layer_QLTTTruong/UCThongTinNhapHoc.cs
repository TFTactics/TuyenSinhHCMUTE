using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;

namespace UI.View_Layer
{
    public partial class UCThongTinNhapHoc : UserControl
    {
        DataTable dtThongTinNhapHoc = null;
        BLThongTinNhapHoc dbThongTinNhapHoc = new BLThongTinNhapHoc();
        private bool checkUC = false;
        public UCThongTinNhapHoc()
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

        private void UCThongTinNhapHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                dtThongTinNhapHoc = new DataTable();
                dtThongTinNhapHoc.Clear();

                DataSet ds = dbThongTinNhapHoc.LayThongTinNhapHoc();
                dtThongTinNhapHoc = ds.Tables[0];
                dgvTTNhapHoc.DataSource = dtThongTinNhapHoc;

                dgvTTNhapHoc.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Thong Tin Nhap Hoc");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemTTNhapHoc1.BringToFront();
            ucThemTTNhapHoc1.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer.BringToFront();
            LoadData();
        }

        private void dgvTTNhapHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvTTNhapHoc.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvTTNhapHoc.CurrentCell.EditedFormattedValue);
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

        }
    }
}
