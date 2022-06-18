
namespace UI
{
    partial class FormDangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlE = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lbx = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ucDangKi1 = new UI.UCDangKi();
            this.ucDangNhap1 = new UI.UCDangNhap();
            this.pnlContainer.SuspendLayout();
            this.pnlE.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContainer.Controls.Add(this.pnlE);
            this.pnlContainer.Controls.Add(this.lbx);
            this.pnlContainer.Controls.Add(this.ucDangKi1);
            this.pnlContainer.Controls.Add(this.ucDangNhap1);
            this.pnlContainer.Location = new System.Drawing.Point(140, 77);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(598, 463);
            this.pnlContainer.TabIndex = 4;
            // 
            // pnlE
            // 
            this.pnlE.Controls.Add(this.btnExit);
            this.pnlE.Location = new System.Drawing.Point(0, 400);
            this.pnlE.Name = "pnlE";
            this.pnlE.Size = new System.Drawing.Size(308, 60);
            this.pnlE.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnExit.ForeColor = System.Drawing.Color.Gray;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(308, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "CLOSE";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbx
            // 
            this.lbx.AutoSize = false;
            this.lbx.BackColor = System.Drawing.Color.Transparent;
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.ForeColor = System.Drawing.Color.Red;
            this.lbx.Location = new System.Drawing.Point(56, 364);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(175, 30);
            this.lbx.TabIndex = 9;
            this.lbx.Text = "Register";
            this.lbx.Click += new System.EventHandler(this.lbx_Click);
            // 
            // ucDangKi1
            // 
            this.ucDangKi1.Location = new System.Drawing.Point(56, 3);
            this.ucDangKi1.Name = "ucDangKi1";
            this.ucDangKi1.Size = new System.Drawing.Size(50, 50);
            this.ucDangKi1.TabIndex = 1;
            // 
            // ucDangNhap1
            // 
            this.ucDangNhap1.Location = new System.Drawing.Point(0, 0);
            this.ucDangNhap1.Name = "ucDangNhap1";
            this.ucDangNhap1.Size = new System.Drawing.Size(50, 50);
            this.ucDangNhap1.TabIndex = 0;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 667);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private UCDangNhap ucDangNhap1;
        private UCDangKi ucDangKi1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbx;
        private Guna.UI2.WinForms.Guna2Panel pnlE;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}