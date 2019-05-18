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
    public partial class FormPhong_HD : Form
    {
        bool Them;
        string err;
        BLPhong_HD dbNV = new BLPhong_HD();
        public FormPhong_HD()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvPhong_HD.DataSource = dbNV.LayPhong_HD();
                dgvPhong_HD.AutoResizeColumns();
                dgvPhong_HD.Columns.RemoveAt(3);
                dgvPhong_HD.Columns.RemoveAt(2);
                //this.txtMaHD.ResetText();
                //this.textBox2.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvPhong_HD_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }

        private void dgvPhong_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhong_HD.CurrentCell.RowIndex;
            this.txtMaHD.Text = dgvPhong_HD.Rows[r].Cells[0].Value.ToString();
            this.txtMaPhong.Text = dgvPhong_HD.Rows[r].Cells[1].Value.ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                try
                {
                    BLPhong_HD blP = new BLPhong_HD();
                    blP.ThemPhong_HD(this.txtMaHD.Text, this.txtMaPhong.Text,
                     ref err);
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
                BLPhong_HD blP = new BLPhong_HD();
                blP.CapNhatPhong_HD(this.txtMaHD.Text, this.txtMaPhong.Text,
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
            dgvPhong_HD_CellClick(null, null);
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvPhong_HD_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaHD.Enabled = false;
            this.txtMaPhong.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvPhong_HD.CurrentCell.RowIndex;
                string strNV = dgvPhong_HD.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaPhong_HD(ref err, strNV);
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();
        }
        private void ResetText()
        {
            this.txtMaHD.ResetText();
            this.txtMaPhong.ResetText();
        }
        private void ChonTiemKiem()
        {

            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            if (this.cmb_TimKiem.Text == "Mã hợp đồng")
            {
                var lstphantu = from lpt in db.PhongvaHopDongs
                                where lpt.MaHD.Contains(txtTimKiem.Text)
                                select lpt;
                dgvPhong_HD.DataSource = lstphantu;
                dgvPhong_HD.Refresh();
            }
            if (this.cmb_TimKiem.Text == "Mã phòng")
            {
                var lstphantu = from lpt in db.PhongvaHopDongs
                                where lpt.MaPhong.Contains(txtTimKiem.Text)
                                select lpt;
                dgvPhong_HD.DataSource = lstphantu;
                dgvPhong_HD.Refresh();
            }
            dgvPhong_HD.Columns.RemoveAt(3);
            dgvPhong_HD.Columns.RemoveAt(2);
        }

        private void FormPhong_HD_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
