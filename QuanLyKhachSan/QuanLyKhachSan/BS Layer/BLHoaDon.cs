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
    class BLHoaDon
    {
        public System.Data.Linq.Table<HoaDon> LayHoaDon()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.HoaDons;
        }
        public bool ThemHoaDon(string MaHoaDon, string MaKH, string NgayThue, string NgayTra, double GiaTien,string NgayXuatHoaDon,  ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            HoaDon ph = new HoaDon();
            ph.MaHoaDon = MaHoaDon;
            ph.MaKH = MaKH;
            ph.NgayThue = Convert.ToDateTime(NgayThue);
            ph.NgayTraPhong = Convert.ToDateTime(NgayTra);
            ph.GiaTien = GiaTien;
            ph.NgayXuatHoaDon = Convert.ToDateTime(NgayXuatHoaDon);
            ph.Hide = false;
            qlks.HoaDons.InsertOnSubmit(ph);
            qlks.HoaDons.Context.SubmitChanges();
            return true;
        }
        public bool XoaHoaDon(ref string err, string MaHoaDon)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            HoaDon ph = new HoaDon();
            var phQuery = (from phg in qlks.HoaDons
                          where phg.MaHoaDon == MaHoaDon
                          where phg.Hide == false
                           select phg).SingleOrDefault();
            phQuery.Hide = true;
            //qlks.HoaDons.DeleteAllOnSubmit(phQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatHoaDon(string MaHoaDon, string MaKH, string NgayThue, string NgayTra, double GiaTien, string NgayXuatHoaDon, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var phQuery = (from phg in qlks.HoaDons
                           where phg.MaHoaDon == MaHoaDon
                           where phg.Hide == false
                           select phg).SingleOrDefault();
            if (phQuery != null)
            {
                phQuery.MaKH = MaKH;
                phQuery.NgayThue = Convert.ToDateTime(NgayThue);
                phQuery.NgayTraPhong = Convert.ToDateTime(NgayTra);
                phQuery.GiaTien = GiaTien;
                phQuery.NgayXuatHoaDon = Convert.ToDateTime(NgayXuatHoaDon);
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
