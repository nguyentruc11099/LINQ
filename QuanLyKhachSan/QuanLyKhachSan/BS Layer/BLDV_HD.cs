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
    class BLDV_HD
    {
        public System.Data.Linq.Table<DichVuvaHD> LayDichVuvaHD()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.DichVuvaHDs;
        }
        public bool ThemDichVuvaHD(string MaHD, string MaDV, int SoNgaySD, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            DichVuvaHD dv = new DichVuvaHD();
            dv.MaHD = MaHD;
            dv.MaDV = MaDV;
            dv.SoNgaySD = SoNgaySD;
            qlks.DichVuvaHDs.InsertOnSubmit(dv);
            qlks.DichVuvaHDs.Context.SubmitChanges();
            return true;
        }
        public bool XoaDichVuvaHD(ref string err, string MaHD)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            DichVuvaHD dv = new DichVuvaHD();
            var dvQuery = from dvu in qlks.DichVuvaHDs
                          where dvu.MaHD == MaHD
                          select dvu;
            qlks.DichVuvaHDs.DeleteAllOnSubmit(dvQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatDichVuvaHD(string MaHD, string MaDV, int SoNgaySD, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var dvQuery = (from dvu in qlks.DichVuvaHDs
                           where dvu.MaHD == MaHD
                           select dvu).SingleOrDefault();
            if (dvQuery != null)
            {
                dvQuery.MaDV = MaDV;
                dvQuery.SoNgaySD = SoNgaySD;
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
