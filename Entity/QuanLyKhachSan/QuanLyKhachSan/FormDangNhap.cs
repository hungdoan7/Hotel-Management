using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using QuanLyKhachSan.BS_layer;

namespace QuanLyKhachSan
{
    public partial class FormDangNhap : Form
    {
        BLDangNhap txt = new BLDangNhap();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt.LayTaiKhoan(txtID.Text, txtPass.Text) == true)
            {
                FormMain.bIsLogin = true;
                Close();
            }
            else
            {
                FormMain.bIsLogin = false;
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                txtID.Focus();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
