using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BS_Layer
{
    class BLDangNhap
    {
        public bool LayTaiKhoan(string taikhoan, string matkhau, string chucvu)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var text = qlks.NhanViens.Where(x => x.MaNV == taikhoan && x.Password == matkhau && x.ChucVu == chucvu).FirstOrDefault();
            if (text != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}
