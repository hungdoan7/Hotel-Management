using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLNhanPhong
    {
        DBMain db = null;
        public BLNhanPhong()
        {
            db = new DBMain();
        }
        public DataSet LayDSKH()
        {
            return db.ExecuteQueryDataSet(" select * from KhachHang", CommandType.Text);
        }
        public bool ThemKH(string makh, string tenkh, string cmnd, string sdt, string xuatxu, string gioitinh)
        {
            string sqlString = "Insert into KhachHang values ('" + makh + "',N'" + tenkh + "','" + cmnd + "',N'" + gioitinh + "','" + sdt + "',N'" + xuatxu + "')";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiemKH(string column, string keyword)
        {
            string sqlString = "select * from KhachHang where " + column + " like (N'%" + keyword + "%')";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet LayDSPhong()
        {
            return db.ExecuteQueryDataSet(" select * from Phong  where TinhTrang=N'Trống'", CommandType.Text);
        }
        public DataSet TimKiemPhong(string column, string keyword)
        {
            string sqlString = "select * from Phong where " + column + " like (N'%" + keyword + "%')";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet LayDSHD()
        {
            return db.ExecuteQueryDataSet("select * from HopDong", CommandType.Text);
        }
        public bool ThemHD(string mahd, string makh, string ngaythue,string ngaytra)
        {
            string sqlString = "Insert HopDong values('" + mahd + "','" + makh + "','" + ngaythue + "','" + ngaytra + "') ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemPhongvaHopDong(string mahd, string maphong)
        {
            string sqlString = "Insert PhongvaHopDong values('" + maphong + "','" + mahd + "') ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool CapNhatPhong(string maphong, string tinhtrang)
        {
            string sqlString = "Update Phong set TinhTrang=N'" + tinhtrang + "' where MaPhong ='" + maphong + "' ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
    }
}
