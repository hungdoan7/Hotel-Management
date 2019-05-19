﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BLDVvaHD
    {
        DBMain db = null;
        public BLDVvaHD()
        {
            db = new DBMain();
        }
        public DataSet LayDSDVvaHD()
        {
            return db.ExecuteQueryDataSet("select * from DichVuvaHD where Hide=0", CommandType.Text);
        }
        public DataSet LayDSDVvaHDSinhMa()
        {
            return db.ExecuteQueryDataSet("select * from DichVuvaHD", CommandType.Text);
        }
        public bool CapNhatDVvaHD(string madv, string mahd, string songaysd)
        {
            string sqlString = "Update DichVuvaHD set SoNgaySD='" + songaysd + "' where MaDV ='" + madv + "' and MaHD='"+ mahd +"'";
            return db.MyExecuteNonQUery(sqlString, CommandType.Text);
        }
        public DataSet TimKiem(string column, string keyword)
        {
            string sqlString = "select * from DichVuvaHD where " + column + " like (N'%" + keyword + "%') and Hide=0";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}