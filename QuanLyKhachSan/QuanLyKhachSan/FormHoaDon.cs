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
    public partial class FormHoaDon : Form
    {
        bool Them;
        string err;
        BLHoaDon dbKH = new BLHoaDon();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvHoaDon.DataSource = dbKH.LayHoaDon();
                dgvHoaDon.AutoResizeColumns();
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var inpt = from p in db.HoaDons
                           where p.Hide == false
                           select p;
                dgvHoaDon.DataSource = inpt;
                dgvHoaDon.Refresh();
                dgvHoaDon.Columns.RemoveAt(7);
                dgvHoaDon.Columns.RemoveAt(6);
                //this.txtMaHoaDon.ResetText();
                //this.txtMaKH.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvHoaDon_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            this.txtMaHoaDon.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            this.txtMaKH.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            dtime_NgayThue.Value = Convert.ToDateTime(dgvHoaDon.Rows[r].Cells[2].Value.ToString());
            dtime_NgayTra.Value = Convert.ToDateTime(dgvHoaDon.Rows[r].Cells[3].Value.ToString());
            this.txtGiaTien.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
            this.dtime_NgayXuatHoaDon.Value = Convert.ToDateTime(dgvHoaDon.Rows[r].Cells[5].Value.ToString());
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            BLHoaDon blP = new BLHoaDon();
            blP.CapNhatHoaDon(this.txtMaHoaDon.Text, this.txtMaKH.Text,
                this.dtime_NgayThue.Value.Date.ToString(), this.dtime_NgayTra.Value.Date.ToString(),Convert.ToDouble(this.txtGiaTien.Text), this.dtime_NgayXuatHoaDon.Value.Date.ToString(), ref err);
            LoadData();
            MessageBox.Show("Đã sửa xong!");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                string strKH = dgvHoaDon.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbKH.XoaHoaDon(ref err, strKH);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvHoaDon_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaKH.Focus();
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ResetText();
            this.btn_Sua.Enabled = true;
            this.btn_Xoa.Enabled = true;

            this.btn_Luu.Enabled = false;
            this.btn_Huy.Enabled = false;
            this.panel1.Enabled = false;
            dgvHoaDon_CellClick(null, null);
        }
        private void ResetText()
        {
            this.txtMaHoaDon.ResetText();
            this.txtMaKH.ResetText();
            this.txtGiaTien.ResetText();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            cmb_Ngay.Enabled = false;
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã hóa đơn")
            {
                var lstphantu = from lpt in db.HoaDons
                                where lpt.MaHoaDon.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvHoaDon.DataSource = lstphantu;
                dgvHoaDon.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Mã khách hàng")
            {
                var lstphantu = from lpt in db.HoaDons
                                where lpt.MaKH.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvHoaDon.DataSource = lstphantu;
                dgvHoaDon.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Ngày thuê")
            {
                if (this.cmb_Ngay.Text == "Ngày")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayThue.Value.Day.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
                if (this.cmb_Ngay.Text == "Tháng")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayThue.Value.Month.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
                if (this.cmb_Ngay.Text == "Năm")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayThue.Value.Year.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
            }
            if (this.cmb_TimKiem.Text == "Ngày trả phòng")
            {
                if (this.cmb_Ngay.Text == "Ngày")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayTraPhong.Value.Day.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
                if (this.cmb_Ngay.Text == "Tháng")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayTraPhong.Value.Month.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
                if (this.cmb_Ngay.Text == "Năm")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayTraPhong.Value.Year.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
            }
            if (this.cmb_TimKiem.Text == "Giá tiền")
            {
                var lstphantu = from lpt in db.HoaDons
                                where lpt.GiaTien.ToString().Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvHoaDon.DataSource = lstphantu;
                dgvHoaDon.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Ngày xuất hóa đơn")
            {
                if (this.cmb_Ngay.Text == "Ngày")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayXuatHoaDon.Value.Day.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
                if (this.cmb_Ngay.Text == "Tháng")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayXuatHoaDon.Value.Month.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
                if (this.cmb_Ngay.Text == "Năm")
                {
                    var lstphantu = from lpt in db.HoaDons
                                    where lpt.NgayXuatHoaDon.Value.Year.ToString().Contains(txtTimKiem.Text)
                                    where lpt.Hide == false
                                    select lpt;
                    dgvHoaDon.DataSource = lstphantu;
                    dgvHoaDon.Refresh();
                }
            }
            dgvHoaDon.Columns.RemoveAt(7);
            dgvHoaDon.Columns.RemoveAt(6);
        }

        private void cmb_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmb_TimKiem.Text == "Ngày thuê" || this.cmb_TimKiem.Text == "Ngày trả phòng" || this.cmb_TimKiem.Text == "Ngày xuất hóa đơn")
            {
                cmb_Ngay.Enabled = true;
            }
            else
            {
                cmb_Ngay.Text = "";
                cmb_Ngay.Enabled = false;
            }
        }
    }
}
