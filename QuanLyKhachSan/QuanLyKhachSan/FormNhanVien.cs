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
    public partial class FormNhanVien : Form
    {
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvNhanVien.DataSource = dbNV.LayNhanVien();
                dgvNhanVien.AutoResizeColumns();
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var inpt = from p in db.NhanViens
                           where p.Hide == false
                           select p;
                dgvNhanVien.DataSource = inpt;
                dgvNhanVien.Refresh();
                dgvNhanVien.Columns.Remove("Password");
                dgvNhanVien.Columns.RemoveAt(6);
                //this.txtMaNV.ResetText();
                //this.txtTenNV.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvNhanVien_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            cmb_NgaySinh.Enabled = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gioitinh = checkGioiTinh();
            int r = dgvNhanVien.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.cmb_ChucVu.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtLuongNV.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.dtime_NgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[r].Cells[4].Value.ToString());
            gioitinh = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            if (gioitinh.Length == 3)
            {
                this.rbtn_Nam.Checked = true;
            }
            else this.rbtn_Nu.Checked = true;
        }

        private void btn_ReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
           
            this.txtMaNV.Enabled = false;
            ResetText();
            SinhMa();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaNV.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvNhanVien_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.cmb_ChucVu.Enabled = false;
            this.txtTenNV.Focus();
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string gioitinh = checkGioiTinh();
            if (Them == true)
            {
                try
                {
                    BLNhanVien blP = new BLNhanVien();
                    blP.ThemNhanVien(this.txtMaNV.Text, this.txtTenNV.Text,
                    this.cmb_ChucVu.Text, Convert.ToDouble(this.txtLuongNV.Text),
                    this.dtime_NgaySinh.Value.ToString(), gioitinh, ref err);
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
                BLNhanVien blP = new BLNhanVien();
                blP.CapNhatNhanVien(this.txtMaNV.Text, this.txtTenNV.Text,
                    this.cmb_ChucVu.Text, Convert.ToDouble(this.txtLuongNV.Text),
                    this.dtime_NgaySinh.Value.Date.ToString(), gioitinh,
                    ref err);
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
            this.cmb_ChucVu.Enabled = true;
            dgvNhanVien_CellClick(null, null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                string strNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaNhanVien(ref err, strNV);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }
        private void ResetText()
        {
            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            this.cmb_ChucVu.Text= "";
            this.txtLuongNV.ResetText();
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
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
            if (this.cmb_TimKiem.Text == "Mã nhân viên")
            {
                var lstphantu = from lpt in db.NhanViens
                                where lpt.MaNV.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvNhanVien.DataSource = lstphantu;
                dgvNhanVien.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Tên nhân viên")
            {
                var lstphantu = from lpt in db.NhanViens
                                where lpt.TenNV.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvNhanVien.DataSource = lstphantu;
                dgvNhanVien.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Chức vụ")
            {
                var lstphantu = from lpt in db.NhanViens
                                where lpt.ChucVu.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvNhanVien.DataSource = lstphantu;
                dgvNhanVien.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Lương nhân viên")
            {
                var lstphantu = from lpt in db.NhanViens
                                where lpt.Luong.ToString().Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvNhanVien.DataSource = lstphantu;
                dgvNhanVien.Refresh();
            }

            if (this.cmb_TimKiem.Text == "Giới tính")
            {
                var lstphantu = from lpt in db.NhanViens
                                where lpt.GioiTinh.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvNhanVien.DataSource = lstphantu;
                dgvNhanVien.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Ngày sinh")
            {
                if (this.cmb_NgaySinh.Text == "Ngày")
                {
                    var lstphantu = from lpt in db.NhanViens
                                    where lpt.NgaySinh.Value.Day.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvNhanVien.DataSource = lstphantu;
                    dgvNhanVien.Refresh();
                }
                if (this.cmb_NgaySinh.Text == "Tháng")
                {
                    var lstphantu = from lpt in db.NhanViens
                                    where lpt.NgaySinh.Value.Month.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvNhanVien.DataSource = lstphantu;
                    dgvNhanVien.Refresh();
                }
                if (this.cmb_NgaySinh.Text == "Năm")
                {
                    var lstphantu = from lpt in db.NhanViens
                                    where lpt.NgaySinh.Value.Year.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvNhanVien.DataSource = lstphantu;
                    dgvNhanVien.Refresh();
                }
            }
            dgvNhanVien.Columns.Remove("Password");
            dgvNhanVien.Columns.RemoveAt(6);
        }
        private void SinhMa()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var b = db.NhanViens.Count();
            if (b<9)
            {
                txtMaNV.Text = "N0" + (b+1).ToString();
            }
            else
            {
                txtMaNV.Text = "N" + (b+1).ToString();
            }
        }

        private void cmb_NgaySinh_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmb_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_TimKiem.Text == "Ngày sinh")
            {
                cmb_NgaySinh.Enabled = true;
            }
            else
            {
                cmb_NgaySinh.Text = "";
                cmb_NgaySinh.Enabled = false;
            }
        }
    }
}
