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
                      select lpt).SingleOrDefault();
            if (up!=null)
            {
                up.TinhTrang = tinhtrang;
            }
            db.SubmitChanges();
            return true;
        }
    }
}
