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
    class BLDichVu
    {
        public System.Data.Linq.Table<DichVu> LayDichVu()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.DichVus;
        }
        public bool ThemDichVu(string MaDV, string TenDV, double GiaDV, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            DichVu dv = new DichVu();
            dv.MaDV = MaDV;
            dv.TenDV = TenDV;
            dv.GiaDV = GiaDV;
            dv.Hide = false;
            qlks.DichVus.InsertOnSubmit(dv);
            qlks.DichVus.Context.SubmitChanges();
            return true;
        }
        public bool XoaDichVu(ref string err, string MaDV)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            DichVu dv = new DichVu();
            var dvQuery = (from dvu in qlks.DichVus
                          where dvu.MaDV == MaDV
                          where dv.Hide == false
                          select dvu).SingleOrDefault();
            dvQuery.Hide = true;
            //qlks.DichVus.DeleteAllOnSubmit(dvQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatDichVu(string MaDV, string TenDV, double GiaDV, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var dvQuery = (from dvu in qlks.DichVus
                           where dvu.MaDV == MaDV
                           where dvu.Hide == false
                           select dvu).SingleOrDefault();
            if (dvQuery != null)
            {
                dvQuery.TenDV = TenDV;
                dvQuery.GiaDV = GiaDV;
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
