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
    public partial class FormKhachHang : Form
    {
        bool Them;
        string err;
        BLKhachHang dbKH = new BLKhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvKhachHang.DataSource = dbKH.LayKhachHang();
                dgvKhachHang.AutoResizeColumns();
                //this.txtMaKH.ResetText();
                //this.txtTenKH.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvKhachHang_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string gioitinh = checkGioiTinh();
            if (Them == true)
            {
                try
                {
                    BLKhachHang blP = new BLKhachHang();
                    blP.ThemKhachHang(this.txtMaKH.Text, this.txtTenKH.Text,
                    this.txtCMND.Text,gioitinh,
                    this.txtSDT.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được!");
                }
            }
            else
            {
                BLKhachHang blP = new BLKhachHang();
                blP.CapNhatKhachHang(this.txtMaKH.Text, this.txtTenKH.Text,
                    this.txtCMND.Text, gioitinh,
                    this.txtSDT.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ResetText();
            this.btn_Them.Enabled = true;
            this.btn_Sua.Enabled = true;
            this.btn_Xoa.Enabled = true;

            this.btn_Luu.Enabled = false;
            this.btn_Huy.Enabled = false;
            this.panel1.Enabled = false;
            dgvKhachHang_CellClick(null, null);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaKH.Enabled = true;
            ResetText();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaKH.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvKhachHang_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaKH.Enabled = false;
            this.txtTenKH.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKhachHang.CurrentCell.RowIndex;
                string strKH = dgvKhachHang.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbKH.XoaKhachHang(ref err, strKH);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string gioitinh = checkGioiTinh();
            int r = dgvKhachHang.CurrentCell.RowIndex;
            this.txtMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtTenKH.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtCMND.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            gioitinh = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
        }
        private void ResetText()
        {
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtCMND.ResetText();
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
            this.txtSDT.ResetText();
        }
        private string checkGioiTinh()
        {
            if (rbtn_Nam.Checked == true)
            {
                return rbtn_Nam.Text;
            }
            else
            {
                return rbtn_Nu.Text;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã khách hàng")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.MaKH.Contains(txtTimKiem.Text)
                                select lpt;
                dgvKhachHang.DataSource = lstphantu;
                dgvKhachHang.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Tên khách hàng")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.TenKH.Contains(txtTimKiem.Text)
                                select lpt;
                dgvKhachHang.DataSource = lstphantu;
                dgvKhachHang.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Chứng minh nhân dân")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.CMND.Contains(txtTimKiem.Text)
                                select lpt;
                dgvKhachHang.DataSource = lstphantu;
                dgvKhachHang.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Số điện thoại")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.SDT.Contains(txtTimKiem.Text)
                                select lpt;
                dgvKhachHang.DataSource = lstphantu;
                dgvKhachHang.Refresh();
            }

            if (this.cmb_TimKiem.Text == "Giới tính")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.GioiTinh.Contains(txtTimKiem.Text)
                                select lpt;
                dgvKhachHang.DataSource = lstphantu;
                dgvKhachHang.Refresh();
            }
        }
    }
}
