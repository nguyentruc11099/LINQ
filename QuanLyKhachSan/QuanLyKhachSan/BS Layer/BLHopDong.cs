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
    class BLHopDong
    {
        public System.Data.Linq.Table<HopDong> LayHopDong()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.HopDongs;
        }
        public bool ThemHopDong(string MaHopDong, string MaKH, string NgayThue, string NgayDuKienTraPhong, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            HopDong hdg = new HopDong();
            hdg.MaHopDong = MaHopDong;
            hdg.MaKH = MaKH;
            hdg.NgayThue = Convert.ToDateTime(NgayThue);
            hdg.NgayDuKienTraPhong = Convert.ToDateTime(NgayDuKienTraPhong);
            qlks.HopDongs.InsertOnSubmit(hdg);
            qlks.HopDongs.Context.SubmitChanges();
            return true;
        }
        public bool XoaHopDong(ref string err, string MaHopDong)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            HopDong hdg = new HopDong();
            var hdgQuery = from hdog in qlks.HopDongs
                          where hdog.MaHopDong == MaHopDong
                          select hdog;
            qlks.HopDongs.DeleteAllOnSubmit(hdgQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatHopDong(string MaHopDong, string MaKH, string NgayThue,string NgayDuKienTraPhong, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var hdgQuery = (from hdog in qlks.HopDongs
                           where hdog.MaHopDong == MaHopDong
                           select hdog).SingleOrDefault();
            if (hdgQuery != null)
            {
                hdgQuery.MaKH = MaKH;
                hdgQuery.NgayThue = Convert.ToDateTime(NgayThue);
                hdgQuery.NgayDuKienTraPhong = Convert.ToDateTime(NgayDuKienTraPhong);
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
