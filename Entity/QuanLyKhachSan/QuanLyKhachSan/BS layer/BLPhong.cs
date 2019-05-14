using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLPhong
    { 
        public DataTable LayPhong()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var ps = from p in qlksEntity.Phongs
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Phòng");
            dt.Columns.Add("Tên Phòng");
            dt.Columns.Add("Loại Phòng");
            dt.Columns.Add("Gia Phong");
            dt.Columns.Add("Chú Thích");
            dt.Columns.Add("Tình Trạng");
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Mã DV");

            foreach (var p in ps)
            {
                dt.Rows.Add(p.MaPhong, p.TenPhong, p.LoaiPhong, p.GiaPhong, p.ChuThich, p.TinhTrang, p.MaNV, p.MaDV);
            }
            return dt;
        }
        public bool ThemPhong(string MaPhong,string TenPhong, string LoaiPhong, double GiaPhong, string ChuThich, string TinhTrang, string MaNV, string MaDV, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            Phong ph = new Phong();
            ph.MaPhong = MaPhong;
            ph.TenPhong = TenPhong;
            ph.LoaiPhong = LoaiPhong;
            ph.GiaPhong = Convert.ToDecimal(GiaPhong);
            ph.ChuThich = ChuThich;
            ph.TinhTrang = TinhTrang;
            ph.MaNV = MaNV;
            ph.MaDV = MaDV;
            qlksEntity.Phongs.Add(ph);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaPhong(ref string err, string MaPhong)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            Phong phg = new Phong();
            phg.MaPhong = MaPhong;
            qlksEntity.Phongs.Attach(phg);
            qlksEntity.Phongs.Remove(phg);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatPhong(string MaPhong, string TenPhong, string LoaiPhong, double GiaPhong, string ChuThich, string TinhTrang, string MaNV, string MaDV, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var phQuery = (from ph in qlksEntity.Phongs
                           where ph.MaPhong == MaPhong
                           select ph).SingleOrDefault();
            if(phQuery!=null)
            {
                phQuery.TenPhong = TenPhong;
                phQuery.LoaiPhong = LoaiPhong;
                phQuery.GiaPhong = Convert.ToDecimal(GiaPhong);
                phQuery.ChuThich = ChuThich;
                phQuery.TinhTrang = TinhTrang;
                phQuery.MaNV = MaNV;
                phQuery.MaDV = MaDV;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}
