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
    class BL_TraPhong
    {
        public bool CapNhatPhong(string x, string tinhtrang)
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var up = (from lpt in db.Phongs
                      where lpt.MaPhong == x
                      where lpt.Hide == false
                      select lpt).SingleOrDefault();
            if (up!=null)
            {
                up.TinhTrang = tinhtrang;
            }
            db.SubmitChanges();
            return true;
        }
        public bool CapNhatPhong_HD(string x, bool Hide)
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var up = (from lpt in db.PhongvaHopDongs
                      where lpt.MaHD == x
                      where lpt.Hide == false
                      select lpt).FirstOrDefault();
            if (up != null)
            {
                up.Hide = Hide;
            }
            db.SubmitChanges();
            return true;
        }
        public bool CapNhatDV_HD(string x, bool Hide)
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var up = (from lpt in db.DichVuvaHDs
                      where lpt.MaHD == x
                      where lpt.Hide == false
                      select lpt).FirstOrDefault();
            if (up != null)
            {
                up.Hide = Hide;
            }
            db.SubmitChanges();
            return true;
        }
        public bool CapNhatHopDong(string x, bool Hide)
        {
            QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();
            var up = (from lpt in db.HopDongs
                      where lpt.MaHopDong == x
                      where lpt.Hide == false
                      select lpt).SingleOrDefault();
            if (up != null)
            {
                up.Hide = Hide;
            }
            db.SubmitChanges();
            return true;
        }
    }
}
