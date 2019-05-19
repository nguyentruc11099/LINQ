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
    public partial class FormDatPhong : Form
    {
        BLPhong dbPh = new BLPhong();
        string err;
        string temp = "";
        string[] m = new string[50];
        int n = 0;
        public FormDatPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvPHONG.DataSource = dbPh.LayPhong();
                //Lọc những phòng có tình trạng trống
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var lstphantu = from lpt in db.Phongs
                                where lpt.TinhTrang.Contains("Trống")
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
                dgvPHONG.Columns.RemoveAt(7);
                dgvPHONG.Columns.RemoveAt(6);
                dgvPHONG.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            SinhMaHD();
            dgvHDDat.Rows[0].Cells[3].Value = this.dtime_NgayDuocDat.Value.Date;
            LoadData();
        }

        private void txtTenNguoiDat_TextChanged(object sender, EventArgs e)
        {
            dgvHDDat.Rows[0].Cells[1].Value = txtTenNguoiDat.Text;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            dgvHDDat.Rows[0].Cells[2].Value = txtSDT.Text;
        }

        private void ThemNguoiDatvaPhongDat_Button_Click(object sender, EventArgs e)
        {
            int r = dgvPHONG.CurrentCell.RowIndex;
            BLPhong_NguoiDat dbPh_ND = new BLPhong_NguoiDat();
            BLPhong db_P = new BLPhong();
            BLNguoiDat dbND = new BLNguoiDat();           
            dbND.ThemNguoiDat(dgvHDDat.Rows[0].Cells[0].Value.ToString(), txtTenNguoiDat.Text, txtSDT.Text, this.dtime_NgayDuocDat.Value.Date.ToString(), ref err);
            LoadData();
            for (int i = 0; i < n; i++)
            {            
                dbPh_ND.ThemPhong_NguoiDat(dgvHDDat.Rows[0].Cells[0].Value.ToString(), m[i].ToString(), ref err);
                db_P.CapNhatPhong(m[i], dgvPHONG.Rows[r].Cells[1].Value.ToString(),
                    "Đã Đặt", Convert.ToDouble(dgvPHONG.Rows[r].Cells[3].Value),
                    dgvPHONG.Rows[r].Cells[4].Value.ToString(), dgvPHONG.Rows[r].Cells[5].Value.ToString(), ref err);
                r = dgvPHONG.CurrentCell.RowIndex;
                LoadData();
            }
            MessageBox.Show("Đã thêm xong!");
            dgvHDDat.Rows.Clear();

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            dgvHDDat.Rows.Clear();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            int r = dgvPHONG.CurrentCell.RowIndex;
            if (temp == dgvPHONG.Rows[r].Cells[0].Value.ToString())
            {
                MessageBox.Show("Bạn đã chọn mục này!");
            }
            else
            {
                dgvHDDat.Rows[0].Cells[4].Value = dgvHDDat.Rows[0].Cells[4].Value + "- " + dgvPHONG.Rows[r].Cells[0].Value.ToString();
                temp = dgvPHONG.Rows[r].Cells[4].Value.ToString();
                m[n++] = dgvPHONG.Rows[r].Cells[4].Value.ToString();
            }
        }
        private void SinhMaHD()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var counts = db.NguoiDats.Count();
            if (counts < 9)
            {
                dgvHDDat.Rows[0].Cells[0].Value = "M0" + (counts + 1).ToString();
            }
            else
            {
                dgvHDDat.Rows[0].Cells[0].Value = "M" + (counts + 1).ToString();
            }
        }

        private void dtime_NgayDuocDat_ValueChanged(object sender, EventArgs e)
        {
            dgvHDDat.Rows[0].Cells[3].Value = this.dtime_NgayDuocDat.Value.Date;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã phòng")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.MaPhong.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Loại phòng")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.LoaiPhong.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Tình trạng")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.TinhTrang.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Số điện thoại")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.SDT.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }

            if (this.cmb_TimKiem.Text == "Mã nhân viên phụ trách")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.MaNV.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Giá phòng")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.GiaPhong.ToString().Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }
            dgvPHONG.Columns.RemoveAt(7);
            dgvPHONG.Columns.RemoveAt(6);
        }
    }
}
