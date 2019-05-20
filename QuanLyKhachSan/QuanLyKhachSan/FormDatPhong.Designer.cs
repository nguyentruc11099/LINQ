namespace QuanLyKhachSan
{
    partial class FormDatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtime_NgayDuocDat = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNguoiDat = new System.Windows.Forms.TextBox();
            this.HopDongMoi_Panel = new System.Windows.Forms.Panel();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.ThemNguoiDatvaPhongDat_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHDDat = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPHONG = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_TimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.HopDongMoi_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ngày được đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tên người đặt";
            // 
            // dtime_NgayDuocDat
            // 
            this.dtime_NgayDuocDat.Location = new System.Drawing.Point(161, 150);
            this.dtime_NgayDuocDat.Margin = new System.Windows.Forms.Padding(4);
            this.dtime_NgayDuocDat.Name = "dtime_NgayDuocDat";
            this.dtime_NgayDuocDat.Size = new System.Drawing.Size(252, 22);
            this.dtime_NgayDuocDat.TabIndex = 44;
            this.dtime_NgayDuocDat.ValueChanged += new System.EventHandler(this.dtime_NgayDuocDat_ValueChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(161, 91);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(252, 22);
            this.txtSDT.TabIndex = 43;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtTenNguoiDat
            // 
            this.txtTenNguoiDat.Location = new System.Drawing.Point(161, 36);
            this.txtTenNguoiDat.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNguoiDat.Name = "txtTenNguoiDat";
            this.txtTenNguoiDat.Size = new System.Drawing.Size(252, 22);
            this.txtTenNguoiDat.TabIndex = 42;
            this.txtTenNguoiDat.TextChanged += new System.EventHandler(this.txtTenNguoiDat_TextChanged);
            // 
            // HopDongMoi_Panel
            // 
            this.HopDongMoi_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HopDongMoi_Panel.Controls.Add(this.Reset_Button);
            this.HopDongMoi_Panel.Controls.Add(this.Back_Button);
            this.HopDongMoi_Panel.Controls.Add(this.ThemNguoiDatvaPhongDat_Button);
            this.HopDongMoi_Panel.Controls.Add(this.label3);
            this.HopDongMoi_Panel.Controls.Add(this.dgvHDDat);
            this.HopDongMoi_Panel.Location = new System.Drawing.Point(32, 493);
            this.HopDongMoi_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.HopDongMoi_Panel.Name = "HopDongMoi_Panel";
            this.HopDongMoi_Panel.Size = new System.Drawing.Size(909, 167);
            this.HopDongMoi_Panel.TabIndex = 41;
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button.Location = new System.Drawing.Point(771, 11);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(132, 28);
            this.Reset_Button.TabIndex = 45;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(771, 58);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(132, 33);
            this.Back_Button.TabIndex = 44;
            this.Back_Button.Text = "Trở về ";
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ThemNguoiDatvaPhongDat_Button
            // 
            this.ThemNguoiDatvaPhongDat_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ThemNguoiDatvaPhongDat_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemNguoiDatvaPhongDat_Button.Location = new System.Drawing.Point(770, 106);
            this.ThemNguoiDatvaPhongDat_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThemNguoiDatvaPhongDat_Button.Name = "ThemNguoiDatvaPhongDat_Button";
            this.ThemNguoiDatvaPhongDat_Button.Size = new System.Drawing.Size(133, 38);
            this.ThemNguoiDatvaPhongDat_Button.TabIndex = 43;
            this.ThemNguoiDatvaPhongDat_Button.Text = "Thêm Ghi Nhớ";
            this.ThemNguoiDatvaPhongDat_Button.UseVisualStyleBackColor = false;
            this.ThemNguoiDatvaPhongDat_Button.Click += new System.EventHandler(this.ThemNguoiDatvaPhongDat_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Bản ghi nhớ đặt phòng sẽ là: ";
            // 
            // dgvHDDat
            // 
            this.dgvHDDat.BackgroundColor = System.Drawing.Color.White;
            this.dgvHDDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.dataGridViewTextBoxColumn2,
            this.NgayThue,
            this.NgayKetThuc,
            this.PhongThue});
            this.dgvHDDat.Location = new System.Drawing.Point(22, 41);
            this.dgvHDDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHDDat.Name = "dgvHDDat";
            this.dgvHDDat.RowTemplate.Height = 24;
            this.dgvHDDat.Size = new System.Drawing.Size(733, 103);
            this.dgvHDDat.TabIndex = 41;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.HeaderText = "Mã Người Đặt";
            this.MaHD.Name = "MaHD";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Người Đặt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // NgayThue
            // 
            this.NgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = null;
            this.NgayThue.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgayThue.HeaderText = "Số Điện Thoại";
            this.NgayThue.Name = "NgayThue";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "dd//MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.NgayKetThuc.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayKetThuc.HeaderText = "Ngày được đặt";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // PhongThue
            // 
            this.PhongThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhongThue.HeaderText = "Những phòng được đặt";
            this.PhongThue.Name = "PhongThue";
            // 
            // dgvPHONG
            // 
            this.dgvPHONG.BackgroundColor = System.Drawing.Color.White;
            this.dgvPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHONG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.TinhTrang,
            this.GiaPhong,
            this.SDT,
            this.MaNV});
            this.dgvPHONG.Location = new System.Drawing.Point(32, 29);
            this.dgvPHONG.Name = "dgvPHONG";
            this.dgvPHONG.RowTemplate.Height = 24;
            this.dgvPHONG.Size = new System.Drawing.Size(866, 152);
            this.dgvPHONG.TabIndex = 48;
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
            this.cmb_TimKiem.Location = new System.Drawing.Point(56, 207);
            this.cmb_TimKiem.Name = "cmb_TimKiem";
            this.cmb_TimKiem.Size = new System.Drawing.Size(222, 24);
            this.cmb_TimKiem.TabIndex = 50;
            this.cmb_TimKiem.Text = "Mã phòng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(284, 209);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(310, 22);
            this.txtTimKiem.TabIndex = 49;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Chon);
            this.panel1.Controls.Add(this.cmb_TimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.dgvPHONG);
            this.panel1.Location = new System.Drawing.Point(32, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 246);
            this.panel1.TabIndex = 51;
            // 
            // btn_Chon
            // 
            this.btn_Chon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.Location = new System.Drawing.Point(770, 196);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(128, 37);
            this.btn_Chon.TabIndex = 51;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = false;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(975, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtime_NgayDuocDat);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenNguoiDat);
            this.Controls.Add(this.HopDongMoi_Panel);
            this.Name = "FormDatPhong";
            this.Text = "FormDatPhong";
            this.Load += new System.EventHandler(this.FormDatPhong_Load);
            this.HopDongMoi_Panel.ResumeLayout(false);
            this.HopDongMoi_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtime_NgayDuocDat;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNguoiDat;
        private System.Windows.Forms.Panel HopDongMoi_Panel;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button ThemNguoiDatvaPhongDat_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHDDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongThue;
        private System.Windows.Forms.DataGridView dgvPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.ComboBox cmb_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Chon;
    }
}