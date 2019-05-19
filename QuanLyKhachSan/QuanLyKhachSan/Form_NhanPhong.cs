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
    public partial class Form_NhanPhong : Form
    {
        string err;
        BLPhong dbPh = new BLPhong();
        BLKhachHang dbKH = new BLKhachHang();
        string temp = "";
        string[] m = new string[50];
        int n = 0;
        public Form_NhanPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvPHONG.DataSource = dbPh.LayPhong();
                dgvPHONG.AutoResizeColumns();
                dgvPHONG.Columns.RemoveAt(6);
                //Lọc những phòng có tình trạng trống
                QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
                var lstphantu = from lpt in db.Phongs
                                where lpt.TinhTrang.Contains("Trống")
                                select lpt;
                dgvPHONG.DataSource = lstphantu;
                dgvPHONG.Refresh();
                dgvPHONG.Columns.RemoveAt(6);

                dgvKH.DataSource = dbKH.LayKhachHang();
                dgvKH.AutoResizeColumns();
                dgvPHONG_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_NhanPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvHD.Rows[0].Cells[3].Value = dtime_Today.Value.Date;
        }

        private void rbtn_old_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_old.Checked == true)
            {
                txtMaKH.ResetText();
                this.panel_ThemKH.Enabled = false;
            }
            else
            {
                SinhMa();
                txtMaKH.Enabled = false;
                this.panel_ThemKH.Enabled = true;
            }
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

        private void btn_ChonKH_Click(object sender, EventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            dgvHD.Rows[0].Cells[2].Value = dgvKH.Rows[r].Cells[0].Value.ToString();
        }

        private void btn_ChonPhong_Click(object sender, EventArgs e)
        {
            int r = dgvPHONG.CurrentCell.RowIndex;
            if (temp == dgvPHONG.Rows[r].Cells[0].Value.ToString())
            {
                MessageBox.Show("Bạn đã chọn mục này!");
            }
            else
            {
                dgvHD.Rows[0].Cells[1].Value = dgvHD.Rows[0].Cells[1].Value + ", " + dgvPHONG.Rows[r].Cells[0].Value.ToString();
                temp = dgvPHONG.Rows[r].Cells[0].Value.ToString();
                m[n++] = dgvPHONG.Rows[r].Cells[0].Value.ToString();
            }
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            BLPhong_HD db_P_HD = new BLPhong_HD();
            if (dgvHD.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng!");
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
                    int q = dgvPHONG.CurrentCell.RowIndex;
                    BLHopDong db_HD = new BLHopDong();
                    BLPhong db_P = new BLPhong();
                    db_HD.ThemHopDong(this.txtMaHD.Text, dgvKH.Rows[r].Cells[0].Value.ToString(),
                        dgvHD.Rows[0].Cells[3].Value.ToString(), this.dtime_NgayDuKien.Value.Date.ToString(), ref err);
                    LoadData();
                    for (int i = 0; i < n; i++)
                    {
                        db_P_HD.ThemPhong_HD(this.txtMaHD.Text,m[i], ref err);
                        db_P.CapNhatPhong(m[i], dgvPHONG.Rows[q].Cells[1].Value.ToString(), 
                            "Đã Thuê", Convert.ToDouble(dgvPHONG.Rows[q].Cells[3].Value), 
                            dgvPHONG.Rows[q].Cells[4].Value.ToString(), dgvPHONG.Rows[q].Cells[5].Value.ToString(), ref err);
                        q = dgvPHONG.CurrentCell.RowIndex;
                        LoadData();
                    }
                    MessageBox.Show("Đã thêm xong!");
                }
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[0].Value = this.txtMaHD.Text;
        }
        private void ResetHD()
        {
            panel_ThemKH.Enabled = false;
            dgvHD.Rows.Clear();
            dgvHD.Rows[0].Cells[3].Value = dtime_Today.Value.Date;
           
        }

        private void dtime_Today_ValueChanged(object sender, EventArgs e)
        {
            dgvHD.Rows[0].Cells[3].Value = dtime_Today.Value.Date;
        }

        private void dtime_NgayDuKien_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diff = dtime_NgayDuKien.Value - dtime_Today.Value;
            numUD_SoNgayDuKien.Value = Convert.ToDecimal(diff.Days) + 1;
        }
        private void SinhMa()
        {
            string a = this.dgvKH.Rows[this.dgvKH.Rows.Count - 2].Cells[0].Value.ToString();
            int b = Convert.ToInt32(a.Substring(1)) + 1;
            if (b < 10)
            {
                txtMaKH.Text = "K0" + b.ToString();
            }
            else
            {
                txtMaKH.Text = "N" + b.ToString();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetHD();
        }
    }
}
