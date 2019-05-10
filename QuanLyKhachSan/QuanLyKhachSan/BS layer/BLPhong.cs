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
        DBMain db = null;
        public BLPhong()
        {
            db = new DBMain();
        }
        public DataSet LayPhong()
        {
            return db.ExecuteQueryDataSet("select * from Phong", CommandType.Text);
        }
        public bool ThemPhong(string MaPhong,string TenPhong, string LoaiPhong, double GiaPhong, string ChuThich, string TinhTrang, string MaNV, string MaDV, ref string err)
        {
            string sqlString = "insert into Phong Value(" + "'" + 
                MaPhong + "',N'" + 
                TenPhong + "',N'"+ 
                LoaiPhong+ "',N'" + 
                GiaPhong + "',N'"+ 
                ChuThich + "',N'" + 
                TinhTrang + "',N'" + 
                MaNV + "',N'"+ 
                MaDV + "'"+")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhong(ref string err, string MaPhong)
        {
            string sqlString = "Delete From Phong Where MaPhong= '" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhong(string MaPhong, string TenPhong, ref string err)
        {
            string sqlString ="Update Phong Set TenPhong = N'" + TenPhong + "'Where MaPhong = '" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
