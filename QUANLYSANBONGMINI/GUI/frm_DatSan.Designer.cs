﻿namespace QUANLYSANBONGMINI.GUI
{
    partial class frm_DatSan
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
            this.components = new System.ComponentModel.Container();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoasan = new System.Windows.Forms.Button();
            this.btn_TraSan = new System.Windows.Forms.Button();
            this.dtGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnDatSan = new System.Windows.Forms.Button();
            this.cbbsan = new System.Windows.Forms.ComboBox();
            this.sanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.thueSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.btnSan6 = new System.Windows.Forms.Button();
            this.btnSan5 = new System.Windows.Forms.Button();
            this.btnSan4 = new System.Windows.Forms.Button();
            this.btnSan3 = new System.Windows.Forms.Button();
            this.btnSan2 = new System.Windows.Forms.Button();
            this.btnSan1 = new System.Windows.Forms.Button();
            this.cbbLoaiThue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nbDonGia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dateKT = new System.Windows.Forms.DateTimePicker();
            this.cbbmakh = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_datsan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thueSanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datsan)).BeginInit();
            this.SuspendLayout();
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành Tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btn_Xoasan
            // 
            this.btn_Xoasan.BackColor = System.Drawing.Color.Green;
            this.btn_Xoasan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoasan.ForeColor = System.Drawing.Color.White;
            this.btn_Xoasan.Location = new System.Drawing.Point(400, 317);
            this.btn_Xoasan.Name = "btn_Xoasan";
            this.btn_Xoasan.Size = new System.Drawing.Size(137, 40);
            this.btn_Xoasan.TabIndex = 33;
            this.btn_Xoasan.Text = "XOÁ";
            this.btn_Xoasan.UseVisualStyleBackColor = false;
            this.btn_Xoasan.Click += new System.EventHandler(this.btn_Xoasan_Click);
            // 
            // btn_TraSan
            // 
            this.btn_TraSan.BackColor = System.Drawing.Color.Green;
            this.btn_TraSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraSan.ForeColor = System.Drawing.Color.White;
            this.btn_TraSan.Location = new System.Drawing.Point(204, 317);
            this.btn_TraSan.Name = "btn_TraSan";
            this.btn_TraSan.Size = new System.Drawing.Size(137, 40);
            this.btn_TraSan.TabIndex = 32;
            this.btn_TraSan.Text = "TRẢ SÂN";
            this.btn_TraSan.UseVisualStyleBackColor = false;
            this.btn_TraSan.Click += new System.EventHandler(this.btn_TraSan_Click);
            // 
            // dtGioKetThuc
            // 
            this.dtGioKetThuc.CustomFormat = "HH:mm";
            this.dtGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGioKetThuc.Location = new System.Drawing.Point(400, 165);
            this.dtGioKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtGioKetThuc.Name = "dtGioKetThuc";
            this.dtGioKetThuc.ShowUpDown = true;
            this.dtGioKetThuc.Size = new System.Drawing.Size(75, 22);
            this.dtGioKetThuc.TabIndex = 30;
            // 
            // dtGioBatDau
            // 
            this.dtGioBatDau.CustomFormat = "HH:mm";
            this.dtGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGioBatDau.Location = new System.Drawing.Point(400, 118);
            this.dtGioBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtGioBatDau.Name = "dtGioBatDau";
            this.dtGioBatDau.ShowUpDown = true;
            this.dtGioBatDau.Size = new System.Drawing.Size(75, 22);
            this.dtGioBatDau.TabIndex = 29;
            // 
            // btnDatSan
            // 
            this.btnDatSan.BackColor = System.Drawing.Color.Green;
            this.btnDatSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatSan.ForeColor = System.Drawing.Color.White;
            this.btnDatSan.Location = new System.Drawing.Point(12, 317);
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.Size = new System.Drawing.Size(137, 40);
            this.btnDatSan.TabIndex = 28;
            this.btnDatSan.Text = "ĐẶT SÂN";
            this.btnDatSan.UseVisualStyleBackColor = false;
            this.btnDatSan.Click += new System.EventHandler(this.btnDatSan_Click);
            // 
            // cbbsan
            // 
            this.cbbsan.DataSource = this.sanBindingSource;
            this.cbbsan.DisplayMember = "Ten_San";
            this.cbbsan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbsan.FormattingEnabled = true;
            this.cbbsan.Location = new System.Drawing.Point(169, 20);
            this.cbbsan.Margin = new System.Windows.Forms.Padding(4);
            this.cbbsan.Name = "cbbsan";
            this.cbbsan.Size = new System.Drawing.Size(306, 24);
            this.cbbsan.TabIndex = 5;
            this.cbbsan.ValueMember = "Ma_San";
            this.cbbsan.SelectedIndexChanged += new System.EventHandler(this.cbbsan_SelectedIndexChanged);
            // 
            // dateBD
            // 
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.Location = new System.Drawing.Point(169, 118);
            this.dateBD.Margin = new System.Windows.Forms.Padding(4);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(208, 22);
            this.dateBD.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 165);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Kết thúc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Mã khách hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mã sân:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 740);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.grThongTin);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1368, 711);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đặt sân";
            // 
            // grThongTin
            // 
            this.grThongTin.BackColor = System.Drawing.Color.White;
            this.grThongTin.Controls.Add(this.btnSan6);
            this.grThongTin.Controls.Add(this.btnSan5);
            this.grThongTin.Controls.Add(this.btnSan4);
            this.grThongTin.Controls.Add(this.btnSan3);
            this.grThongTin.Controls.Add(this.btnSan2);
            this.grThongTin.Controls.Add(this.btnSan1);
            this.grThongTin.Controls.Add(this.cbbLoaiThue);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.label3);
            this.grThongTin.Controls.Add(this.label2);
            this.grThongTin.Controls.Add(this.nbDonGia);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Controls.Add(this.dateKT);
            this.grThongTin.Controls.Add(this.cbbmakh);
            this.grThongTin.Controls.Add(this.dgv_datsan);
            this.grThongTin.Controls.Add(this.btn_Xoasan);
            this.grThongTin.Controls.Add(this.btn_TraSan);
            this.grThongTin.Controls.Add(this.dtGioKetThuc);
            this.grThongTin.Controls.Add(this.dtGioBatDau);
            this.grThongTin.Controls.Add(this.btnDatSan);
            this.grThongTin.Controls.Add(this.cbbsan);
            this.grThongTin.Controls.Add(this.dateBD);
            this.grThongTin.Controls.Add(this.label15);
            this.grThongTin.Controls.Add(this.label14);
            this.grThongTin.Controls.Add(this.label13);
            this.grThongTin.Controls.Add(this.label12);
            this.grThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grThongTin.Location = new System.Drawing.Point(4, 4);
            this.grThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grThongTin.Size = new System.Drawing.Size(1360, 703);
            this.grThongTin.TabIndex = 9;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông tin";
            // 
            // btnSan6
            // 
            this.btnSan6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSan6.Image = global::QUANLYSANBONGMINI.Properties.Resources.sanbong11;
            this.btnSan6.Location = new System.Drawing.Point(1204, 174);
            this.btnSan6.Name = "btnSan6";
            this.btnSan6.Size = new System.Drawing.Size(139, 119);
            this.btnSan6.TabIndex = 47;
            this.btnSan6.Text = "SÂN 6";
            this.btnSan6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSan6.UseVisualStyleBackColor = true;
            // 
            // btnSan5
            // 
            this.btnSan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSan5.Image = global::QUANLYSANBONGMINI.Properties.Resources.sanbong11;
            this.btnSan5.Location = new System.Drawing.Point(1008, 174);
            this.btnSan5.Name = "btnSan5";
            this.btnSan5.Size = new System.Drawing.Size(139, 119);
            this.btnSan5.TabIndex = 47;
            this.btnSan5.Text = "SÂN 5";
            this.btnSan5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSan5.UseVisualStyleBackColor = true;
            // 
            // btnSan4
            // 
            this.btnSan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSan4.Image = global::QUANLYSANBONGMINI.Properties.Resources.sanbong11;
            this.btnSan4.Location = new System.Drawing.Point(822, 174);
            this.btnSan4.Name = "btnSan4";
            this.btnSan4.Size = new System.Drawing.Size(139, 119);
            this.btnSan4.TabIndex = 47;
            this.btnSan4.Text = "SÂN 4";
            this.btnSan4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSan4.UseVisualStyleBackColor = true;
            // 
            // btnSan3
            // 
            this.btnSan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSan3.Image = global::QUANLYSANBONGMINI.Properties.Resources.sanbong11;
            this.btnSan3.Location = new System.Drawing.Point(1204, 22);
            this.btnSan3.Name = "btnSan3";
            this.btnSan3.Size = new System.Drawing.Size(139, 119);
            this.btnSan3.TabIndex = 47;
            this.btnSan3.Text = "SÂN 3";
            this.btnSan3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSan3.UseVisualStyleBackColor = true;
            // 
            // btnSan2
            // 
            this.btnSan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSan2.Image = global::QUANLYSANBONGMINI.Properties.Resources.sanbong11;
            this.btnSan2.Location = new System.Drawing.Point(1008, 20);
            this.btnSan2.Name = "btnSan2";
            this.btnSan2.Size = new System.Drawing.Size(139, 119);
            this.btnSan2.TabIndex = 47;
            this.btnSan2.Text = "SÂN 2";
            this.btnSan2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSan2.UseVisualStyleBackColor = true;
            // 
            // btnSan1
            // 
            this.btnSan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSan1.Image = global::QUANLYSANBONGMINI.Properties.Resources.sanbong11;
            this.btnSan1.Location = new System.Drawing.Point(822, 22);
            this.btnSan1.Name = "btnSan1";
            this.btnSan1.Size = new System.Drawing.Size(139, 119);
            this.btnSan1.TabIndex = 47;
            this.btnSan1.Text = "SÂN 1";
            this.btnSan1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSan1.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiThue
            // 
            this.cbbLoaiThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiThue.FormattingEnabled = true;
            this.cbbLoaiThue.Items.AddRange(new object[] {
            "Trực tiếp",
            "Đặt trước"});
            this.cbbLoaiThue.Location = new System.Drawing.Point(164, 207);
            this.cbbLoaiThue.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiThue.Name = "cbbLoaiThue";
            this.cbbLoaiThue.Size = new System.Drawing.Size(311, 24);
            this.cbbLoaiThue.TabIndex = 45;
            this.cbbLoaiThue.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiThue_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 42;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Loại thuê:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "(VNĐ / giờ)";
            // 
            // nbDonGia
            // 
            this.nbDonGia.Location = new System.Drawing.Point(169, 255);
            this.nbDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.nbDonGia.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nbDonGia.Name = "nbDonGia";
            this.nbDonGia.Size = new System.Drawing.Size(160, 22);
            this.nbDonGia.TabIndex = 38;
            this.nbDonGia.ThousandsSeparator = true;
            this.nbDonGia.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Đơn giá";
            // 
            // dateKT
            // 
            this.dateKT.CustomFormat = "dd/MM/yyyy";
            this.dateKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT.Location = new System.Drawing.Point(169, 165);
            this.dateKT.Margin = new System.Windows.Forms.Padding(4);
            this.dateKT.Name = "dateKT";
            this.dateKT.Size = new System.Drawing.Size(208, 22);
            this.dateKT.TabIndex = 36;
            // 
            // cbbmakh
            // 
            this.cbbmakh.DataSource = this.khachHangBindingSource;
            this.cbbmakh.DisplayMember = "Ten_KhachHang";
            this.cbbmakh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmakh.FormattingEnabled = true;
            this.cbbmakh.Location = new System.Drawing.Point(169, 66);
            this.cbbmakh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbmakh.Name = "cbbmakh";
            this.cbbmakh.Size = new System.Drawing.Size(306, 24);
            this.cbbmakh.TabIndex = 35;
            this.cbbmakh.ValueMember = "Ma_KhachHang";
            // 
            // dgv_datsan
            // 
            this.dgv_datsan.AllowUserToAddRows = false;
            this.dgv_datsan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_datsan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datsan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datsan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_datsan.Location = new System.Drawing.Point(8, 375);
            this.dgv_datsan.Name = "dgv_datsan";
            this.dgv_datsan.ReadOnly = true;
            this.dgv_datsan.RowHeadersWidth = 51;
            this.dgv_datsan.RowTemplate.Height = 24;
            this.dgv_datsan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datsan.Size = new System.Drawing.Size(1335, 324);
            this.dgv_datsan.TabIndex = 34;
            this.dgv_datsan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datsan_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sân";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thời gian bắt đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thời gian kết thúc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Loại thuế";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 118);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Bắt đầu:";
            // 
            // frm_DatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 740);
            this.Controls.Add(this.tabControl1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frm_DatSan";
            this.Text = "ĐẶT SÂN/ TRẢ SÂN";
            this.Load += new System.EventHandler(this.frm_DatSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thueSanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datsan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_Xoasan;
        private System.Windows.Forms.Button btn_TraSan;
        private System.Windows.Forms.DateTimePicker dtGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtGioBatDau;
        private System.Windows.Forms.Button btnDatSan;
        private System.Windows.Forms.ComboBox cbbsan;
        private System.Windows.Forms.BindingSource sanBindingSource;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource thueSanBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.ComboBox cbbLoaiThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateKT;
        private System.Windows.Forms.ComboBox cbbmakh;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.DataGridView dgv_datsan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSan1;
        private System.Windows.Forms.Button btnSan6;
        private System.Windows.Forms.Button btnSan5;
        private System.Windows.Forms.Button btnSan4;
        private System.Windows.Forms.Button btnSan3;
        private System.Windows.Forms.Button btnSan2;
    }
}