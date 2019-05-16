using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using QuanLyKhachSan.BS_Layer;
namespace QuanLyKhachSan
{
    public partial class FormDangNhap : Form
    {
        BLNhanVien txt = new BLNhanVien();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt.LayTaiKhoan(txtID.Text, txtPass.Text) == true)
            {
                FormMain.bIsLogin = true;
                Close();
            }
            else
            {
                FormMain.bIsLogin = false;
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                txtID.Focus();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
