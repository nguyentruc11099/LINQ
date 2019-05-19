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
    class BLNguoiDat
    {
        public System.Data.Linq.Table<NguoiDat> LayNguoiDat()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.NguoiDats;
        }
        public bool ThemNguoiDat(string MaNguoiDat, string TenNguoiDat, string SDT, string NgayHetHan, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            NguoiDat ph = new NguoiDat();
            ph.MaNguoiDat = MaNguoiDat;
            ph.TenNguoiDat = TenNguoiDat;
            ph.SDT = SDT;
            ph.NgayHetHan = Convert.ToDateTime(NgayHetHan);
            ph.Hide = false;
            qlks.NguoiDats.InsertOnSubmit(ph);
            qlks.NguoiDats.Context.SubmitChanges();
            return true;
        }
        public bool XoaNguoiDat(ref string err, string MaNguoiDat)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            NguoiDat ph = new NguoiDat();
            var phQuery = (from phg in qlks.NguoiDats
                           where phg.MaNguoiDat == MaNguoiDat
                           where phg.Hide == false
                           select phg).SingleOrDefault();
            phQuery.Hide = true;
            //qlks.NguoiDats.DeleteAllOnSubmit(phQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatNguoiDat(string MaNguoiDat, string TenNguoiDat, string SDT, string NgayHetHan, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var phQuery = (from phg in qlks.NguoiDats
                           where phg.MaNguoiDat == MaNguoiDat
                           where phg.Hide == false
                           select phg).SingleOrDefault();
            if (phQuery != null)
            {
                phQuery.TenNguoiDat = TenNguoiDat;
                phQuery.SDT = SDT;
                phQuery.NgayHetHan = Convert.ToDateTime(NgayHetHan);
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
