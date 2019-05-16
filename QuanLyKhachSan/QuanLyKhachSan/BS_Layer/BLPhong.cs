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
        public DataSet LayDSPhong()
        {
            return db.ExecuteQueryDataSet(" select * from Phong", CommandType.Text);
        }
    }
}
