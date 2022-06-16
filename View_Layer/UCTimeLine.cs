﻿using System;
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
        private bool checkUC = false;

        public UCTimeLine()
        {
            InitializeComponent();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {

        }

        private void UCTimeLine_Load(object sender, EventArgs e)
        {
            try
            {
                dtTimeLine = new DataTable();
                dtTimeLine.Clear();

                DataSet ds = dbTimeLine.LayTimeLine();
                dtTimeLine = ds.Tables[0];
                dgvTimeLine.DataSource = dtTimeLine;

                dgvTimeLine.AutoResizeColumns();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Time Line");
            }
        }

        private void dgvTimeLine_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTimeLine.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvTimeLine.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvTimeLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTimeLine.CurrentRow == null)
                return;
            var x = dgvTimeLine.CurrentCell!=null? dgvTimeLine.CurrentCell.Value.ToString(): "No";
            if (x != "No")
            {
                if (x == "Chỉnh sửa")
                {
                    MessageBox.Show("Chuẩn bị chỉnh sửa");
                    /// Code update
                }
                if (x == "Xóa")
                {
                    MessageBox.Show("Chuẩn bị xóa");
                    /// Code delete
                }
            }
        }
    }
}
