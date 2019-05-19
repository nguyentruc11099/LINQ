using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.BS_Layer
{
    class BLNhanVien
    {
        public System.Data.Linq.Table<NhanVien> LayNhanVien()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.NhanViens;
        }
        public bool ThemNhanVien(string MaNV, string TenNV, string ChucVu, double LuongNV, string NgaySinh, string GioiTinh, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.TenNV = TenNV;
            nv.ChucVu = ChucVu;
            nv.Luong = LuongNV;
            nv.NgaySinh = Convert.ToDateTime(NgaySinh);
            nv.GioiTinh = GioiTinh;
            nv.Hide = false;
            qlks.NhanViens.InsertOnSubmit(nv);
            qlks.NhanViens.Context.SubmitChanges();
            return true;
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            NhanVien nv = new NhanVien();
            var nvQuery = (from nvn in qlks.NhanViens
                          where nvn.MaNV == MaNV
                          where nvn.Hide == false
                          select nvn).SingleOrDefault();
            nvQuery.Hide = true;
            //qlks.NhanViens.DeleteAllOnSubmit(nvQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatNhanVien(string MaNV, string TenNV, string ChucVu, double LuongNV, string NgaySinh, string GioiTinh, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var nvQuery = (from nvn in qlks.NhanViens
                           where nvn.MaNV == MaNV
                           where nvn.Hide == false
                           select nvn).SingleOrDefault();
            if (nvQuery != null)
            {
                nvQuery.TenNV = TenNV;
                nvQuery.ChucVu = ChucVu;
                nvQuery.Luong = LuongNV;
                nvQuery.NgaySinh = Convert.ToDateTime(NgaySinh);
                nvQuery.GioiTinh = GioiTinh;
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
