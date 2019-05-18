using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyKhachSan.DB_layer;
using System.Data;

namespace QuanLyKhachSan.BS_layer
{
    class BLTraPhong
    {
        DBMain db = null;
        DataSet A = null;
        public BLTraPhong()
        {
            db = new DBMain();
        }
        public DataSet LayDSHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text);
        }
        public DataSet LayDSHopDong()
        {
            string Temp = " select HopDong.MaHopDong,HopDong.MaKH,KhachHang.TenKH,HopDong.NgayThue,HopDong.NgayDuKienTraPhong from KhachHang, HopDong where KhachHang.MaKH = HopDong.MaKH ";
            return db.ExecuteQueryDataSet(Temp, CommandType.Text);
        }
        public DataSet LayDSDichVuvaHopDong(string MaHD)
        {
            string Temp = " select A.MaHD,A.MaDV,DichVu.TenDV,A.SoNgaySD,DichVu.GiaDV from (select * from DichVuvaHD where MaHD = '" + MaHD + "') as A, DichVu where A.MaDV = DichVu.MaDV ";
            return db.ExecuteQueryDataSet(Temp, CommandType.Text);
        }
        public DataSet LayDSPhongvaHD(string MaHD)
        {
            string Temp = " select A.MaHopDong,PhongvaHopDong.MaPhong,Phong.LoaiPhong,Phong.GiaPhong,A.NgayThue,A.NgayDuKienTraPhong from (select * from HopDong where MaHopDong = '" + MaHD + "') as A,PhongvaHopDong,Phong where A.MaHopDong = PhongvaHopDong.MaHD and Phong.MaPhong = PhongvaHopDong.MaPhong ";
            return db.ExecuteQueryDataSet(Temp, CommandType.Text);
        }
        public bool CapNhatPhong(string maphong, string tinhtrang)
        {
            string sqlString = "Update Phong set TinhTrang=N'" + tinhtrang + "' where MaPhong ='" + maphong + "' ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemHoaDon(string mahd, string makh, string ngaythue, string ngaytra,string giatien,string ngayxuathoadon)
        {
            string sqlString = "Insert HoaDon values('" + mahd + "','" + makh + "','" + ngaythue + "','" + ngaytra + "','" +giatien + "','"+ ngayxuathoadon+"') ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool XoaHopDong(string mahd)
        {
            string Temp = "Delete from HopDong where MaHopDong='" + mahd + "'";
            return db.MyExecuteNonQUery(Temp,CommandType.Text);
        }
        public bool XoaDichVuVaHopDong(string mahd)
        {
            return db.MyExecuteNonQUery("Delete from DichVuvaHD where MaHD='" + mahd + "' ", CommandType.Text);
        }
        public bool XoaPhongVaHopDong(string mahd)
        {
            return db.MyExecuteNonQUery("Delete from PhongvaHopDong where MaHD='" + mahd + "' ", CommandType.Text);
        }
         
    }
}
