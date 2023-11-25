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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.lblxinchao = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnlogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(333, 55);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1075, 688);
            this.panelDesktopPane.TabIndex = 20;
            // 
            // lblxinchao
            // 
            this.lblxinchao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxinchao.AutoSize = true;
            this.lblxinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxinchao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblxinchao.Location = new System.Drawing.Point(78, 129);
            this.lblxinchao.Name = "lblxinchao";
            this.lblxinchao.Size = new System.Drawing.Size(73, 18);
            this.lblxinchao.TabIndex = 21;
            this.lblxinchao.Text = "Lời chào";
            this.lblxinchao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(4, 676);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(158, 55);
            this.btnDangXuat.TabIndex = 16;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(524, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "SÂN BÓNG 101";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(333, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1075, 55);
            this.panelTitleBar.TabIndex = 19;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.lblxinchao);
            this.panelMenu.Controls.Add(this.btnlogo);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(333, 743);
            this.panelMenu.TabIndex = 18;
            // 
            // btnlogo
            // 
            this.btnlogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogo.Image = global::QUANLYSANBONGMINI.Properties.Resources.anh_bong_da_tren_san_co_105531274;
            this.btnlogo.Location = new System.Drawing.Point(4, 7);
            this.btnlogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogo.Name = "btnlogo";
            this.btnlogo.Size = new System.Drawing.Size(329, 94);
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
            this.ClientSize = new System.Drawing.Size(1408, 743);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frm_TrangChu";
            this.Text = "frm_trangchu";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label lblxinchao;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnlogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}