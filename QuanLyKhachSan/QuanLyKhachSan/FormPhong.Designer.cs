﻿namespace QuanLyKhachSan
{
    partial class FormPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.rbtn_Trong = new System.Windows.Forms.RadioButton();
            this.rbtn_DaThue = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.lb_TinhTrang = new System.Windows.Forms.Label();
            this.lb_ChuThich = new System.Windows.Forms.Label();
            this.lb_GiaPhong = new System.Windows.Forms.Label();
            this.lb_LoaiPhong = new System.Windows.Forms.Label();
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.dgvPHONG = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Trove = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cmb_TimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_LoaiPhong);
            this.panel1.Controls.Add(this.rbtn_Trong);
            this.panel1.Controls.Add(this.rbtn_DaThue);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtGiaPhong);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.lb_MaNV);
            this.panel1.Controls.Add(this.lb_TinhTrang);
            this.panel1.Controls.Add(this.lb_ChuThich);
            this.panel1.Controls.Add(this.lb_GiaPhong);
            this.panel1.Controls.Add(this.lb_LoaiPhong);
            this.panel1.Controls.Add(this.lb_MaPhong);
            this.panel1.Location = new System.Drawing.Point(60, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 117);
            this.panel1.TabIndex = 2;
            // 
            // cmb_LoaiPhong
            // 
            this.cmb_LoaiPhong.FormattingEnabled = true;
            this.cmb_LoaiPhong.Items.AddRange(new object[] {
            "Đôi",
            "Đơn",
            "Cao Cấp"});
            this.cmb_LoaiPhong.Location = new System.Drawing.Point(93, 65);
            this.cmb_LoaiPhong.Name = "cmb_LoaiPhong";
            this.cmb_LoaiPhong.Size = new System.Drawing.Size(152, 24);
            this.cmb_LoaiPhong.TabIndex = 18;
            // 
            // rbtn_Trong
            // 
            this.rbtn_Trong.AutoSize = true;
            this.rbtn_Trong.Location = new System.Drawing.Point(418, 80);
            this.rbtn_Trong.Name = "rbtn_Trong";
            this.rbtn_Trong.Size = new System.Drawing.Size(67, 21);
            this.rbtn_Trong.TabIndex = 17;
            this.rbtn_Trong.TabStop = true;
            this.rbtn_Trong.Text = "Trống";
            this.rbtn_Trong.UseVisualStyleBackColor = true;
            // 
            // rbtn_DaThue
            // 
            this.rbtn_DaThue.AutoSize = true;
            this.rbtn_DaThue.Location = new System.Drawing.Point(302, 80);
            this.rbtn_DaThue.Name = "rbtn_DaThue";
            this.rbtn_DaThue.Size = new System.Drawing.Size(84, 21);
            this.rbtn_DaThue.TabIndex = 16;
            this.rbtn_DaThue.TabStop = true;
            this.rbtn_DaThue.Text = "Đã Thuê";
            this.rbtn_DaThue.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(818, 16);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(162, 22);
            this.txtSDT.TabIndex = 15;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(618, 16);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(83, 22);
            this.txtMaNV.TabIndex = 14;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(380, 16);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(119, 22);
            this.txtGiaPhong.TabIndex = 12;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(93, 16);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(181, 22);
            this.txtMaPhong.TabIndex = 8;
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_MaNV.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.Location = new System.Drawing.Point(515, 16);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(94, 17);
            this.lb_MaNV.TabIndex = 6;
            this.lb_MaNV.Text = "Mã Nhân Viên";
            // 
            // lb_TinhTrang
            // 
            this.lb_TinhTrang.AutoSize = true;
            this.lb_TinhTrang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_TinhTrang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TinhTrang.Location = new System.Drawing.Point(299, 50);
            this.lb_TinhTrang.Name = "lb_TinhTrang";
            this.lb_TinhTrang.Size = new System.Drawing.Size(75, 17);
            this.lb_TinhTrang.TabIndex = 5;
            this.lb_TinhTrang.Text = "Tình Trạng";
            // 
            // lb_ChuThich
            // 
            this.lb_ChuThich.AutoSize = true;
            this.lb_ChuThich.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_ChuThich.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChuThich.Location = new System.Drawing.Point(721, 16);
            this.lb_ChuThich.Name = "lb_ChuThich";
            this.lb_ChuThich.Size = new System.Drawing.Size(88, 17);
            this.lb_ChuThich.TabIndex = 4;
            this.lb_ChuThich.Text = "Số điện thoại";
            // 
            // lb_GiaPhong
            // 
            this.lb_GiaPhong.AutoSize = true;
            this.lb_GiaPhong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_GiaPhong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiaPhong.Location = new System.Drawing.Point(299, 16);
            this.lb_GiaPhong.Name = "lb_GiaPhong";
            this.lb_GiaPhong.Size = new System.Drawing.Size(71, 17);
            this.lb_GiaPhong.TabIndex = 3;
            this.lb_GiaPhong.Text = "Giá Phòng";
            // 
            // lb_LoaiPhong
            // 
            this.lb_LoaiPhong.AutoSize = true;
            this.lb_LoaiPhong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_LoaiPhong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiPhong.Location = new System.Drawing.Point(15, 65);
            this.lb_LoaiPhong.Name = "lb_LoaiPhong";
            this.lb_LoaiPhong.Size = new System.Drawing.Size(77, 17);
            this.lb_LoaiPhong.TabIndex = 2;
            this.lb_LoaiPhong.Text = "Loại Phòng";
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_MaPhong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPhong.Location = new System.Drawing.Point(15, 16);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(69, 17);
            this.lb_MaPhong.TabIndex = 0;
            this.lb_MaPhong.Text = "Mã Phòng";
            // 
            // dgvPHONG
            // 
            this.dgvPHONG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHONG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.TinhTrang,
            this.GiaPhong,
            this.SDT,
            this.MaNV});
            this.dgvPHONG.Location = new System.Drawing.Point(59, 208);
            this.dgvPHONG.Name = "dgvPHONG";
            this.dgvPHONG.RowTemplate.Height = 24;
            this.dgvPHONG.Size = new System.Drawing.Size(992, 461);
            this.dgvPHONG.TabIndex = 3;
            this.dgvPHONG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPHONG_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // GiaPhong
            // 
            this.GiaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá phòng";
            this.GiaPhong.Name = "GiaPhong";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên phụ trách";
            this.MaNV.Name = "MaNV";
            // 
            // btn_Trove
            // 
            this.btn_Trove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Trove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trove.Location = new System.Drawing.Point(538, 699);
            this.btn_Trove.Name = "btn_Trove";
            this.btn_Trove.Size = new System.Drawing.Size(134, 38);
            this.btn_Trove.TabIndex = 15;
            this.btn_Trove.Text = "Trở về";
            this.btn_Trove.UseVisualStyleBackColor = false;
            this.btn_Trove.Click += new System.EventHandler(this.btn_Trove_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(372, 763);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(134, 38);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(372, 699);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(134, 38);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(215, 763);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(134, 38);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(215, 699);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(134, 38);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(59, 763);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 38);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(60, 699);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(134, 38);
            this.btn_Reload.TabIndex = 9;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(429, 165);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(310, 22);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cmb_TimKiem
            // 
            this.cmb_TimKiem.FormattingEnabled = true;
            this.cmb_TimKiem.Items.AddRange(new object[] {
            "Mã phòng",
            "Loại phòng",
            "Tình trạng",
            "Giá phòng",
            "Số điện thoại",
            "Mã nhân viên phụ trách"});
            this.cmb_TimKiem.Location = new System.Drawing.Point(179, 165);
            this.cmb_TimKiem.Name = "cmb_TimKiem";
            this.cmb_TimKiem.Size = new System.Drawing.Size(222, 24);
            this.cmb_TimKiem.TabIndex = 17;
            this.cmb_TimKiem.Text = "Mã phòng";
            this.cmb_TimKiem.SelectedIndexChanged += new System.EventHandler(this.cmb_TimKiem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tìm kiếm";
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1110, 844);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_TimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btn_Trove);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.dgvPHONG);
            this.Controls.Add(this.panel1);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lb_MaNV;
        private System.Windows.Forms.Label lb_TinhTrang;
        private System.Windows.Forms.Label lb_ChuThich;
        private System.Windows.Forms.Label lb_GiaPhong;
        private System.Windows.Forms.Label lb_LoaiPhong;
        private System.Windows.Forms.Label lb_MaPhong;
        private System.Windows.Forms.DataGridView dgvPHONG;
        private System.Windows.Forms.Button btn_Trove;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.RadioButton rbtn_Trong;
        private System.Windows.Forms.RadioButton rbtn_DaThue;
        private System.Windows.Forms.ComboBox cmb_LoaiPhong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cmb_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}