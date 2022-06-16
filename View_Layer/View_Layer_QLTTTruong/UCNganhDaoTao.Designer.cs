namespace UI.View_Layer
{
    partial class UCNganhDaoTao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDSNganh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel27 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel9 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbLoaiCT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ucnDaoTao1 = new UI.View_Layer.View_Layer_QLTTTruong.NganhDaoTao.UCNDaoTao();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2CustomGradientPanel9.SuspendLayout();
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
            this.btnAddEvent.Location = new System.Drawing.Point(1005, 57);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(195, 45);
            this.btnAddEvent.TabIndex = 14;
            this.btnAddEvent.Text = "+ Tạo Ngành Mới";
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.ucnDaoTao1);
            this.guna2Panel3.Controls.Add(this.guna2Panel1);
            this.guna2Panel3.Controls.Add(this.guna2CustomGradientPanel9);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 120);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1200, 990);
            this.guna2Panel3.TabIndex = 15;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.dgvDSNganh);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 90);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 12;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2Panel1.Size = new System.Drawing.Size(1200, 900);
            this.guna2Panel1.TabIndex = 14;
            // 
            // dgvDSNganh
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDSNganh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDSNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNganh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSNganh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSNganh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSNganh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNganh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDSNganh.ColumnHeadersHeight = 27;
            this.dgvDSNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choose,
            this.ThaoTac});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNganh.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDSNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNganh.EnableHeadersVisualStyles = false;
            this.dgvDSNganh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNganh.Location = new System.Drawing.Point(0, 75);
            this.dgvDSNganh.Name = "dgvDSNganh";
            this.dgvDSNganh.RowHeadersVisible = false;
            this.dgvDSNganh.RowHeadersWidth = 51;
            this.dgvDSNganh.RowTemplate.Height = 24;
            this.dgvDSNganh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNganh.Size = new System.Drawing.Size(1200, 825);
            this.dgvDSNganh.TabIndex = 1;
            this.dgvDSNganh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNganh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSNganh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSNganh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSNganh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSNganh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNganh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNganh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSNganh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSNganh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSNganh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSNganh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSNganh.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvDSNganh.ThemeStyle.ReadOnly = false;
            this.dgvDSNganh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNganh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSNganh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSNganh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSNganh.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDSNganh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNganh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Choose
            // 
            this.Choose.FillWeight = 37.43316F;
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
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel27);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1200, 75);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2HtmlLabel27
            // 
            this.guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel27.Location = new System.Drawing.Point(819, 57);
            this.guna2HtmlLabel27.Name = "guna2HtmlLabel27";
            this.guna2HtmlLabel27.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel27.TabIndex = 9;
            this.guna2HtmlLabel27.Text = null;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 25);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(803, 40);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Danh sách ngành đào tạo";
            // 
            // guna2CustomGradientPanel9
            // 
            this.guna2CustomGradientPanel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel9.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel9.BorderRadius = 15;
            this.guna2CustomGradientPanel9.BorderThickness = 1;
            this.guna2CustomGradientPanel9.Controls.Add(this.txbSearch);
            this.guna2CustomGradientPanel9.Controls.Add(this.cbbLoaiCT);
            this.guna2CustomGradientPanel9.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel9.Name = "guna2CustomGradientPanel9";
            this.guna2CustomGradientPanel9.Size = new System.Drawing.Size(1200, 70);
            this.guna2CustomGradientPanel9.TabIndex = 15;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderRadius = 5;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.IconLeft = global::UI.Properties.Resources.icons8_magnifying_glass_64;
            this.txbSearch.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txbSearch.Location = new System.Drawing.Point(15, 10);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(320, 50);
            this.txbSearch.TabIndex = 15;
            // 
            // cbbLoaiCT
            // 
            this.cbbLoaiCT.BackColor = System.Drawing.Color.White;
            this.cbbLoaiCT.BorderColor = System.Drawing.Color.DimGray;
            this.cbbLoaiCT.BorderRadius = 5;
            this.cbbLoaiCT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiCT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiCT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbbLoaiCT.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiCT.ItemHeight = 30;
            this.cbbLoaiCT.Items.AddRange(new object[] {
            "ALL",
            "USER",
            "COLLAB",
            "ADMIN"});
            this.cbbLoaiCT.Location = new System.Drawing.Point(950, 18);
            this.cbbLoaiCT.Name = "cbbLoaiCT";
            this.cbbLoaiCT.Size = new System.Drawing.Size(234, 36);
            this.cbbLoaiCT.TabIndex = 14;
            // 
            // ucnDaoTao1
            // 
            this.ucnDaoTao1.Location = new System.Drawing.Point(0, 996);
            this.ucnDaoTao1.Name = "ucnDaoTao1";
            this.ucnDaoTao1.Size = new System.Drawing.Size(50, 41);
            this.ucnDaoTao1.TabIndex = 16;
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
            this.btnHome.Text = "Quản Lý Ngành Đào Tạo";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // UCNganhDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.btnAddEvent);
            this.Name = "UCNganhDaoTao";
            this.Size = new System.Drawing.Size(1250, 1133);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2CustomGradientPanel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSNganh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choose;
        private System.Windows.Forms.DataGridViewComboBoxColumn ThaoTac;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel27;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel9;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiCT;
        private View_Layer_QLTTTruong.NganhDaoTao.UCNDaoTao ucnDaoTao1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}
