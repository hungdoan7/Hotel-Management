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
    public partial class FormNhanVien : Form
    {
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvNhanVien.DataSource = dbNV.LayNhanVien();
                dgvNhanVien.AutoResizeColumns();
                //this.txtMaNV.ResetText();
                //this.txtTenNV.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvNhanVien_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_ReLoad_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            ResetText();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaNV.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string gioitinh = checkGioiTinh();
            if (Them == true)
            {
                try
                {
                    BLKhachHang blP = new BLKhachHang();
                    blP.ThemKhachHang(this.txtMaNV.Text, this.txtTenNV.Text,
                    this.txtChucVu.Text, this.txtLuongNV.Text,
                    gioitinh, this.txtNamSinh.Text,
                    gioitinh, this.txtChuThich.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được!");
                }
            }
            else
            {
                BLKhachHang blP = new BLKhachHang();
                blP.CapNhatKhachHang(this.txtMaNV.Text, this.txtTenNV.Text,
                    this.txtChucVu.Text, this.txtLuongNV.Text,
                    gioitinh, this.txtNamSinh.Text,
                    gioitinh, this.txtChuThich.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ResetText();
            this.btn_Them.Enabled = true;
            this.btn_Sua.Enabled = true;
            this.btn_Xoa.Enabled = true;

            this.btn_Luu.Enabled = false;
            this.btn_Huy.Enabled = false;
            this.panel1.Enabled = false;
            dgvNhanVien_CellClick(null, null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvNhanVien_CellClick(null, null);

            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.txtTenNV.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                string strNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa mục này?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaNhanVien(ref err, strNV);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gioitinh = checkGioiTinh();
            int r = dgvNhanVien.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtChucVu.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtLuongNV.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            gioitinh = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtNamSinh.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            gioitinh = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            this.txtChuThich.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
        }
        private void ResetText()
        {
            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            this.txtChucVu.ResetText();
            this.txtLuongNV.ResetText();
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
            this.d;
            this.txtChuThich.ResetText();
        }
        private string checkGioiTinh()
        {
            if (rbtn_Nam.Checked == true)
            {
                return rbtn_Nam.Text;
            }
            else
            {
                return rbtn_Nu.Text;
            }
        }
    }
}
