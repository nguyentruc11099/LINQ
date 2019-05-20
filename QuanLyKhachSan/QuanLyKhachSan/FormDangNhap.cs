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
        BLDangNhap txt = new BLDangNhap();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string chucvu = KTchucvu();
            if (txt.LayTaiKhoan(txtID.Text, txtPass.Text, chucvu) == true)
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
        private string KTchucvu()
        {
            if(rbtn_LeTan.Checked == true)
            {
                FormMain.isQL = false;
                return rbtn_LeTan.Text;

            }
            else
            {
                FormMain.isQL = true;
                return rbtn_QuanLy.Text;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            rbtn_QuanLy.Checked = true;
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
