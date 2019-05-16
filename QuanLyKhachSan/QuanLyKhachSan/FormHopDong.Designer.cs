namespace QuanLyKhachSan
{
    partial class FormHopDong
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
            this.dtime_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Trove = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_TimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cmb_NgayThue = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtime_NgayThue);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.txtMaHopDong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 100);
            this.panel1.TabIndex = 24;
            // 
            // dtime_NgayThue
            // 
            this.dtime_NgayThue.Location = new System.Drawing.Point(419, 23);
            this.dtime_NgayThue.Name = "dtime_NgayThue";
            this.dtime_NgayThue.Size = new System.Drawing.Size(247, 22);
            this.dtime_NgayThue.TabIndex = 5;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(141, 69);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(187, 22);
            this.txtMaKH.TabIndex = 4;
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Location = new System.Drawing.Point(141, 23);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(187, 22);
            this.txtMaHopDong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // btn_Trove
            // 
            this.btn_Trove.Location = new System.Drawing.Point(471, 452);
            this.btn_Trove.Name = "btn_Trove";
            this.btn_Trove.Size = new System.Drawing.Size(105, 33);
            this.btn_Trove.TabIndex = 23;
            this.btn_Trove.Text = "Trở về";
            this.btn_Trove.UseVisualStyleBackColor = true;
            this.btn_Trove.Click += new System.EventHandler(this.btn_Trove_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(332, 506);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(105, 33);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(332, 452);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(105, 33);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(180, 506);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(105, 33);
            this.btn_Huy.TabIndex = 20;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(180, 452);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(105, 33);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(35, 506);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(105, 33);
            this.btn_Luu.TabIndex = 18;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(35, 452);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(105, 33);
            this.btn_Reload.TabIndex = 17;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Location = new System.Drawing.Point(35, 178);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(764, 254);
            this.dgvHopDong.TabIndex = 16;
            this.dgvHopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDong_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tìm kiếm";
            // 
            // cmb_TimKiem
            // 
            this.cmb_TimKiem.FormattingEnabled = true;
            this.cmb_TimKiem.Items.AddRange(new object[] {
            "Mã hợp đồng",
            "Mã khách hàng",
            "Ngày thuê"});
            this.cmb_TimKiem.Location = new System.Drawing.Point(102, 134);
            this.cmb_TimKiem.Name = "cmb_TimKiem";
            this.cmb_TimKiem.Size = new System.Drawing.Size(183, 24);
            this.cmb_TimKiem.TabIndex = 26;
            this.cmb_TimKiem.SelectedIndexChanged += new System.EventHandler(this.cmb_TimKiem_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(429, 134);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(310, 22);
            this.txtTimKiem.TabIndex = 25;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cmb_NgayThue
            // 
            this.cmb_NgayThue.FormattingEnabled = true;
            this.cmb_NgayThue.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cmb_NgayThue.Location = new System.Drawing.Point(291, 134);
            this.cmb_NgayThue.Name = "cmb_NgayThue";
            this.cmb_NgayThue.Size = new System.Drawing.Size(121, 24);
            this.cmb_NgayThue.TabIndex = 28;
            // 
            // FormHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 565);
            this.Controls.Add(this.cmb_NgayThue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_TimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Trove);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.dgvHopDong);
            this.Name = "FormHopDong";
            this.Text = "FormHopDong";
            this.Load += new System.EventHandler(this.FormHopDong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Trove;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.DateTimePicker dtime_NgayThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cmb_NgayThue;
    }
}