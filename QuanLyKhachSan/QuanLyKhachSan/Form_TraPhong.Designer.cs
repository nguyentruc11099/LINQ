namespace QuanLyKhachSan
{
    partial class Form_TraPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_TimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_KH = new System.Windows.Forms.Panel();
            this.btn_ChonKH = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.dgvDV_HD = new System.Windows.Forms.DataGridView();
            this.dgvPhong_HD = new System.Windows.Forms.DataGridView();
            this.dtime_Today = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.TinhTien_RichTextBox = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_KH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong_HD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // cmb_TimKiem
            // 
            this.cmb_TimKiem.FormattingEnabled = true;
            this.cmb_TimKiem.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Mã hợp đồng"});
            this.cmb_TimKiem.Location = new System.Drawing.Point(209, 56);
            this.cmb_TimKiem.Name = "cmb_TimKiem";
            this.cmb_TimKiem.Size = new System.Drawing.Size(152, 24);
            this.cmb_TimKiem.TabIndex = 38;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(367, 56);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(310, 22);
            this.txtTimKiem.TabIndex = 37;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // panel_KH
            // 
            this.panel_KH.Controls.Add(this.btn_ChonKH);
            this.panel_KH.Controls.Add(this.dgvHopDong);
            this.panel_KH.Location = new System.Drawing.Point(50, 103);
            this.panel_KH.Margin = new System.Windows.Forms.Padding(4);
            this.panel_KH.Name = "panel_KH";
            this.panel_KH.Size = new System.Drawing.Size(927, 193);
            this.panel_KH.TabIndex = 40;
            // 
            // btn_ChonKH
            // 
            this.btn_ChonKH.Location = new System.Drawing.Point(753, 153);
            this.btn_ChonKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChonKH.Name = "btn_ChonKH";
            this.btn_ChonKH.Size = new System.Drawing.Size(133, 38);
            this.btn_ChonKH.TabIndex = 26;
            this.btn_ChonKH.Text = "Chọn";
            this.btn_ChonKH.UseVisualStyleBackColor = true;
            this.btn_ChonKH.Click += new System.EventHandler(this.btn_ChonKH_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dgvHopDong.Location = new System.Drawing.Point(10, 12);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(899, 133);
            this.dgvHopDong.TabIndex = 44;
            // 
            // dgvDV_HD
            // 
            this.dgvDV_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column10,
            this.Column11,
            this.dataGridViewTextBoxColumn4});
            this.dgvDV_HD.Location = new System.Drawing.Point(8, 170);
            this.dgvDV_HD.Name = "dgvDV_HD";
            this.dgvDV_HD.RowTemplate.Height = 24;
            this.dgvDV_HD.Size = new System.Drawing.Size(899, 105);
            this.dgvDV_HD.TabIndex = 45;
            // 
            // dgvPhong_HD
            // 
            this.dgvPhong_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column6,
            this.Column7,
            this.Column8,
            this.NgayHetHan});
            this.dgvPhong_HD.Location = new System.Drawing.Point(8, 16);
            this.dgvPhong_HD.Name = "dgvPhong_HD";
            this.dgvPhong_HD.RowTemplate.Height = 24;
            this.dgvPhong_HD.Size = new System.Drawing.Size(899, 105);
            this.dgvPhong_HD.TabIndex = 46;
            // 
            // dtime_Today
            // 
            this.dtime_Today.Location = new System.Drawing.Point(769, 12);
            this.dtime_Today.Name = "dtime_Today";
            this.dtime_Today.Size = new System.Drawing.Size(200, 22);
            this.dtime_Today.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày hôm nay";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(154, 625);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(122, 39);
            this.btn_ThanhToan.TabIndex = 50;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // TinhTien_RichTextBox
            // 
            this.TinhTien_RichTextBox.Location = new System.Drawing.Point(314, 625);
            this.TinhTien_RichTextBox.Multiline = true;
            this.TinhTien_RichTextBox.Name = "TinhTien_RichTextBox";
            this.TinhTien_RichTextBox.Size = new System.Drawing.Size(540, 235);
            this.TinhTien_RichTextBox.TabIndex = 49;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaHopDong";
            this.Column1.HeaderText = "Mã hợp đồng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TenKH";
            this.Column5.HeaderText = "Tên khách hàng";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "NgayThue";
            this.Column3.HeaderText = "Ngày thuê";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NgayDuKienTraPhong";
            this.Column4.HeaderText = "Ngày dự kiến trả phòng";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã hợp đồng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaPhong";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã phòng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "LoaiPhong";
            this.Column6.HeaderText = "Loại phòng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "GiaPhong";
            this.Column7.HeaderText = "Giá phòng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "NgayThue";
            this.Column8.HeaderText = "Ngày thuê";
            this.Column8.Name = "Column8";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn phòng";
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPhong_HD);
            this.panel1.Controls.Add(this.dgvDV_HD);
            this.panel1.Location = new System.Drawing.Point(52, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 304);
            this.panel1.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã hợp đồng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaDV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã dịch vụ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "TenDV";
            this.Column10.HeaderText = "Tên dịch vụ";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "GiaDV";
            this.Column11.HeaderText = "Giá / Ngày";
            this.Column11.Name = "Column11";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoNgaySD";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số ngày sử dụng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form_TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 940);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.TinhTien_RichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtime_Today);
            this.Controls.Add(this.panel_KH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_TimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "Form_TraPhong";
            this.Text = "Form_TraPhong";
            this.Load += new System.EventHandler(this.Form_TraPhong_Load);
            this.panel_KH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong_HD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_KH;
        private System.Windows.Forms.Button btn_ChonKH;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.DataGridView dgvDV_HD;
        private System.Windows.Forms.DataGridView dgvPhong_HD;
        private System.Windows.Forms.DateTimePicker dtime_Today;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.TextBox TinhTien_RichTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}