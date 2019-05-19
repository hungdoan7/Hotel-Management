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
    public partial class Main_Form : Form
    {
        public static bool isLogin;
        public static bool QuanLyMode;
        public Main_Form()
        {
            isLogin = false;
            QuanLyMode = true;
            InitializeComponent();
            KhoiTaoMoi();
        }
        private void KhoiTaoMoi()
        {
            if (isLogin == false)
            {
                this.thốngKêToolStripMenuItem.Enabled = false;
               //this.quảnLýToolStripMenuItem.Enabled = false;
               //this.hoạtĐộngToolStripMenuItem.Enabled = false;
                this.đăngNhậpToolStripMenuItem.Enabled = true;
                this.đăngXuấtToolStripMenuItem.Enabled = false;
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form Temp = new Login_Form();
            Temp.ShowDialog();
            if (Main_Form.isLogin == true)
            {
                if (QuanLyMode == true)
                {
                    this.thốngKêToolStripMenuItem.Enabled = true;
                }
                this.hoạtĐộngToolStripMenuItem.Enabled = true;
                this.quảnLýToolStripMenuItem.Enabled = true;
                this.đăngNhậpToolStripMenuItem.Enabled = false;
                this.đăngXuấtToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogin = false;
            KhoiTaoMoi();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhong_Form Temp = new QuanLyPhong_Form();
            Temp.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang_Form Temp = new QuanLyKhachHang_Form();
            Temp.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Form Temp = new QuanLyNhanVien_Form();
            Temp.ShowDialog();
        }
        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDichVu_Form Temp = new QuanLyDichVu_Form();
            Temp.ShowDialog();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDichVuVaHopDong_Form Temp = new QuanLyDichVuVaHopDong_Form();
            Temp.ShowDialog();
        }

        private void sửDụngDichVụCủaKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoatDongDichVu_Form Temp = new QuanLyHoatDongDichVu_Form();
            Temp.ShowDialog();
        }

        private void quanLyHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLyHopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHopDong_Form Temp = new QuanLyHopDong_Form();
            Temp.ShowDialog();
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Khách có đặt phòng trước không?", "Tùy Chọn", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                NhanPhongKhongDatTruoc_Form Temp = new NhanPhongKhongDatTruoc_Form();
                Temp.ShowDialog();
            }
            else
            {
                if (dlr == DialogResult.Yes)
                {
                    NhanPhongDatTruoc_Form Temp = new NhanPhongDatTruoc_Form();
                    Temp.ShowDialog();
                }
            }
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraPhong_Form Temp = new TraPhong_Form();
            Temp.ShowDialog();
        }

        private void nhậnĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDatPhong_Form Temp = new QuanLyDatPhong_Form();
            Temp.ShowDialog();
        }

        private void quảnLýKháchĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachDat Temp = new QuanLyKhachDat();
            Temp.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BS_layer.BLMain bl = new BS_layer.BLMain();
            DataSet ds = new DataSet();
            ds = bl.LayDSPhongHetHan();
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan ts = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i].ItemArray[1]));
                if (ts.Days > 0)
                {
                    News_RichTextBox.AppendText(" Khách hàng có mã "+ dt.Rows[i].ItemArray[2]+ " đang nợ tiền phòng "+ dt.Rows[i].ItemArray[0]+" "+ ts.Days+" ngày \n");
                }
            }
            dt.Clear();
            ds = bl.LayDSPhongDatHetHan();
            dt=ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan ts = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i].ItemArray[2]));
                if (ts.Days > 0)
                {
                    News_RichTextBox.AppendText(" Người đặt có mã " + dt.Rows[i].ItemArray[0] + " không đến lấy phòng " + dt.Rows[i].ItemArray[1] + " đã đặt quá " + ts.Days + " ngày nên sẽ được tự động chuyển phòng thành trống \n");
                    bl.CapNhatPhong(dt.Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }
}
