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
    public partial class FormHopDong : Form
    {
        bool Them;
        string err;
        BLHopDong dbNV = new BLHopDong();
        public FormHopDong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvHopDong.DataSource = dbNV.LayHopDong();
                dgvHopDong.AutoResizeColumns();
                //this.txtMaHopDong.ResetText();
                //this.txtMaKH.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvHopDong_CellClick(null, null);
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
            if (Them == true)
            {
                try
                {
                    BLHopDong blP = new BLHopDong();
                    blP.ThemHopDong(this.txtMaHopDong.Text, this.txtMaKH.Text,
                    dtime_NgayThue.Value.Date.ToString(), ref err);
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
                BLHopDong blP = new BLHopDong();
                blP.CapNhatHopDong(this.txtMaHopDong.Text, this.txtMaKH.Text,
                   dtime_NgayThue.Value.Date.ToString(), ref err);
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
            dgvHopDong_CellClick(null, null);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaHopDong.Enabled = true;
            ResetText();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaHopDong.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvHopDong_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaHopDong.Enabled = false;
            this.txtMaKH.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvHopDong.CurrentCell.RowIndex;
                string strNV = dgvHopDong.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaHopDong(ref err, strNV);
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

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHopDong.CurrentCell.RowIndex;
            this.txtMaHopDong.Text = dgvHopDong.Rows[r].Cells[0].Value.ToString();
            this.txtMaKH.Text = dgvHopDong.Rows[r].Cells[1].Value.ToString();
            dtime_NgayThue.Value = Convert.ToDateTime(dgvHopDong.Rows[r].Cells[2].Value.ToString());
        }
        private void ResetText()
        {
            this.txtMaHopDong.ResetText();
            this.txtMaKH.ResetText();
            //this.txtNgayThue.ResetText();
        }

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            LoadData();
            cmb_NgayThue.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã hợp đồng")
            {
                var lstphantu = from lpt in db.HopDongs
                                where lpt.MaHopDong.Contains(txtTimKiem.Text)
                                select lpt;
                dgvHopDong.DataSource = lstphantu;
                dgvHopDong.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Mã khách hàng")
            {
                var lstphantu = from lpt in db.HopDongs
                                where lpt.MaKH.Contains(txtTimKiem.Text)
                                select lpt;
                dgvHopDong.DataSource = lstphantu;
                dgvHopDong.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Ngày thuê")
            {
                if (this.cmb_NgayThue.Text == "Ngày")
                {
                    var lstphantu = from lpt in db.HopDongs
                                    where lpt.NgayThue.Value.Day.ToString().Contains(txtTimKiem.Text)
                                    select lpt;
                    dgvHopDong.DataSource = lstphantu;
                    dgvHopDong.Refresh();
                }
                if (this.cmb_NgayThue.Text == "Tháng")
                {
                    var lstphantu = from lpt in db.HopDongs
                                    where lpt.NgayThue.Value.Month.ToString().Contains(txtTimKiem.Text)
                                    select lpt;
                    dgvHopDong.DataSource = lstphantu;
                    dgvHopDong.Refresh();
                }
                if (this.cmb_NgayThue.Text == "Năm")
                {
                    var lstphantu = from lpt in db.HopDongs
                                    where lpt.NgayThue.Value.Year.ToString().Contains(txtTimKiem.Text)
                                    select lpt;
                    dgvHopDong.DataSource = lstphantu;
                    dgvHopDong.Refresh();
                }
            }
        }

        private void cmb_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_TimKiem.Text == "Ngày thuê")
            {
                cmb_NgayThue.Enabled = true;
            }
            else
            {
                cmb_NgayThue.Text = "";
                cmb_NgayThue.Enabled = false;
            }
        }
    }
}
