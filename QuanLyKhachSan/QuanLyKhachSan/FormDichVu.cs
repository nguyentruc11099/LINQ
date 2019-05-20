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
    public partial class FormDichVu : Form
    {
        bool Them;
        string err;
        BLDichVu dbNV = new BLDichVu();
        public FormDichVu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvDICHVU.DataSource = dbNV.LayDichVu();
                dgvDICHVU.AutoResizeColumns();
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var inpt = from p in db.DichVus
                           where p.Hide == false
                           select p;
                dgvDICHVU.DataSource = inpt;
                dgvDICHVU.Refresh();
                dgvDICHVU.Columns.RemoveAt(3);
                //this.txtMaDV.ResetText();
                //this.txtTenDV.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvDICHVU_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void FormDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDICHVU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDICHVU.CurrentCell.RowIndex;
            this.txtMaDV.Text = dgvDICHVU.Rows[r].Cells[0].Value.ToString();
            this.txtTenDV.Text = dgvDICHVU.Rows[r].Cells[1].Value.ToString();
            this.txtGiaDV.Text = dgvDICHVU.Rows[r].Cells[2].Value.ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaDV.Enabled = true;
            ResetText();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaDV.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvDICHVU_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaDV.Enabled = false;
            this.txtTenDV.Focus();
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                try
                {
                    BLDichVu blP = new BLDichVu();
                    blP.ThemDichVu(this.txtMaDV.Text, this.txtTenDV.Text,
                    Convert.ToDouble(this.txtGiaDV.Text), ref err);
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
                BLDichVu blP = new BLDichVu();
                blP.CapNhatDichVu(this.txtMaDV.Text, this.txtTenDV.Text,
                   Convert.ToDouble(this.txtGiaDV.Text), ref err);
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
            dgvDICHVU_CellClick(null, null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvDICHVU.CurrentCell.RowIndex;
                string strNV = dgvDICHVU.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaDichVu(ref err, strNV);
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
            this.txtMaDV.ResetText();
            this.txtTenDV.ResetText();
            this.txtGiaDV.ResetText();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void ChonTiemKiem()
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã dịch vụ")
            {
                var lstphantu = from lpt in db.DichVus
                                where lpt.MaDV.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvDICHVU.DataSource = lstphantu;
                dgvDICHVU.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Tên dịch vụ")
            {
                var lstphantu = from lpt in db.DichVus
                                where lpt.TenDV.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvDICHVU.DataSource = lstphantu;
                dgvDICHVU.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Giá dịch vụ")
            {
                var lstphantu = from lpt in db.DichVus
                                where lpt.GiaDV.ToString().Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvDICHVU.DataSource = lstphantu;
                dgvDICHVU.Refresh();
            }
            dgvDICHVU.Columns.RemoveAt(3);
        }

        private void cmb_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
