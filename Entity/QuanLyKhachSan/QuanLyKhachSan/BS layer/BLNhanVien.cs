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
    class BLNhanVien
    {
        public DataTable LayNhanVien()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var nvs = from p in qlksEntity.NhanViens
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhân Viên");
            dt.Columns.Add("Tên Nhân Viên");
            dt.Columns.Add("Chức vụ");
            dt.Columns.Add("Lương");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("Chú Thích");
            dt.Columns.Add("Mã DV");

            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.TenNV, p.ChucVu, p.LuongNV, p.NamSinh, p.GioiTinh, p.ChuThich);
            }
            return dt;
        }
        public bool ThemNhanVien(string MaNV, string TenNV, string ChucVu, double LuongNV, string NamSinh, string GioiTinh, string ChuThich, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.TenNV = TenNV;
            nv.ChucVu = ChucVu;
            nv.LuongNV = Convert.ToDecimal(LuongNV);
            nv.ChuThich = ChuThich;
            nv.NamSinh = Convert.ToDateTime(NamSinh);
            nv.GioiTinh = GioiTinh;
            nv.ChuThich = ChuThich;
            qlksEntity.NhanViens.Add(nv);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            qlksEntity.NhanViens.Attach(nv);
            qlksEntity.NhanViens.Remove(nv);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatNhanVien(string MaNV, string TenNV, string ChucVu, double LuongNV, string NamSinh, string GioiTinh, string ChuThich, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var phQuery = (from nv in qlksEntity.NhanViens
                           where nv.MaNV == MaNV
                           select nv).SingleOrDefault();
            if (phQuery != null)
            {
                phQuery.TenNV = TenNV;
                phQuery.ChucVu = ChucVu;
                phQuery.LuongNV = Convert.ToDecimal(LuongNV);
                phQuery.ChuThich = ChuThich;
                phQuery.NamSinh = Convert.ToDateTime(NamSinh);
                phQuery.MaNV = MaNV;
                phQuery.ChuThich = ChuThich;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}
