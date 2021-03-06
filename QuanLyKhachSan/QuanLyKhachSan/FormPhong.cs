﻿using System;
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
    public partial class FormPhong : Form
    {
        bool Them;
        string err;
        BLPhong dbPh = new BLPhong();
        public FormPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {               
                dgvPHONG.DataSource = dbPh.LayPhong();
                dgvPHONG.AutoResizeColumns();
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var inpt = from p in db.Phongs
                           where p.Hide == false
                           select p;
                dgvPHONG.DataSource = inpt;
                dgvPHONG.Refresh();
                dgvPHONG.Columns.RemoveAt(7);
                dgvPHONG.Columns.RemoveAt(6);
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvPHONG_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void dgvPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tt = checkTinhTrang();
            int r = dgvPHONG.CurrentCell.RowIndex;
            this.txtMaPhong.Text = dgvPHONG.Rows[r].Cells[0].Value.ToString();
            this.cmb_LoaiPhong.Text = dgvPHONG.Rows[r].Cells[1].Value.ToString();
            tt = dgvPHONG.Rows[r].Cells[2].Value.ToString();
            if (tt.Length == 5)
            {
                this.rbtn_Trong.Checked = true;
            }
            else this.rbtn_DaThue.Checked = true;
            this.txtGiaPhong.Text = dgvPHONG.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text = dgvPHONG.Rows[r].Cells[4].Value.ToString();
            this.txtMaNV.Text = dgvPHONG.Rows[r].Cells[5].Value.ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaPhong.Enabled = true;
            ResetText();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaPhong.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvPHONG_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            rbtn_DaThue.Enabled = rbtn_Trong.Enabled = false;
            this.txtMaPhong.Enabled = false;
            this.txtGiaPhong.Focus();
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvPHONG.CurrentCell.RowIndex;
                string strPhong = dgvPHONG.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbPh.XoaPhong(ref err, strPhong);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
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
            dgvPHONG_CellClick(null, null);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string tt = checkTinhTrang();
            if (Them == true)
            {
                try
                {
                    BLPhong blP = new BLPhong();
                    blP.ThemPhong(this.txtMaPhong.Text,
                    this.cmb_LoaiPhong.Text,tt, Convert.ToDouble(this.txtGiaPhong.Text),
                    this.txtSDT.Text, this.txtMaNV.Text, ref err);
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
                BLPhong blP = new BLPhong();
                blP.CapNhatPhong(this.txtMaPhong.Text,
                    this.cmb_LoaiPhong.Text, tt, Convert.ToDouble(this.txtGiaPhong.Text),
                    this.txtSDT.Text, this.txtMaNV.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ResetText()
        {
            this.txtMaPhong.ResetText();
            this.txtGiaPhong.ResetText();
            rbtn_DaThue.Checked = false;
            rbtn_Trong.Checked = false;
            this.txtMaNV.ResetText();
            this.txtSDT.ResetText();
        }
        private string checkTinhTrang()
        {
            if (rbtn_DaThue.Checked == true)
            {
                return rbtn_DaThue.Text;
            }
            else return rbtn_Trong.Text;
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
            if(this.cmb_TimKiem.Text == "Tình trạng")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.TinhTrang.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }
            if(this.cmb_TimKiem.Text == "Số điện thoại")
            {
                var lstphantu = from lpt in db.Phongs
                                where lpt.SDT.Contains(txtTimKiem.Text)
                                where lpt.Hide == false
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
            }

            if(this.cmb_TimKiem.Text == "Mã nhân viên phụ trách")
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChonTiemKiem();

        }

        private void cmb_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
