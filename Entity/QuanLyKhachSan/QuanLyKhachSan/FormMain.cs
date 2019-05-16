using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormMain : Form
    {
        public static bool bIsLogin = false;
        public FormMain()
        {
            InitializeComponent();
            menuDanhmucQL.Enabled = false;
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap dnh = new FormDangNhap();
            dnh.ShowDialog();
            if(FormMain.bIsLogin == true)
            {
                this.menuDanhmucQL.Enabled = true;
                this.menuThoat.Enabled = true;
            }
        }

        private void menuDanhmucQL_Click(object sender, EventArgs e)
        {
            
        }

        private void menuQLPhong_Click(object sender, EventArgs e)
        {
            FormPhong a1 = new FormPhong();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }

        private void menuQLKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang a1 = new FormKhachHang();
            a1.IsMdiContainer = this.IsMdiContainer;
            a1.Show();
        }
    }
}
