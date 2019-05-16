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
    class BLKhachHang
    {
        public DataTable LayKhachHang()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var khs = from p in qlksEntity.KhachHangs
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã KH");
            dt.Columns.Add("Tên KH");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Quốc Tịch");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("Tuổi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Mã Phòng");

            foreach (var p in khs)
            {
                dt.Rows.Add(p.MaKH, p.TenKH, p.CMND, p.QuocTich, p.GioiTinh, p.Tuoi, p.SDT, p.MaPhong);
            }
            return dt;
        }
        public bool ThemKhachHang(string MaKH, string TenKH, string CMND, string QuocTich, string GioiTinh, string Tuoi, string SDT, string MaPhong, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            KhachHang kh = new KhachHang();
            kh.MaKH= MaKH;
            kh.TenKH = TenKH;
            kh.CMND = CMND;
            kh.QuocTich = QuocTich;
            kh.GioiTinh = GioiTinh;
            kh.Tuoi = Tuoi;
            kh.SDT = SDT;
            kh.MaPhong = MaPhong;
            qlksEntity.KhachHangs.Add(kh);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            KhachHang khg = new KhachHang();
            khg.MaKH = MaKH;
            qlksEntity.KhachHangs.Attach(khg);
            qlksEntity.KhachHangs.Remove(khg);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatKhachHang(string MaKH, string TenKH, string CMND, string QuocTich, string GioiTinh, string Tuoi, string SDT, string MaPhong, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var khQuery = (from ph in qlksEntity.KhachHangs
                           where ph.MaKH == MaKH
                           select ph).SingleOrDefault();
            if (khQuery != null)
            {
                khQuery.TenKH = TenKH;
                khQuery.CMND = CMND;
                khQuery.QuocTich = QuocTich;
                khQuery.GioiTinh = GioiTinh;
                khQuery.Tuoi = Tuoi;
                khQuery.SDT = SDT;
                khQuery.MaPhong = MaPhong;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}
