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
    class BLPhong_NguoiDat
    {
        public System.Data.Linq.Table<PhongvaNguoiDat> LayPhong_NguoiDat()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.PhongvaNguoiDats;
        }
        public bool ThemPhong_NguoiDat(string MaNguoiDat, string MaPhong, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            PhongvaNguoiDat dv = new PhongvaNguoiDat();
            dv.MaNguoiDat = MaNguoiDat;
            dv.MaPhong = MaPhong;
            dv.Hide = false;
            qlks.PhongvaNguoiDats.InsertOnSubmit(dv);
            qlks.PhongvaNguoiDats.Context.SubmitChanges();
            return true;
        }
        public bool XoaPhong_NguoiDat(ref string err, string MaNguoiDat)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            PhongvaNguoiDat dv = new PhongvaNguoiDat();
            var dvQuery = (from dvu in qlks.PhongvaNguoiDats
                           where dvu.MaNguoiDat == MaNguoiDat
                           where dvu.Hide == false
                           select dvu).SingleOrDefault();
            dvQuery.Hide = true;
            //qlks.PhongvaNguoiDats.DeleteAllOnSubmit(dvQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatPhong_NguoiDat(string MaNguoiDat, string MaPhong, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var dvQuery = (from dvu in qlks.PhongvaNguoiDats
                           where dvu.MaNguoiDat == MaNguoiDat
                           where dvu.Hide == false
                           select dvu).SingleOrDefault();
            if (dvQuery != null)
            {
                dvQuery.MaPhong = MaPhong;
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
