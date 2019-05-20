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
    class BLPhong
    {
        public System.Data.Linq.Table<Phong> LayPhong()
        {
            DataSet ds = new DataSet();
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            return qlks.Phongs;
        }
        public bool ThemPhong(string MaPhong, string LoaiPhong, string TinhTrang, 
            double GiaPhong, string SDT, string MaNV, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            Phong ph = new Phong();
            ph.MaPhong = MaPhong;
            ph.LoaiPhong = LoaiPhong;
            ph.TinhTrang = TinhTrang;
            ph.GiaPhong = GiaPhong;
            ph.SDT = SDT;
            ph.MaNV = MaNV;
            ph.Hide = false;
            qlks.Phongs.InsertOnSubmit(ph);
            qlks.Phongs.Context.SubmitChanges();
            return true;
        }
        public bool XoaPhong(ref string err, string MaPhong)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            Phong ph = new Phong();
            var phQuery = (from phg in qlks.Phongs
                          where phg.MaPhong == MaPhong
                          where phg.Hide == false
                          select phg).SingleOrDefault();
            phQuery.Hide = true;
            //qlks.Phongs.DeleteAllOnSubmit(phQuery);
            qlks.SubmitChanges();
            return true;
        }
        public bool CapNhatPhong(string MaPhong, 
            string LoaiPhong, string TinhTrang, 
            double GiaPhong, string SDT, string MaNV, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var phQuery = (from phg in qlks.Phongs
                           where phg.MaPhong == MaPhong
                           where phg.Hide == false
                           select phg).SingleOrDefault();
            if (phQuery != null)
            {
                phQuery.LoaiPhong = LoaiPhong;
                phQuery.TinhTrang = TinhTrang;
                phQuery.GiaPhong = GiaPhong;
                phQuery.SDT = SDT;
                phQuery.MaNV = MaNV;
                qlks.SubmitChanges();
            }
            return true;
        }
        public bool CapNhatPhong_TinhTrang(string MaPhong, string TinhTrang, ref string err)
        {
            QuanLyKhachSanDataContext qlks = new QuanLyKhachSanDataContext();
            var phQuery = (from phg in qlks.Phongs
                           where phg.MaPhong == MaPhong
                           where phg.Hide == false
                           select phg).SingleOrDefault();
            if (phQuery != null)
            {
                phQuery.TinhTrang = TinhTrang;
                qlks.SubmitChanges();
            }
            return true;
        }
    }
}
