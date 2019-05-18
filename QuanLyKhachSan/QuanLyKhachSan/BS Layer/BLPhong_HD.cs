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
    class BLPhong_HD
    {
        public System.Data.Linq.Table<PhongvaHopDong> LayPhong_HD()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.PhongvaHopDongs;
        }
        public bool ThemPhong_HD(string MaHD, string MaPhong, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            PhongvaHopDong dv = new PhongvaHopDong();
            dv.MaHD = MaHD;
            dv.MaPhong = MaPhong;
            qlks.PhongvaHopDongs.InsertOnSubmit(dv);
            qlks.PhongvaHopDongs.Context.SubmitChanges();
            return true;
        }
        public bool XoaPhong_HD(ref string err, string MaHD)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            PhongvaHopDong dv = new PhongvaHopDong();
            var dvQuery = from dvu in qlks.PhongvaHopDongs
                          where dvu.MaHD == MaHD
                          select dvu;
            qlks.PhongvaHopDongs.DeleteAllOnSubmit(dvQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatPhong_HD(string MaHD, string MaPhong, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var dvQuery = (from dvu in qlks.PhongvaHopDongs
                           where dvu.MaHD == MaHD
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
