using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormMain : Form
    {
        public static bool bIsLogin = false;
        public static bool isQL = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuHethong_Click(object sender, EventArgs e)
        {

        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap dnh = new FormDangNhap();
            dnh.ShowDialog();
            if (FormMain.bIsLogin == true)
            {
                if (FormMain.isQL == true)
                {
                    this.menuDanhmucQL.Enabled = true;
                    this.menuThoat.Enabled = true;
                    this.menuThongKe.Enabled = true;
                    this.menuHoatDong.Enabled = true;
                }
                else
                {
                    this.menuDanhmucQL.Enabled = true;
                    this.menuThoat.Enabled = true;
                    this.menuHoatDong.Enabled = true;

                }
                this.menuDangXuat.Enabled = true;
                this.menuDangNhap.Enabled = false;
            }
        }

        private void menuQLDichVu_Click(object sender, EventArgs e)
        {
            FormDichVu a1 = new FormDichVu();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuQLNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien a1 = new FormNhanVien();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuQLPhong_Click(object sender, EventArgs e)
        {
            FormPhong a1 = new FormPhong();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuQLKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang a1 = new FormKhachHang();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Khoitaomoi();
        }
        private void Khoitaomoi()
        {
            if(bIsLogin == false)
            {
                menuDanhmucQL.Enabled = false;
                menuThongKe.Enabled = false;
                menuDangXuat.Enabled = false;
                menuHoatDong.Enabled = false;
            }
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {

        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            bIsLogin = false;
            this.menuDangNhap.Enabled = true;
            Khoitaomoi();
           
        }

        private void menuQLHopDong_Click(object sender, EventArgs e)
        {
            FormHopDong a1 = new FormHopDong();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuQLDV_KH_Click(object sender, EventArgs e)
        {
            FormDichVu_HopDong a1 = new FormDichVu_HopDong();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuQLPhong_HD_Click(object sender, EventArgs e)
        {
            FormPhong_HD a1 = new FormPhong_HD();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuQLHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon a1 = new FormHoaDon();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuNhanPhong_Click(object sender, EventArgs e)
        {
            Form_NhanPhong a1 = new Form_NhanPhong();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuTraPhong_Click(object sender, EventArgs e)
        {
            Form_TraPhong a1 = new Form_TraPhong();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }
    }
}
