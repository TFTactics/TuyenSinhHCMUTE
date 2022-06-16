using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.BS_Layer;
namespace UI.View_Layer
{
    public partial class UCTimeLine : UserControl
    {
        DataTable dtTimeLine = null;
        BLTimeLine dbTimeLine = new BLTimeLine();
        string err = "";
        public UCTimeLine()
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

        private void UCTimeLine_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtTimeLine = new DataTable();
                dtTimeLine.Clear();

                DataSet ds = dbTimeLine.LayTimeLine();
                dtTimeLine = ds.Tables[0];
                dgvTimeLine.DataSource = dtTimeLine;

                dgvTimeLine.AutoResizeColumns();
                HideBtn(true);
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }


        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ucThemTimeLine1.BringToFront();
            ucThemTimeLine1.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucThemTimeLine1.SendToBack();
            LoadData();
        }

        private void dgvTimeLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvTimeLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(dgvTimeLine.CurrentCell.OwningColumn.Name, "STT") == 0)
            {
                bool checkBoxStatus = Convert.ToBoolean(dgvTimeLine.CurrentCell.EditedFormattedValue);
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
            foreach(DataGridViewRow dr in dgvTimeLine.Rows)
            {
                if (Convert.ToBoolean(dr.Cells[0].Value.ToString()))
                {
                    dbTimeLine.XoaBangTin(ref err, dr.Cells[1].Value.ToString(), dr.Cells[5].Value.ToString(), dr.Cells[2].Value.ToString());
                    LoadData();
                }

            }    
        }
    }
}
