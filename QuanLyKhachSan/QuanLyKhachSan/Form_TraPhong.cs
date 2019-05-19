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
    public partial class Form_TraPhong : Form
    {
        string err;
        int row;
        string MaHoaDon;
        double S = 0;
        BLHopDong dbHD = new BLHopDong();
        BLKhachHang dbKH = new BLKhachHang();
        BLPhong_HD dbP_HD = new BLPhong_HD();
        BLDV_HD dbDV_HD = new BLDV_HD();
        BLHoaDon dbHDon = new BLHoaDon();
        public Form_TraPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var joinres = (from p in db.HopDongs
                              join t in db.KhachHangs on p.MaKH equals t.MaKH
                              select new
                              {
                                  MaHopDong = p.MaHopDong,
                                  MaKH = p.MaKH,
                                  TenKH = t.TenKH,
                                  NgayThue = p.NgayThue,
                                  NgayDuKienTraPhong = p.NgayDuKienTraPhong
                              });
                dgvHopDong.DataSource = joinres;
                dgvHopDong.Refresh();
                dgvKH_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void Form_TraPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            int r = dgvHopDong.CurrentCell.RowIndex;
            if (this.cmb_TimKiem.Text == "Mã khách hàng")
            {
                var lstphantu = (from p in db.HopDongs
                               join t in db.KhachHangs on p.MaKH equals t.MaKH
                               where p.MaKH.Contains(txtTimKiem.Text)
                               select new
                               {
                                   MaHopDong = p.MaHopDong,
                                   MaKH = p.MaKH,
                                   TenKH = t.TenKH,
                                   NgayThue = p.NgayThue,
                                   NgayDuKienTraPhong = p.NgayDuKienTraPhong
                               });
                dgvHopDong.DataSource = lstphantu;
                dgvHopDong.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Tên khách hàng")
            {
                var lstphantu = (from p in db.HopDongs
                                 join t in db.KhachHangs on p.MaKH equals t.MaKH
                                 where t.TenKH.Contains(txtTimKiem.Text)
                                 select new
                                 {
                                     MaHopDong = p.MaHopDong,
                                     MaKH = p.MaKH,
                                     TenKH = t.TenKH,
                                     NgayThue = p.NgayThue,
                                     NgayDuKienTraPhong = p.NgayDuKienTraPhong
                                 });
                dgvHopDong.DataSource = lstphantu;
                dgvHopDong.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Mã hợp đồng")
            {
                var lstphantu = (from p in db.HopDongs
                                 join t in db.KhachHangs on p.MaKH equals t.MaKH
                                 where p.MaHopDong.Contains(txtTimKiem.Text)
                                 select new
                                 {
                                     MaHopDong = p.MaHopDong,
                                     MaKH = p.MaKH,
                                     TenKH = t.TenKH,
                                     NgayThue = p.NgayThue,
                                     NgayDuKienTraPhong = p.NgayDuKienTraPhong
                                 });
                dgvHopDong.DataSource = lstphantu;
                dgvHopDong.Refresh();
            }
        }

        private void btn_ChonKH_Click(object sender, EventArgs e)
        {

            int r = dgvHopDong.CurrentCell.RowIndex;
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var lstphantu = (from lpt in db.PhongvaHopDongs
                             join lpt1 in db.Phongs on lpt.MaPhong equals lpt1.MaPhong
                             join lpt3 in db.HopDongs on lpt.MaHD equals lpt3.MaHopDong
                            where lpt.MaHD.Contains(dgvHopDong.Rows[r].Cells[0].Value.ToString())
                            select new
                            {
                                MaHD = lpt.MaHD,
                                MaPhong = lpt.MaPhong,
                                LoaiPhong = lpt1.LoaiPhong,
                                GiaPhong = lpt1.GiaPhong,
                                NgayThue = lpt3.NgayThue,
                                NgayHetHan = lpt3.NgayDuKienTraPhong
                            });
            dgvPhong_HD.DataSource = lstphantu;
            dgvPhong_HD.Refresh();

            var lstphantu1 = (from lpt in db.DichVuvaHDs
                              join lpt1 in db.DichVus on lpt.MaDV equals lpt1.MaDV
                              join lpt2 in db.HopDongs on lpt.MaHD equals lpt2.MaHopDong
                              where lpt.MaHD.Contains(dgvHopDong.Rows[r].Cells[0].Value.ToString())
                              select new
                              {
                                  MaHD = lpt.MaHD,
                                  MaDV = lpt1.MaDV,
                                  TenDV = lpt1.TenDV,
                                  GiaDV = lpt1.GiaDV,
                                  SoNgaySD = lpt.SoNgaySD
                             });
            dgvDV_HD.DataSource = lstphantu1;
            dgvDV_HD.Refresh();

            TinhTien();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void TinhTien()
        {
            TinhTien_RichTextBox.Clear();
            row = dgvHopDong.CurrentCell.RowIndex;
            S = 0;
            TimeSpan time = Convert.ToDateTime(dgvHopDong.Rows[row].Cells[4].Value).Subtract(Convert.ToDateTime(dgvHopDong.Rows[row].Cells[3].Value));
            TinhTien_RichTextBox.AppendText("Hợp đồng: " + dgvHopDong.Rows[row].Cells[0].Value.ToString() + "\n");
            TinhTien_RichTextBox.AppendText("Khách hàng: " + dgvHopDong.Rows[row].Cells[2].Value.ToString() + "\n");
            TinhTien_RichTextBox.AppendText("\nPhần tiền phòng: \n");
            for (int i = 0; i < dgvPhong_HD.Rows.Count; i++)
            {
                TinhTien_RichTextBox.AppendText("Khách đã thuê phòng " + dgvPhong_HD.Rows[i].Cells[1].Value.ToString() + " loại " + dgvPhong_HD.Rows[i].Cells[2].Value.ToString() + " với giá tiền mỗi ngày là " + dgvPhong_HD.Rows[i].Cells[3].Value.ToString() + " trong " + time.Days + " ngày \n");
                S += Convert.ToDouble(dgvPhong_HD.Rows[i].Cells[3].Value) * time.Days;
            }
            TinhTien_RichTextBox.AppendText("\nPhần tiền dịch vụ: \n");
            if (dgvDV_HD.Rows.Count < 1)
            {
                TinhTien_RichTextBox.AppendText("Không có sử dụng dịch vụ thêm nào ! \n");
            }
            else
            {
                for (int i = 0; i < dgvDV_HD.Rows.Count; i++)
                {
                    TinhTien_RichTextBox.AppendText("Khách đã sử dụng dịch vụ " + dgvDV_HD.Rows[i].Cells[2].Value.ToString() + " với giá tiền " + dgvDV_HD.Rows[i].Cells[4].Value.ToString() + " trong " + dgvDV_HD.Rows[i].Cells[3].Value.ToString() + " lần \n");
                    S += Convert.ToDouble(dgvDV_HD.Rows[i].Cells[4].Value) * Convert.ToDouble(dgvDV_HD.Rows[i].Cells[3].Value);
                }
            }
            time = DateTime.Now.Subtract(Convert.ToDateTime(dgvHopDong.Rows[row].Cells[4].Value));
            if (time.Days >= 1)
            {
                TinhTien_RichTextBox.AppendText(" Khach đã thanh toán tiền trễ hạn " + time.Days + " ngày nên bị phạt " + time.Days + " x 50000 = " + time.Days * 50000 + "\n");
                S += time.Days * 50000;
            }
            TinhTien_RichTextBox.AppendText("\nVậy tổng tiền phải thanh toán là: " + S + "\n");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            BLHoaDon dbHoaDon = new BLHoaDon();
            SinhMa();
            int r = dgvHopDong.CurrentCell.RowIndex;
            //dbHoaDon.ThemHoaDon(MaHoaDon, dgvHopDong.Rows[r].Cells[1].Value.ToString(),
            //    dgvHopDong.Rows[r].Cells[3].Value.ToString(),
            //    dgvHopDong.Rows[r].Cells[4].Value.ToString(), S,
            //    dtime_Today.Value.Date.ToString(), ref err);


            for (int i = 0; i < dgvPhong_HD.Rows.Count; i++)
            {
                BL_TraPhong dbTra = new BL_TraPhong();
                dbTra.CapNhatPhong(dgvPhong_HD.Rows[i].Cells[1].Value.ToString(), "Trống");
            }
            dgvDV_HD.Rows.Clear();
            dgvPhong_HD.Rows.Clear();
            dbDV_HD.XoaDichVuvaHD(ref err, dgvHopDong.Rows[r].Cells[0].Value.ToString());
            dbP_HD.XoaPhong_HD(ref err, dgvHopDong.Rows[r].Cells[0].Value.ToString());
            dbHD.XoaHopDong(ref err, dgvHopDong.Rows[r].Cells[0].Value.ToString());
            panel1.ResetText();
            if (dgvPhong_HD.Rows.Count == 0)
            {
                MessageBox.Show("Đã thanh toán");
                dbHoaDon.ThemHoaDon(MaHoaDon, dgvHopDong.Rows[r].Cells[1].Value.ToString(),
               dgvHopDong.Rows[r].Cells[3].Value.ToString(),
               dgvHopDong.Rows[r].Cells[4].Value.ToString(), S,
               dtime_Today.Value.Date.ToString(), ref err);
                LoadData();
            }
        }
        private void SinhMa()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var counts = db.HoaDons.Count();
            if (counts < 10)
            {
                MaHoaDon = "P0" + (counts +1).ToString();
            }
            else
            {
                MaHoaDon = "P" + (counts +1).ToString();
            }
        }
    }
}
