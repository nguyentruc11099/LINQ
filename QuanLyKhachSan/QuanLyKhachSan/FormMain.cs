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
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuHethong_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap dnh = new FormDangNhap();
            dnh.ShowDialog();
            if (FormMain.bIsLogin == true)
            {
                this.menuDanhmucQL.Enabled = true;
                this.menuThoat.Enabled = true;
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
    }
}
