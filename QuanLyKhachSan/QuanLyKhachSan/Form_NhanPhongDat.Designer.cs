namespace QuanLyKhachSan
{
    partial class Form_NhanPhongDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cmb_TimKiem = new System.Windows.Forms.ComboBox();
            this.dgvQLDP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_KH = new System.Windows.Forms.Panel();
            this.btn_ChonKH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtime_NgayDuKien = new System.Windows.Forms.DateTimePicker();
            this.dtime_Today = new System.Windows.Forms.DateTimePicker();
            this.panel_ThemKH = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.SDT_Label = new System.Windows.Forms.Label();
            this.Nu_RadioButton = new System.Windows.Forms.RadioButton();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Nam_RadioButton = new System.Windows.Forms.RadioButton();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.XuatXu_Label = new System.Windows.Forms.Label();
            this.GioiTinh_Label = new System.Windows.Forms.Label();
            this.CMND_Label = new System.Windows.Forms.Label();
            this.TenKH_Label = new System.Windows.Forms.Label();
            this.MaKH_Label = new System.Windows.Forms.Label();
            this.rbtn_new = new System.Windows.Forms.RadioButton();
            this.rbtn_old = new System.Windows.Forms.RadioButton();
            this.panel_HD = new System.Windows.Forms.Panel();
            this.btn_ThemDV = new System.Windows.Forms.Button();
            this.numUD_SoNgayDuKien = new System.Windows.Forms.NumericUpDown();
            this.SoNgayDuKien = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btn_ThemHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDP)).BeginInit();
            this.panel_KH.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.panel_ThemKH.SuspendLayout();
            this.panel_HD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_SoNgayDuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(244, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(287, 22);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cmb_TimKiem
            // 
            this.cmb_TimKiem.FormattingEnabled = true;
            this.cmb_TimKiem.Items.AddRange(new object[] {
            "Mã người đặt",
            "Tên người đặt",
            "Số điện thoại",
            "Ngày hết hạn",
            "Mã phòng"});
            this.cmb_TimKiem.Location = new System.Drawing.Point(115, 40);
            this.cmb_TimKiem.Name = "cmb_TimKiem";
            this.cmb_TimKiem.Size = new System.Drawing.Size(121, 24);
            this.cmb_TimKiem.TabIndex = 7;
            this.cmb_TimKiem.SelectedIndexChanged += new System.EventHandler(this.cmb_TimKiem_SelectedIndexChanged);
            // 
            // dgvQLDP
            // 
            this.dgvQLDP.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvQLDP.Location = new System.Drawing.Point(63, 76);
            this.dgvQLDP.Name = "dgvQLDP";
            this.dgvQLDP.RowTemplate.Height = 24;
            this.dgvQLDP.Size = new System.Drawing.Size(756, 131);
            this.dgvQLDP.TabIndex = 6;
            this.dgvQLDP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDP_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaNguoiDat";
            this.Column1.HeaderText = "Mã người đặt";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenNguoiDat";
            this.Column2.HeaderText = "Tên người đặt";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NgayHetHan";
            this.Column4.HeaderText = "Ngày hết hạn";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MaPhong";
            this.Column5.HeaderText = "Mã phòng";
            this.Column5.Name = "Column5";
            // 
            // panel_KH
            // 
            this.panel_KH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_KH.Controls.Add(this.btn_ChonKH);
            this.panel_KH.Controls.Add(this.panel2);
            this.panel_KH.Controls.Add(this.dgvKH);
            this.panel_KH.Location = new System.Drawing.Point(31, 407);
            this.panel_KH.Margin = new System.Windows.Forms.Padding(4);
            this.panel_KH.Name = "panel_KH";
            this.panel_KH.Size = new System.Drawing.Size(880, 207);
            this.panel_KH.TabIndex = 37;
            // 
            // btn_ChonKH
            // 
            this.btn_ChonKH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ChonKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonKH.ForeColor = System.Drawing.Color.Black;
            this.btn_ChonKH.Location = new System.Drawing.Point(730, 150);
            this.btn_ChonKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChonKH.Name = "btn_ChonKH";
            this.btn_ChonKH.Size = new System.Drawing.Size(133, 38);
            this.btn_ChonKH.TabIndex = 26;
            this.btn_ChonKH.Text = "Chọn";
            this.btn_ChonKH.UseVisualStyleBackColor = false;
            this.btn_ChonKH.Click += new System.EventHandler(this.btn_ChonKH_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(33, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 65);
            this.panel2.TabIndex = 25;
            this.panel2.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Chứng minh nhân dân",
            "Giới tính",
            "Số điện thoại",
            "Xuất xứ"});
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Mã khách hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.CMND,
            this.dataGridViewTextBoxColumn1,
            this.XuatXu,
            this.GioiTinh});
            this.dgvKH.Location = new System.Drawing.Point(33, 10);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(755, 102);
            this.dgvKH.TabIndex = 24;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn1.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // XuatXu
            // 
            this.XuatXu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất Xứ";
            this.XuatXu.Name = "XuatXu";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // dtime_NgayDuKien
            // 
            this.dtime_NgayDuKien.Location = new System.Drawing.Point(665, 47);
            this.dtime_NgayDuKien.Margin = new System.Windows.Forms.Padding(4);
            this.dtime_NgayDuKien.Name = "dtime_NgayDuKien";
            this.dtime_NgayDuKien.Size = new System.Drawing.Size(265, 22);
            this.dtime_NgayDuKien.TabIndex = 44;
            this.dtime_NgayDuKien.ValueChanged += new System.EventHandler(this.dtime_NgayDuKien_ValueChanged);
            // 
            // dtime_Today
            // 
            this.dtime_Today.Location = new System.Drawing.Point(665, 16);
            this.dtime_Today.Margin = new System.Windows.Forms.Padding(4);
            this.dtime_Today.Name = "dtime_Today";
            this.dtime_Today.Size = new System.Drawing.Size(265, 22);
            this.dtime_Today.TabIndex = 43;
            this.dtime_Today.ValueChanged += new System.EventHandler(this.dtime_Today_ValueChanged);
            // 
            // panel_ThemKH
            // 
            this.panel_ThemKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ThemKH.Controls.Add(this.txtTenKH);
            this.panel_ThemKH.Controls.Add(this.txtSDT);
            this.panel_ThemKH.Controls.Add(this.SDT_Label);
            this.panel_ThemKH.Controls.Add(this.Nu_RadioButton);
            this.panel_ThemKH.Controls.Add(this.Add_Button);
            this.panel_ThemKH.Controls.Add(this.Nam_RadioButton);
            this.panel_ThemKH.Controls.Add(this.txtXuatXu);
            this.panel_ThemKH.Controls.Add(this.txtCMND);
            this.panel_ThemKH.Controls.Add(this.txtMaKH);
            this.panel_ThemKH.Controls.Add(this.XuatXu_Label);
            this.panel_ThemKH.Controls.Add(this.GioiTinh_Label);
            this.panel_ThemKH.Controls.Add(this.CMND_Label);
            this.panel_ThemKH.Controls.Add(this.TenKH_Label);
            this.panel_ThemKH.Controls.Add(this.MaKH_Label);
            this.panel_ThemKH.Location = new System.Drawing.Point(32, 284);
            this.panel_ThemKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_ThemKH.Name = "panel_ThemKH";
            this.panel_ThemKH.Size = new System.Drawing.Size(879, 117);
            this.panel_ThemKH.TabIndex = 42;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(133, 63);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(159, 22);
            this.txtTenKH.TabIndex = 19;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(380, 63);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(119, 22);
            this.txtSDT.TabIndex = 18;
            // 
            // SDT_Label
            // 
            this.SDT_Label.AutoSize = true;
            this.SDT_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT_Label.Location = new System.Drawing.Point(315, 71);
            this.SDT_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SDT_Label.Name = "SDT_Label";
            this.SDT_Label.Size = new System.Drawing.Size(39, 17);
            this.SDT_Label.TabIndex = 17;
            this.SDT_Label.Text = "SĐT";
            // 
            // Nu_RadioButton
            // 
            this.Nu_RadioButton.AutoSize = true;
            this.Nu_RadioButton.Location = new System.Drawing.Point(636, 87);
            this.Nu_RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Nu_RadioButton.Name = "Nu_RadioButton";
            this.Nu_RadioButton.Size = new System.Drawing.Size(47, 21);
            this.Nu_RadioButton.TabIndex = 16;
            this.Nu_RadioButton.TabStop = true;
            this.Nu_RadioButton.Text = "Nữ";
            this.Nu_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.Black;
            this.Add_Button.Location = new System.Drawing.Point(740, 70);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(133, 38);
            this.Add_Button.TabIndex = 20;
            this.Add_Button.Text = "Thêm";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Nam_RadioButton
            // 
            this.Nam_RadioButton.AutoSize = true;
            this.Nam_RadioButton.Location = new System.Drawing.Point(636, 58);
            this.Nam_RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Nam_RadioButton.Name = "Nam_RadioButton";
            this.Nam_RadioButton.Size = new System.Drawing.Size(58, 21);
            this.Nam_RadioButton.TabIndex = 15;
            this.Nam_RadioButton.TabStop = true;
            this.Nam_RadioButton.Text = "Nam";
            this.Nam_RadioButton.UseVisualStyleBackColor = true;
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(619, 16);
            this.txtXuatXu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(168, 22);
            this.txtXuatXu.TabIndex = 14;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(380, 16);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(119, 22);
            this.txtCMND.TabIndex = 12;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(133, 16);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(159, 22);
            this.txtMaKH.TabIndex = 8;
            // 
            // XuatXu_Label
            // 
            this.XuatXu_Label.AutoSize = true;
            this.XuatXu_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatXu_Label.Location = new System.Drawing.Point(515, 16);
            this.XuatXu_Label.Name = "XuatXu_Label";
            this.XuatXu_Label.Size = new System.Drawing.Size(65, 17);
            this.XuatXu_Label.TabIndex = 6;
            this.XuatXu_Label.Text = "Xuất Xứ";
            // 
            // GioiTinh_Label
            // 
            this.GioiTinh_Label.AutoSize = true;
            this.GioiTinh_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh_Label.Location = new System.Drawing.Point(515, 69);
            this.GioiTinh_Label.Name = "GioiTinh_Label";
            this.GioiTinh_Label.Size = new System.Drawing.Size(74, 17);
            this.GioiTinh_Label.TabIndex = 5;
            this.GioiTinh_Label.Text = "Giới Tính";
            // 
            // CMND_Label
            // 
            this.CMND_Label.AutoSize = true;
            this.CMND_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMND_Label.Location = new System.Drawing.Point(315, 20);
            this.CMND_Label.Name = "CMND_Label";
            this.CMND_Label.Size = new System.Drawing.Size(52, 17);
            this.CMND_Label.TabIndex = 3;
            this.CMND_Label.Text = "CMND";
            // 
            // TenKH_Label
            // 
            this.TenKH_Label.AutoSize = true;
            this.TenKH_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKH_Label.Location = new System.Drawing.Point(15, 63);
            this.TenKH_Label.Name = "TenKH_Label";
            this.TenKH_Label.Size = new System.Drawing.Size(129, 17);
            this.TenKH_Label.TabIndex = 2;
            this.TenKH_Label.Text = "Tên Khách Hàng";
            // 
            // MaKH_Label
            // 
            this.MaKH_Label.AutoSize = true;
            this.MaKH_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKH_Label.Location = new System.Drawing.Point(15, 20);
            this.MaKH_Label.Name = "MaKH_Label";
            this.MaKH_Label.Size = new System.Drawing.Size(122, 17);
            this.MaKH_Label.TabIndex = 0;
            this.MaKH_Label.Text = "Mã Khách Hàng";
            // 
            // rbtn_new
            // 
            this.rbtn_new.AutoSize = true;
            this.rbtn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_new.Location = new System.Drawing.Point(297, 239);
            this.rbtn_new.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_new.Name = "rbtn_new";
            this.rbtn_new.Size = new System.Drawing.Size(197, 21);
            this.rbtn_new.TabIndex = 41;
            this.rbtn_new.TabStop = true;
            this.rbtn_new.Text = "Khách đến lần đầu tiên";
            this.rbtn_new.UseVisualStyleBackColor = true;
            // 
            // rbtn_old
            // 
            this.rbtn_old.AutoSize = true;
            this.rbtn_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_old.Location = new System.Drawing.Point(51, 239);
            this.rbtn_old.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_old.Name = "rbtn_old";
            this.rbtn_old.Size = new System.Drawing.Size(207, 21);
            this.rbtn_old.TabIndex = 40;
            this.rbtn_old.TabStop = true;
            this.rbtn_old.Text = "Khách hàng đã từng đến";
            this.rbtn_old.UseVisualStyleBackColor = true;
            this.rbtn_old.CheckedChanged += new System.EventHandler(this.rbtn_old_CheckedChanged);
            // 
            // panel_HD
            // 
            this.panel_HD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_HD.Controls.Add(this.btn_ThemDV);
            this.panel_HD.Controls.Add(this.numUD_SoNgayDuKien);
            this.panel_HD.Controls.Add(this.SoNgayDuKien);
            this.panel_HD.Controls.Add(this.btn_Reset);
            this.panel_HD.Controls.Add(this.txtMaHD);
            this.panel_HD.Controls.Add(this.btn_ThemHD);
            this.panel_HD.Controls.Add(this.label3);
            this.panel_HD.Controls.Add(this.dgvHD);
            this.panel_HD.Location = new System.Drawing.Point(21, 652);
            this.panel_HD.Margin = new System.Windows.Forms.Padding(4);
            this.panel_HD.Name = "panel_HD";
            this.panel_HD.Size = new System.Drawing.Size(909, 137);
            this.panel_HD.TabIndex = 45;
            // 
            // btn_ThemDV
            // 
            this.btn_ThemDV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDV.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemDV.Location = new System.Drawing.Point(759, 25);
            this.btn_ThemDV.Name = "btn_ThemDV";
            this.btn_ThemDV.Size = new System.Drawing.Size(130, 37);
            this.btn_ThemDV.TabIndex = 46;
            this.btn_ThemDV.Text = "Thêm dịch vụ";
            this.btn_ThemDV.UseVisualStyleBackColor = false;
            this.btn_ThemDV.Click += new System.EventHandler(this.btn_ThemDV_Click);
            // 
            // numUD_SoNgayDuKien
            // 
            this.numUD_SoNgayDuKien.Location = new System.Drawing.Point(493, 14);
            this.numUD_SoNgayDuKien.Name = "numUD_SoNgayDuKien";
            this.numUD_SoNgayDuKien.Size = new System.Drawing.Size(120, 22);
            this.numUD_SoNgayDuKien.TabIndex = 44;
            // 
            // SoNgayDuKien
            // 
            this.SoNgayDuKien.AutoSize = true;
            this.SoNgayDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoNgayDuKien.Location = new System.Drawing.Point(348, 16);
            this.SoNgayDuKien.Name = "SoNgayDuKien";
            this.SoNgayDuKien.Size = new System.Drawing.Size(139, 17);
            this.SoNgayDuKien.TabIndex = 41;
            this.SoNgayDuKien.Text = "Số ngày ở dự kiến";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Black;
            this.btn_Reset.Location = new System.Drawing.Point(651, 81);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 39);
            this.btn_Reset.TabIndex = 41;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(189, 11);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 39;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHD.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemHD.Location = new System.Drawing.Point(757, 81);
            this.btn_ThemHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(133, 38);
            this.btn_ThemHD.TabIndex = 43;
            this.btn_ThemHD.Text = "Thêm Hợp Đồng";
            this.btn_ThemHD.UseVisualStyleBackColor = false;
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Hợp đồng sẽ là :";
            // 
            // dgvHD
            // 
            this.dgvHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.NgayThue});
            this.dgvHD.Location = new System.Drawing.Point(16, 41);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(629, 79);
            this.dgvHD.TabIndex = 41;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHopDong";
            this.MaHD.HeaderText = "Mã Hợp Đồng";
            this.MaHD.Name = "MaHD";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "DS_Phòng thuê";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // NgayThue
            // 
            this.NgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayThue.DataPropertyName = "NgayThue";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.NgayThue.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgayThue.HeaderText = "Ngày Bắt Đầu Thuê";
            this.NgayThue.Name = "NgayThue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ngày hôm nay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ngày dự kiến ";
            // 
            // Form_NhanPhongDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(973, 815);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_HD);
            this.Controls.Add(this.dtime_NgayDuKien);
            this.Controls.Add(this.dtime_Today);
            this.Controls.Add(this.panel_ThemKH);
            this.Controls.Add(this.rbtn_new);
            this.Controls.Add(this.rbtn_old);
            this.Controls.Add(this.panel_KH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cmb_TimKiem);
            this.Controls.Add(this.dgvQLDP);
            this.Name = "Form_NhanPhongDat";
            this.Text = "Form_NhanPhongDat";
            this.Load += new System.EventHandler(this.Form_NhanPhongDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDP)).EndInit();
            this.panel_KH.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.panel_ThemKH.ResumeLayout(false);
            this.panel_ThemKH.PerformLayout();
            this.panel_HD.ResumeLayout(false);
            this.panel_HD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_SoNgayDuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cmb_TimKiem;
        private System.Windows.Forms.DataGridView dgvQLDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel_KH;
        private System.Windows.Forms.Button btn_ChonKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DateTimePicker dtime_NgayDuKien;
        private System.Windows.Forms.DateTimePicker dtime_Today;
        private System.Windows.Forms.Panel panel_ThemKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label SDT_Label;
        private System.Windows.Forms.RadioButton Nu_RadioButton;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.RadioButton Nam_RadioButton;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label XuatXu_Label;
        private System.Windows.Forms.Label GioiTinh_Label;
        private System.Windows.Forms.Label CMND_Label;
        private System.Windows.Forms.Label TenKH_Label;
        private System.Windows.Forms.Label MaKH_Label;
        private System.Windows.Forms.RadioButton rbtn_new;
        private System.Windows.Forms.RadioButton rbtn_old;
        private System.Windows.Forms.Panel panel_HD;
        private System.Windows.Forms.NumericUpDown numUD_SoNgayDuKien;
        private System.Windows.Forms.Label SoNgayDuKien;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btn_ThemHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Button btn_ThemDV;
    }
}