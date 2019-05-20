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
    public partial class FormQLDatPhong : Form
    {
        string err;
        BLNguoiDat dbDP = new BLNguoiDat();
        public FormQLDatPhong()
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
                var inpt = from p in db.NguoiDats join t in db.PhongvaNguoiDats on p.MaNguoiDat equals t.MaNguoiDat
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
                dgvQLDP.Columns.RemoveAt(3);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void FormQLDatPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã người đặt")
            {
                var lstphantu = from lpt in db.NguoiDats join t in db.PhongvaNguoiDats on lpt.MaNguoiDat equals t.MaNguoiDat
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
    }
}
