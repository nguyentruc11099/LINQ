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
    public partial class Form_NhanPhongDat : Form
    {
        string err;
        BLNguoiDat dbDP = new BLNguoiDat();
        BLKhachHang dbKH = new BLKhachHang();
        string[] m = new string[50];
        int n = 0;
        public Form_NhanPhongDat()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvQLDP.DataSource = dbDP.LayNguoiDat();
                dgvQLDP.AutoResizeColumns();
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var inpt = from p in db.NguoiDats
                           join t in db.PhongvaNguoiDats on p.MaNguoiDat equals t.MaNguoiDat
                           where p.Hide == false
                           select new
                           {
                               MaNguoiDat = p.MaNguoiDat,
                               TenNguoiDat = p.TenNguoiDat,
                               SDT = p.SDT,
                               NgayHetHan = p.NgayHetHan,
                               MaPhong = t.MaPhong
                           };
                dgvQLDP.DataSource = inpt;
                dgvQLDP.Refresh();

                dgvKH.DataSource = dbKH.LayKhachHang();
                var inpt1 = from p in db.KhachHangs
                            where p.Hide == false
                            select p;
                dgvKH.DataSource = inpt1;
                dgvKH.Refresh();
                dgvKH.Columns.RemoveAt(6);
                dgvKH.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }

        private void cmb_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string gioitinh = checkGioiTinh();
            try
            {
                BLKhachHang blP = new BLKhachHang();
                blP.ThemKhachHang(this.txtMaKH.Text, this.txtTenKH.Text,
                this.txtCMND.Text, gioitinh, this.txtSDT.Text, this.txtXuatXu.Text, ref err);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
            catch
            {
                MessageBox.Show("Không thêm được!");
            }
            LoadData();
        }

        private void btn_ChonKH_Click(object sender, EventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            dgvHD.Rows[0].Cells[2].Value = dgvKH.Rows[r].Cells[0].Value;
            SinhMaHD();
            int k = dgvQLDP.CurrentCell.RowIndex;
            string q = dgvQLDP.Rows[k].Cells[0].Value.ToString();
            for(int i = 0; i<dgvQLDP.Rows.Count;i++)
            {
                if (dgvQLDP.Rows[i].Cells[0].Value.ToString() == q)
                {
                    m[n++] = dgvQLDP.Rows[i].Cells[4].Value.ToString();
                }
            }
            for(int i = 0; i < n; i++)
            {
                dgvHD.Rows[0].Cells[1].Value = dgvHD.Rows[0].Cells[1].Value + "-" + m[i];
            }
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            BLPhong_HD db_P_HD = new BLPhong_HD();
            if (dgvHD.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng!");
                txtMaKH.Focus();
            }
            else
            {
                if (dtime_NgayDuKien.Value <= dtime_Today.Value)
                {
                    MessageBox.Show("Vui lòng chọn ngày dự kiến trả phòng!");
                }
                else
                {
                    int r = dgvKH.CurrentCell.RowIndex;
                    int q = dgvQLDP.CurrentCell.RowIndex;
                    BLHopDong db_HD = new BLHopDong();
                    BLPhong db_P = new BLPhong();
                    BLNguoiDat dbNDat = new BLNguoiDat();
                    BLPhong_NguoiDat dbPh_NDat = new BLPhong_NguoiDat();
                    db_HD.ThemHopDong(this.txtMaHD.Text, dgvKH.Rows[r].Cells[0].Value.ToString(),
                        dgvHD.Rows[0].Cells[3].Value.ToString(), this.dtime_NgayDuKien.Value.Date.ToString(), ref err);
                    LoadData();
                    string MaNgDat = dgvQLDP.Rows[q].Cells[0].Value.ToString();
                    for (int i = 0; i < n; i++)
                    {
                        db_P_HD.ThemPhong_HD(this.txtMaHD.Text, m[i], ref err);
                        db_P.CapNhatPhong_TinhTrang(m[i],"Đã Thuê", ref err);
                        dbPh_NDat.XoaPhong_NguoiDat(ref err, MaNgDat, m[i]);
                        LoadData();
                    }
                    dbNDat.XoaNguoiDat(ref err, MaNgDat);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                    btn_ThemDV.Enabled = true;
                    dgvHD.Rows.Clear();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            string[] m = new string[50];
            n = 0;
            dgvHD.Rows.Clear();
        }

        private void Form_NhanPhongDat_Load(object sender, EventArgs e)
        {
            LoadData();
            SinhMaKH();
            dgvQLDP_CellClick(null, null);
            rbtn_new.Checked = true;
            Nam_RadioButton.Checked = true;
            dgvHD.Rows[0].Cells[3].Value = dtime_Today.Value;
            btn_ThemDV.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã người đặt")
            {
                var lstphantu = from lpt in db.NguoiDats
                                join t in db.PhongvaNguoiDats on lpt.MaNguoiDat equals t.MaNguoiDat
                                where lpt.MaNguoiDat.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select new
                                {
                                    MaNguoiDat = lpt.MaNguoiDat,
                                    TenNguoiDat = lpt.TenNguoiDat,
                                    SDT = lpt.SDT,
                                    NgayHetHan = lpt.NgayHetHan,
                                    MaPhong = t.MaPhong
                                };
                dgvQLDP.DataSource = lstphantu;
                dgvQLDP.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Tên người đặt")
            {
                var lstphantu = from lpt in db.NguoiDats
                                join t in db.PhongvaNguoiDats on lpt.MaNguoiDat equals t.MaNguoiDat
                                where lpt.TenNguoiDat.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select new
                                {
                                    MaNguoiDat = lpt.MaNguoiDat,
                                    TenNguoiDat = lpt.TenNguoiDat,
                                    SDT = lpt.SDT,
                                    NgayHetHan = lpt.NgayHetHan,
                                    MaPhong = t.MaPhong
                                };
                dgvQLDP.DataSource = lstphantu;
                dgvQLDP.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Mã phòng")
            {
                var lstphantu = from lpt in db.NguoiDats
                                join t in db.PhongvaNguoiDats on lpt.MaNguoiDat equals t.MaNguoiDat
                                where t.MaPhong.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select new
                                {
                                    MaNguoiDat = lpt.MaNguoiDat,
                                    TenNguoiDat = lpt.TenNguoiDat,
                                    SDT = lpt.SDT,
                                    NgayHetHan = lpt.NgayHetHan,
                                    MaPhong = t.MaPhong
                                };
                dgvQLDP.DataSource = lstphantu;
                dgvQLDP.Refresh();
            }
            dgvQLDP.Columns.RemoveAt(3);
        }
        private void SinhMaKH()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var b = db.KhachHangs.Count();
            if (b < 9)
            {
                txtMaKH.Text = "K0" + (b + 1).ToString();
            }
            else
            {
                txtMaKH.Text = "N" + (b + 1).ToString();
            }
            txtMaKH.Enabled = false;
        }

        private void dgvQLDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvQLDP.CurrentCell.RowIndex;
            txtTenKH.Text = dgvQLDP.Rows[r].Cells[1].Value.ToString();
            txtSDT.Text = dgvQLDP.Rows[r].Cells[2].Value.ToString();
        }

        private void rbtn_old_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_old.Checked == true)
            {
                panel_ThemKH.Enabled = false;
                panel_ThemKH.ResetText();
            }
            else
            {
                panel_ThemKH.Enabled = true;
            }
        }
        private string checkGioiTinh()
        {
            if (Nam_RadioButton.Checked == true)
            {
                return Nam_RadioButton.Text;
            }
            else
            {
                return Nu_RadioButton.Text;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ChonTiemKiem1();
        }
        private void ChonTiemKiem1()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.comboBox1.Text == "Mã khách hàng")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.MaKH.Contains(textBox1.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvKH.DataSource = lstphantu;
                dgvKH.Refresh();
            }
            if (this.comboBox1.Text == "Tên khách hàng")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.TenKH.Contains(textBox1.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvKH.DataSource = lstphantu;
                dgvKH.Refresh();
            }
            if (this.comboBox1.Text == "Chứng minh nhân dân")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.CMND.Contains(textBox1.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvKH.DataSource = lstphantu;
                dgvKH.Refresh();
            }
            if (this.comboBox1.Text == "Số điện thoại")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.SDT.Contains(textBox1.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvKH.DataSource = lstphantu;
                dgvKH.Refresh();
            }

            if (this.comboBox1.Text == "Giới tính")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.GioiTinh.Contains(textBox1.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvKH.DataSource = lstphantu;
                dgvKH.Refresh();
            }
            if (this.comboBox1.Text == "Xuất xứ")
            {
                var lstphantu = from lpt in db.KhachHangs
                                where lpt.XuatXu.Contains(textBox1.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvKH.DataSource = lstphantu;
                dgvKH.Refresh();
            }
            dgvKH.Columns.RemoveAt(6);

        }
        private void SinhMaHD()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var counts = db.HopDongs.Count();
            if (counts < 9)
            {
                txtMaHD.Text = "H0" + (counts + 1).ToString();
            }
            else
            {
                txtMaHD.Text = "H" + (counts + 1).ToString();
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[0].Value = txtMaHD.Text;
        }

        private void dtime_Today_ValueChanged(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[3].Value = dtime_Today.Value;
        }

        private void dtime_NgayDuKien_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan a = dtime_NgayDuKien.Value - dtime_Today.Value;
            numUD_SoNgayDuKien.Value = a.Days + 1;
        }

        private void btn_ThemDV_Click(object sender, EventArgs e)
        {
            FormDichVu_HopDong a1 = new FormDichVu_HopDong();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }
    }
}
