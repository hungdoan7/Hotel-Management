﻿using System;
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
        public DataSet LayDSPhong()
        {
            return db.ExecuteQueryDataSet(" select * from Phong", CommandType.Text);
        }
        public bool CapNhatPhong(string maphong, string loaiphong, string giaphong, string sdt, string manhanvien, string tinhtrang)
        {
            string sqlString = "Update Phong set LoaiPhong=N'" + loaiphong + "',GiaPhong='" + giaphong + "',SDT='" + sdt + "',MaNV ='" + manhanvien + "',TinhTrang=N'" + tinhtrang + "' where MaPhong ='" + maphong + "' ";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public bool ThemPhong(string maphong, string loaiphong, string giaphong, string sdt, string manhanvien, string tinhtrang)
        {            
            string sqlString = "Insert into Phong values ('" + maphong + "',N'" + loaiphong + "','" + tinhtrang + "','" + giaphong + "','" + sdt + "',N'" + manhanvien + "')";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column,string keyword)
        {
            string sqlString = "select * from Phong where "+column+" like (N'"+keyword+"%')";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
