namespace QUANLYSANBONGMINI.GUI
{
    partial class frm_TrangChu
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
            this.lblxinchao = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnQuanLyKinhDoanh = new System.Windows.Forms.Button();
            this.btnQuanLySan = new System.Windows.Forms.Button();
            this.btnDatSan = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnlogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxinchao
            // 
            this.lblxinchao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxinchao.AutoSize = true;
            this.lblxinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxinchao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblxinchao.Location = new System.Drawing.Point(71, 126);
            this.lblxinchao.Name = "lblxinchao";
            this.lblxinchao.Size = new System.Drawing.Size(73, 18);
            this.lblxinchao.TabIndex = 21;
            this.lblxinchao.Text = "Lời chào";
            this.lblxinchao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(26, 676);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(158, 55);
            this.btnDangXuat.TabIndex = 16;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(667, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "CLB SÂN BÓNG 101";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(411, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(997, 55);
            this.panelTitleBar.TabIndex = 19;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.panelMenu.Controls.Add(this.btnQuanLyKinhDoanh);
            this.panelMenu.Controls.Add(this.btnQuanLySan);
            this.panelMenu.Controls.Add(this.btnDatSan);
            this.panelMenu.Controls.Add(this.btnHeThong);
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.lblxinchao);
            this.panelMenu.Controls.Add(this.btnlogo);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(411, 743);
            this.panelMenu.TabIndex = 18;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackgroundImage = global::QUANLYSANBONGMINI.Properties.Resources._01;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(411, 55);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(997, 688);
            this.panelDesktopPane.TabIndex = 20;
            // 
            // btnQuanLyKinhDoanh
            // 
            this.btnQuanLyKinhDoanh.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKinhDoanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnQuanLyKinhDoanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKinhDoanh.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKinhDoanh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKinhDoanh.Image = global::QUANLYSANBONGMINI.Properties.Resources.expensive_price_40px;
            this.btnQuanLyKinhDoanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKinhDoanh.Location = new System.Drawing.Point(0, 414);
            this.btnQuanLyKinhDoanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyKinhDoanh.Name = "btnQuanLyKinhDoanh";
            this.btnQuanLyKinhDoanh.Size = new System.Drawing.Size(409, 63);
            this.btnQuanLyKinhDoanh.TabIndex = 26;
            this.btnQuanLyKinhDoanh.Text = "Quản Lý Khách Hàng/Hóa Đơn";
            this.btnQuanLyKinhDoanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyKinhDoanh.UseVisualStyleBackColor = true;
            this.btnQuanLyKinhDoanh.Click += new System.EventHandler(this.btnQuanLyKinhDoanh_Click);
            // 
            // btnQuanLySan
            // 
            this.btnQuanLySan.FlatAppearance.BorderSize = 0;
            this.btnQuanLySan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnQuanLySan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySan.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySan.Image = global::QUANLYSANBONGMINI.Properties.Resources.goal_net_48px;
            this.btnQuanLySan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySan.Location = new System.Drawing.Point(0, 332);
            this.btnQuanLySan.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLySan.Name = "btnQuanLySan";
            this.btnQuanLySan.Size = new System.Drawing.Size(409, 74);
            this.btnQuanLySan.TabIndex = 25;
            this.btnQuanLySan.Text = "Quản Lý Sân Bóng";
            this.btnQuanLySan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLySan.UseVisualStyleBackColor = true;
            this.btnQuanLySan.Click += new System.EventHandler(this.btnQuanLySan_Click);
            // 
            // btnDatSan
            // 
            this.btnDatSan.FlatAppearance.BorderSize = 0;
            this.btnDatSan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDatSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatSan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatSan.ForeColor = System.Drawing.Color.White;
            this.btnDatSan.Image = global::QUANLYSANBONGMINI.Properties.Resources.soccer_ball_48px;
            this.btnDatSan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatSan.Location = new System.Drawing.Point(0, 259);
            this.btnDatSan.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.Size = new System.Drawing.Size(409, 65);
            this.btnDatSan.TabIndex = 24;
            this.btnDatSan.Text = "Đặt Sân/Trả Sân";
            this.btnDatSan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatSan.UseVisualStyleBackColor = true;
            this.btnDatSan.Click += new System.EventHandler(this.btnDatSan_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Image = global::QUANLYSANBONGMINI.Properties.Resources.gear_48px;
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.Location = new System.Drawing.Point(0, 181);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(409, 70);
            this.btnHeThong.TabIndex = 23;
            this.btnHeThong.Text = "Quản Lý Tài Khoản";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnlogo
            // 
            this.btnlogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogo.Image = global::QUANLYSANBONGMINI.Properties.Resources.images1;
            this.btnlogo.Location = new System.Drawing.Point(-5, 0);
            this.btnlogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogo.Name = "btnlogo";
            this.btnlogo.Size = new System.Drawing.Size(431, 104);
            this.btnlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogo.TabIndex = 0;
            this.btnlogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QUANLYSANBONGMINI.Properties.Resources.boss_man_128;
            this.pictureBox2.Location = new System.Drawing.Point(11, 112);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1408, 743);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frm_TrangChu";
            this.Text = "TRANG CHỦ";
            this.Load += new System.EventHandler(this.frm_TrangChu_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblxinchao;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnlogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnQuanLyKinhDoanh;
        private System.Windows.Forms.Button btnQuanLySan;
        private System.Windows.Forms.Button btnDatSan;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}