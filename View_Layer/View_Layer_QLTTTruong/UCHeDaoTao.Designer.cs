namespace UI.View_Layer
{
    partial class UCHeDaoTao
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCTDaoTao = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.ucThemHDaoTao1 = new UI.View_Layer.View_Layer_QLTTTruong.HDaoTao.UCThemHDaoTao();
            this.guna2Panel1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDaoTao)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEvent.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddEvent.BorderRadius = 5;
            this.btnAddEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.ForeColor = System.Drawing.Color.White;
            this.btnAddEvent.Location = new System.Drawing.Point(988, 57);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(212, 45);
            this.btnAddEvent.TabIndex = 14;
            this.btnAddEvent.Text = "+ Thêm Hệ Đào Tạo";
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ucThemHDaoTao1);
            this.guna2Panel1.Controls.Add(this.pnlContainer);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 120);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1200, 990);
            this.guna2Panel1.TabIndex = 15;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BorderColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BorderRadius = 15;
            this.pnlContainer.BorderThickness = 1;
            this.pnlContainer.Controls.Add(this.dgvCTDaoTao);
            this.pnlContainer.Controls.Add(this.guna2Panel2);
            this.pnlContainer.FillColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1200, 990);
            this.pnlContainer.TabIndex = 11;
            // 
            // dgvCTDaoTao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCTDaoTao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTDaoTao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTDaoTao.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTDaoTao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTDaoTao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTDaoTao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTDaoTao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTDaoTao.ColumnHeadersHeight = 27;
            this.dgvCTDaoTao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choose,
            this.ThaoTac});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTDaoTao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTDaoTao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDaoTao.EnableHeadersVisualStyles = false;
            this.dgvCTDaoTao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTDaoTao.Location = new System.Drawing.Point(0, 40);
            this.dgvCTDaoTao.Name = "dgvCTDaoTao";
            this.dgvCTDaoTao.RowHeadersVisible = false;
            this.dgvCTDaoTao.RowHeadersWidth = 51;
            this.dgvCTDaoTao.RowTemplate.Height = 24;
            this.dgvCTDaoTao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTDaoTao.Size = new System.Drawing.Size(1200, 950);
            this.dgvCTDaoTao.TabIndex = 16;
            this.dgvCTDaoTao.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTDaoTao.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTDaoTao.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTDaoTao.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTDaoTao.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTDaoTao.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTDaoTao.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTDaoTao.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCTDaoTao.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTDaoTao.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTDaoTao.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTDaoTao.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTDaoTao.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvCTDaoTao.ThemeStyle.ReadOnly = false;
            this.dgvCTDaoTao.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTDaoTao.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTDaoTao.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTDaoTao.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTDaoTao.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCTDaoTao.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTDaoTao.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Choose
            // 
            this.Choose.FillWeight = 27.18325F;
            this.Choose.HeaderText = "";
            this.Choose.MinimumWidth = 6;
            this.Choose.Name = "Choose";
            // 
            // ThaoTac
            // 
            this.ThaoTac.HeaderText = "Thao Tác";
            this.ThaoTac.Items.AddRange(new object[] {
            "Chỉnh sửa",
            "Xóa"});
            this.ThaoTac.MinimumWidth = 6;
            this.ThaoTac.Name = "ThaoTac";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1200, 40);
            this.guna2Panel2.TabIndex = 15;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(803, 40);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Danh sách các hệ đào tạo";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(1, 57);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHome.Size = new System.Drawing.Size(963, 45);
            this.btnHome.TabIndex = 49;
            this.btnHome.Text = "Quản Lý Hệ Đào Tạo";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ucThemHDaoTao1
            // 
            this.ucThemHDaoTao1.Location = new System.Drawing.Point(0, 996);
            this.ucThemHDaoTao1.Name = "ucThemHDaoTao1";
            this.ucThemHDaoTao1.Size = new System.Drawing.Size(50, 50);
            this.ucThemHDaoTao1.TabIndex = 12;
            // 
            // UCHeDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnAddEvent);
            this.Name = "UCHeDaoTao";
            this.Size = new System.Drawing.Size(1250, 1133);
            this.Load += new System.EventHandler(this.UCHeDaoTao_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDaoTao)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCTDaoTao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choose;
        private System.Windows.Forms.DataGridViewComboBoxColumn ThaoTac;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private View_Layer_QLTTTruong.HDaoTao.UCThemHDaoTao ucThemHDaoTao1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}
