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
    class BLKhachHang
    {
        public System.Data.Linq.Table<KhachHang> LayKhachHang()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.KhachHangs;
        }
        public bool ThemKhachHang(string MaKH, string TenKH, string CMND, string GioiTinh, string SDT, string XuatXu, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            KhachHang ph = new KhachHang();
            ph.MaKH = MaKH;
            ph.TenKH = TenKH;
            ph.CMND = CMND;
            ph.GioiTinh = GioiTinh;
            ph.SDT = SDT;
            ph.XuatXu = XuatXu;
            ph.Hide = false;
            qlks.KhachHangs.InsertOnSubmit(ph);
            qlks.KhachHangs.Context.SubmitChanges();
            return true;
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            KhachHang ph = new KhachHang();
            var phQuery = (from phg in qlks.KhachHangs
                          where phg.MaKH == MaKH
                          where phg.Hide == false
                          select phg).SingleOrDefault();
            phQuery.Hide = true;
            //qlks.KhachHangs.DeleteAllOnSubmit(phQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatKhachHang(string MaKH, string TenKH, string CMND, string GioiTinh, string SDT, string XuatXu, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var phQuery = (from phg in qlks.KhachHangs
                           where phg.MaKH == MaKH
                           where phg.Hide == false
                           select phg).SingleOrDefault();
            if (phQuery != null)
            {
                phQuery.TenKH = TenKH;
                phQuery.CMND = CMND;
                phQuery.GioiTinh = GioiTinh;
                phQuery.SDT = SDT;
                phQuery.XuatXu = XuatXu;
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
