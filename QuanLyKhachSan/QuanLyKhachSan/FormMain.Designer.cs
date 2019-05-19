namespace QuanLyKhachSan
{
    partial class FormMain
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
            this.menuQLKS = new System.Windows.Forms.MenuStrip();
            this.menuHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhmucQL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLHopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLDV_KH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLPhong_HD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoatDong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQLKS
            // 
            this.menuQLKS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuQLKS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHethong,
            this.menuDanhmucQL,
            this.menuThongKe,
            this.menuHoatDong});
            this.menuQLKS.Location = new System.Drawing.Point(0, 0);
            this.menuQLKS.Name = "menuQLKS";
            this.menuQLKS.Size = new System.Drawing.Size(800, 28);
            this.menuQLKS.TabIndex = 2;
            this.menuQLKS.Text = "menuStrip1";
            // 
            // menuHethong
            // 
            this.menuHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.menuThoat,
            this.menuDangXuat});
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Size = new System.Drawing.Size(83, 24);
            this.menuHethong.Text = "Hệ thống";
            this.menuHethong.Click += new System.EventHandler(this.menuHethong_Click);
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(157, 26);
            this.menuDangNhap.Text = "Đăng nhập";
            this.menuDangNhap.Click += new System.EventHandler(this.menuDangNhap_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(157, 26);
            this.menuThoat.Text = "Thoát";
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(157, 26);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuDanhmucQL
            // 
            this.menuDanhmucQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLPhong,
            this.menuQLKhachHang,
            this.menuQLNhanVien,
            this.menuQLDichVu,
            this.menuQLHopDong,
            this.menuQLDV_KH,
            this.menuQLPhong_HD,
            this.menuQLHoaDon});
            this.menuDanhmucQL.Name = "menuDanhmucQL";
            this.menuDanhmucQL.Size = new System.Drawing.Size(140, 24);
            this.menuDanhmucQL.Text = "Danh mục quản lý";
            // 
            // menuQLPhong
            // 
            this.menuQLPhong.Name = "menuQLPhong";
            this.menuQLPhong.Size = new System.Drawing.Size(264, 26);
            this.menuQLPhong.Text = "Quản lý phòng";
            this.menuQLPhong.Click += new System.EventHandler(this.menuQLPhong_Click);
            // 
            // menuQLKhachHang
            // 
            this.menuQLKhachHang.Name = "menuQLKhachHang";
            this.menuQLKhachHang.Size = new System.Drawing.Size(264, 26);
            this.menuQLKhachHang.Text = "Quản lý khách hàng";
            this.menuQLKhachHang.Click += new System.EventHandler(this.menuQLKhachHang_Click);
            // 
            // menuQLNhanVien
            // 
            this.menuQLNhanVien.Name = "menuQLNhanVien";
            this.menuQLNhanVien.Size = new System.Drawing.Size(264, 26);
            this.menuQLNhanVien.Text = "Quản lý nhân viên";
            this.menuQLNhanVien.Click += new System.EventHandler(this.menuQLNhanVien_Click);
            // 
            // menuQLDichVu
            // 
            this.menuQLDichVu.Name = "menuQLDichVu";
            this.menuQLDichVu.Size = new System.Drawing.Size(264, 26);
            this.menuQLDichVu.Text = "Quản lý dịch vụ";
            this.menuQLDichVu.Click += new System.EventHandler(this.menuQLDichVu_Click);
            // 
            // menuQLHopDong
            // 
            this.menuQLHopDong.Name = "menuQLHopDong";
            this.menuQLHopDong.Size = new System.Drawing.Size(264, 26);
            this.menuQLHopDong.Text = "Quản lý hợp đồng";
            this.menuQLHopDong.Click += new System.EventHandler(this.menuQLHopDong_Click);
            // 
            // menuQLDV_KH
            // 
            this.menuQLDV_KH.Name = "menuQLDV_KH";
            this.menuQLDV_KH.Size = new System.Drawing.Size(264, 26);
            this.menuQLDV_KH.Text = "Quản lý dịch vụ khách hàng";
            this.menuQLDV_KH.Click += new System.EventHandler(this.menuQLDV_KH_Click);
            // 
            // menuQLPhong_HD
            // 
            this.menuQLPhong_HD.Name = "menuQLPhong_HD";
            this.menuQLPhong_HD.Size = new System.Drawing.Size(264, 26);
            this.menuQLPhong_HD.Text = "Quản lý phòng khách hàng";
            this.menuQLPhong_HD.Click += new System.EventHandler(this.menuQLPhong_HD_Click);
            // 
            // menuQLHoaDon
            // 
            this.menuQLHoaDon.Name = "menuQLHoaDon";
            this.menuQLHoaDon.Size = new System.Drawing.Size(264, 26);
            this.menuQLHoaDon.Text = "Quản lý hóa đơn";
            this.menuQLHoaDon.Click += new System.EventHandler(this.menuQLHoaDon_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(82, 24);
            this.menuThongKe.Text = "Thống kê";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // menuHoatDong
            // 
            this.menuHoatDong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanPhong,
            this.menuTraPhong,
            this.menuDatPhong});
            this.menuHoatDong.Name = "menuHoatDong";
            this.menuHoatDong.Size = new System.Drawing.Size(93, 24);
            this.menuHoatDong.Text = "Hoạt động";
            // 
            // menuNhanPhong
            // 
            this.menuNhanPhong.Name = "menuNhanPhong";
            this.menuNhanPhong.Size = new System.Drawing.Size(216, 26);
            this.menuNhanPhong.Text = "Nhận phòng";
            this.menuNhanPhong.Click += new System.EventHandler(this.menuNhanPhong_Click);
            // 
            // menuTraPhong
            // 
            this.menuTraPhong.Name = "menuTraPhong";
            this.menuTraPhong.Size = new System.Drawing.Size(216, 26);
            this.menuTraPhong.Text = "Trả phòng";
            this.menuTraPhong.Click += new System.EventHandler(this.menuTraPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý khách sạn";
            // 
            // menuDatPhong
            // 
            this.menuDatPhong.Name = "menuDatPhong";
            this.menuDatPhong.Size = new System.Drawing.Size(216, 26);
            this.menuDatPhong.Text = "Đặt phòng";
            this.menuDatPhong.Click += new System.EventHandler(this.menuDatPhong_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuQLKS);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuQLKS.ResumeLayout(false);
            this.menuQLKS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQLKS;
        private System.Windows.Forms.ToolStripMenuItem menuHethong;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuDanhmucQL;
        private System.Windows.Forms.ToolStripMenuItem menuQLPhong;
        private System.Windows.Forms.ToolStripMenuItem menuQLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuQLDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuQLHopDong;
        private System.Windows.Forms.ToolStripMenuItem menuQLDV_KH;
        private System.Windows.Forms.ToolStripMenuItem menuQLPhong_HD;
        private System.Windows.Forms.ToolStripMenuItem menuHoatDong;
        private System.Windows.Forms.ToolStripMenuItem menuNhanPhong;
        private System.Windows.Forms.ToolStripMenuItem menuTraPhong;
        private System.Windows.Forms.ToolStripMenuItem menuQLHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menuDatPhong;
    }
}