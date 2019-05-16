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
    class BLDangNhap
    {
        public bool LayTaiKhoan(string taikhoan, string matkhau)
        {
            QuanLyKhachSanEntities qlbhEntity = new QuanLyKhachSanEntities();
            var text = qlbhEntity.Logins.Where(x => x.TenTK == taikhoan && x.MatKhau == matkhau).FirstOrDefault();
            if (text != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}
