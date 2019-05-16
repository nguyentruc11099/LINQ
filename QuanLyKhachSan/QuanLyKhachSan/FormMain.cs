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
                }
                else
                {
                    this.menuDanhmucQL.Enabled = true;
                    this.menuThoat.Enabled = true;

                }
                this.menuDangXuat.Enabled = true;
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

            }
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {

        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            bIsLogin = false;
            Khoitaomoi();
           
        }
    }
}
