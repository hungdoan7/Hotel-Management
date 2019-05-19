using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DB_layer;

namespace QuanLyKhachSan.BS_layer
{
    class BlKhachDat
    {
        DBMain db = null;
        public BlKhachDat()
        {
            db = new DBMain();
        }
    }
}
