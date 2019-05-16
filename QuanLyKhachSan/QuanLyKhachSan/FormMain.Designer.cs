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
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhmucQL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuQLKS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQLKS
            // 
            this.menuQLKS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuQLKS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHethong,
            this.menuDanhmucQL});
            this.menuQLKS.Location = new System.Drawing.Point(0, 0);
            this.menuQLKS.Name = "menuQLKS";
            this.menuQLKS.Size = new System.Drawing.Size(800, 28);
            this.menuQLKS.TabIndex = 2;
            this.menuQLKS.Text = "menuStrip1";
            // 
            // menuHethong
            // 
            this.menuHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.menuThoat});
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Size = new System.Drawing.Size(83, 24);
            this.menuHethong.Text = "Hệ thống";
            this.menuHethong.Click += new System.EventHandler(this.menuHethong_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(157, 26);
            this.menuThoat.Text = "Thoát";
            // 
            // menuDanhmucQL
            // 
            this.menuDanhmucQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLPhong,
            this.menuQLKhachHang,
            this.menuQLNhanVien,
            this.menuQLDichVu});
            this.menuDanhmucQL.Name = "menuDanhmucQL";
            this.menuDanhmucQL.Size = new System.Drawing.Size(140, 24);
            this.menuDanhmucQL.Text = "Danh mục quản lý";
            // 
            // menuQLPhong
            // 
            this.menuQLPhong.Name = "menuQLPhong";
            this.menuQLPhong.Size = new System.Drawing.Size(213, 26);
            this.menuQLPhong.Text = "Quản lý phòng";
            // 
            // menuQLKhachHang
            // 
            this.menuQLKhachHang.Name = "menuQLKhachHang";
            this.menuQLKhachHang.Size = new System.Drawing.Size(213, 26);
            this.menuQLKhachHang.Text = "Quản lý khách hàng";
            // 
            // menuQLNhanVien
            // 
            this.menuQLNhanVien.Name = "menuQLNhanVien";
            this.menuQLNhanVien.Size = new System.Drawing.Size(216, 26);
            this.menuQLNhanVien.Text = "Quản lý nhân viên";
            this.menuQLNhanVien.Click += new System.EventHandler(this.menuQLNhanVien_Click);
            // 
            // menuQLDichVu
            // 
            this.menuQLDichVu.Name = "menuQLDichVu";
            this.menuQLDichVu.Size = new System.Drawing.Size(216, 26);
            this.menuQLDichVu.Text = "Quản lý dịch vụ";
            this.menuQLDichVu.Click += new System.EventHandler(this.menuQLDichVu_Click);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuQLKS);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuQLKS.ResumeLayout(false);
            this.menuQLKS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQLKS;
        private System.Windows.Forms.ToolStripMenuItem menuHethong;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuDanhmucQL;
        private System.Windows.Forms.ToolStripMenuItem menuQLPhong;
        private System.Windows.Forms.ToolStripMenuItem menuQLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuQLDichVu;
        private System.Windows.Forms.Label label1;
    }
}