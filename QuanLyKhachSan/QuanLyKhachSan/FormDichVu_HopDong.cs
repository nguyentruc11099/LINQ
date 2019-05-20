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
    public partial class FormDichVu_HopDong : Form
    {
        bool Them;
        string err;
        BLDV_HD dbNV = new BLDV_HD();
        public FormDichVu_HopDong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvDV_HD.DataSource = dbNV.LayDichVuvaHD();
                dgvDV_HD.AutoResizeColumns();
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var inpt = from p in db.DichVuvaHDs
                           where p.Hide == false
                           select p;
                dgvDV_HD.DataSource = inpt;
                dgvDV_HD.Refresh();
                dgvDV_HD.Columns.RemoveAt(5);
                dgvDV_HD.Columns.RemoveAt(4);
                dgvDV_HD.Columns.RemoveAt(3);
                dgvDV_HD.AutoResizeColumns();
                //this.txtMaHD.ResetText();
                //this.textBox2.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvDV_HD_CellClick(null, null);
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
                    BLDV_HD blP = new BLDV_HD();
                    blP.ThemDichVuvaHD(this.txtMaHD.Text, this.txtMaDV.Text,
                    Convert.ToInt32(this.txtSoNgaySD.Text), ref err);
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
                BLDV_HD blP = new BLDV_HD();
                blP.CapNhatDichVuvaHD(this.txtMaHD.Text, this.txtMaDV.Text,
                    Convert.ToInt32(this.txtSoNgaySD.Text), ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }        

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ResetText();
            this.btn_Sua.Enabled = true;
            this.btn_Xoa.Enabled = true;

            this.btn_Luu.Enabled = false;
            this.btn_Huy.Enabled = false;
            this.panel1.Enabled = false;
            dgvDV_HD_CellClick(null, null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvDV_HD_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaHD.Enabled = false;
            this.txtMaDV.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvDV_HD.CurrentCell.RowIndex;
                string strNV = dgvDV_HD.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaDichVuvaHD(ref err, strNV);
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
            Close();
        }

        private void dgvDV_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDV_HD.CurrentCell.RowIndex;
            this.txtMaHD.Text = dgvDV_HD.Rows[r].Cells[0].Value.ToString();
            this.txtMaDV.Text = dgvDV_HD.Rows[r].Cells[1].Value.ToString();
            this.txtSoNgaySD.Text = dgvDV_HD.Rows[r].Cells[2].Value.ToString();
        }

        private void FormDichVu_HopDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ResetText()
        {
            this.txtMaHD.ResetText();
            this.txtMaDV.ResetText();
            this.txtSoNgaySD.ResetText();
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
                var lstphantu = from lpt in db.DichVuvaHDs
                                where lpt.MaHD.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvDV_HD.DataSource = lstphantu;
                dgvDV_HD.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Mã dịch vụ")
            {
                var lstphantu = from lpt in db.DichVuvaHDs
                                where lpt.MaDV.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvDV_HD.DataSource = lstphantu;
                dgvDV_HD.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Số ngày sử dụng")
            {
                var lstphantu = from lpt in db.DichVuvaHDs
                                where lpt.SoNgaySD.ToString().Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvDV_HD.DataSource = lstphantu;
                dgvDV_HD.Refresh();
            }
            dgvDV_HD.Columns.RemoveAt(5);
            dgvDV_HD.Columns.RemoveAt(4);
            dgvDV_HD.Columns.RemoveAt(3);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaHD.Enabled = true;
            ResetText();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaHD.Focus();
        }
    }
}

