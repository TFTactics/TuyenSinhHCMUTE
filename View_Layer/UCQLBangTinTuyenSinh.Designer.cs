namespace UI.View_Layer
{
    partial class UCQLBangTinTuyenSinh
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBanTinTuyenSinh = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTinTuyenSinh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tinTuyenSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucThemTin1 = new UI.View_Layer.View_Layer_QLBangTinTuyenSinh.UCThemTin();
            this.Choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlContainer.SuspendLayout();
            this.pnlBanTinTuyenSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinTuyenSinh)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinTuyenSinhBindingSource)).BeginInit();
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
            this.btnAddEvent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddEvent.ForeColor = System.Drawing.Color.White;
            this.btnAddEvent.Location = new System.Drawing.Point(950, 65);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(180, 45);
            this.btnAddEvent.TabIndex = 4;
            this.btnAddEvent.Text = "THÊM TIN MỚI";
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 72);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(548, 32);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "QUẢN LÝ BẢN TIN TUYỂN SINH";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.ucThemTin1);
            this.pnlContainer.Location = new System.Drawing.Point(20, 132);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1108, 681);
            this.pnlContainer.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnBack.BorderRadius = 5;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1010, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 45);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlBanTinTuyenSinh
            // 
            this.pnlBanTinTuyenSinh.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBanTinTuyenSinh.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBanTinTuyenSinh.BorderRadius = 15;
            this.pnlBanTinTuyenSinh.BorderThickness = 1;
            this.pnlBanTinTuyenSinh.Controls.Add(this.dgvTinTuyenSinh);
            this.pnlBanTinTuyenSinh.Controls.Add(this.guna2Panel2);
            this.pnlBanTinTuyenSinh.CustomBorderColor = System.Drawing.Color.DimGray;
            this.pnlBanTinTuyenSinh.FillColor = System.Drawing.Color.White;
            this.pnlBanTinTuyenSinh.Location = new System.Drawing.Point(20, 132);
            this.pnlBanTinTuyenSinh.Name = "pnlBanTinTuyenSinh";
            this.pnlBanTinTuyenSinh.Size = new System.Drawing.Size(1108, 582);
            this.pnlBanTinTuyenSinh.TabIndex = 6;
            // 
            // dgvTinTuyenSinh
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTinTuyenSinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTinTuyenSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinTuyenSinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvTinTuyenSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTinTuyenSinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTinTuyenSinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTinTuyenSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTinTuyenSinh.ColumnHeadersHeight = 27;
            this.dgvTinTuyenSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choose});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTinTuyenSinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTinTuyenSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTinTuyenSinh.EnableHeadersVisualStyles = false;
            this.dgvTinTuyenSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinTuyenSinh.Location = new System.Drawing.Point(0, 46);
            this.dgvTinTuyenSinh.Name = "dgvTinTuyenSinh";
            this.dgvTinTuyenSinh.RowHeadersVisible = false;
            this.dgvTinTuyenSinh.RowHeadersWidth = 51;
            this.dgvTinTuyenSinh.RowTemplate.Height = 24;
            this.dgvTinTuyenSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTinTuyenSinh.Size = new System.Drawing.Size(1108, 536);
            this.dgvTinTuyenSinh.TabIndex = 7;
            this.dgvTinTuyenSinh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinTuyenSinh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTinTuyenSinh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTinTuyenSinh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTinTuyenSinh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTinTuyenSinh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinTuyenSinh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinTuyenSinh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTinTuyenSinh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTinTuyenSinh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTinTuyenSinh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTinTuyenSinh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTinTuyenSinh.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvTinTuyenSinh.ThemeStyle.ReadOnly = false;
            this.dgvTinTuyenSinh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinTuyenSinh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTinTuyenSinh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTinTuyenSinh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTinTuyenSinh.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTinTuyenSinh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinTuyenSinh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoSize = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1108, 46);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 13);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(803, 30);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Danh sách tin tuyển sinh";
            // 
            // ucThemTin1
            // 
            this.ucThemTin1.Location = new System.Drawing.Point(15, 588);
            this.ucThemTin1.Name = "ucThemTin1";
            this.ucThemTin1.Size = new System.Drawing.Size(50, 50);
            this.ucThemTin1.TabIndex = 0;
            // 
            // Choose
            // 
            this.Choose.FillWeight = 27.18325F;
            this.Choose.HeaderText = "";
            this.Choose.MinimumWidth = 6;
            this.Choose.Name = "Choose";
            // 
            // UCQLBangTinTuyenSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlBanTinTuyenSinh);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.DoubleBuffered = true;
            this.Name = "UCQLBangTinTuyenSinh";
            this.Size = new System.Drawing.Size(1150, 1150);
            this.Load += new System.EventHandler(this.UCQLBangTinTuyenSinh_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlBanTinTuyenSinh.ResumeLayout(false);
            this.pnlBanTinTuyenSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinTuyenSinh)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tinTuyenSinhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlBanTinTuyenSinh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private View_Layer_QLBangTinTuyenSinh.UCThemTin ucThemTin1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTinTuyenSinh;
        private System.Windows.Forms.BindingSource tinTuyenSinhBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choose;
    }
}
