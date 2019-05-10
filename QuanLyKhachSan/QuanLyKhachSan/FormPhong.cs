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
    public partial class FrmQuanLyDanhMucPhong : Form
    {
        DataTable dtPhong = null;
        bool Them;
        string err;
        BLPhong dbPh = new BLPhong();
        public FrmQuanLyDanhMucPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtPhong = new DataTable();
                dtPhong.Clear();

                DataSet ds = dbPh.LayPhong();
                dtPhong = ds.Tables[0];

                dgvPHONG.DataSource = dtPhong;
                dgvPHONG.AutoResizeColumns();
                //this.txtMaPhong.ResetText();
                //this.txtTenPhong.ResetText();
                this.panel1.ResetText();
                this.btn_Luu.Enabled = false;
                this.btn_Huy.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát                  
                this.btn_Them.Enabled = true;
                this.btn_Sua.Enabled = true;
                this.btn_Xoa.Enabled = true;
                this.btn_Trove.Enabled = true;
                dgvPHONG_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table");
            }
        }
        private void FrmQuanLyDanhMucPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPHONG.CurrentCell.RowIndex;
            this.txtMaPhong.Text = dgvPHONG.Rows[r].Cells[0].Value.ToString();
            this.txtTenPhong.Text = dgvPHONG.Rows[r].Cells[1].Value.ToString();
            this.txtLoaiPhong.Text = dgvPHONG.Rows[r].Cells[2].Value.ToString();
            this.txtGiaPhong.Text = dgvPHONG.Rows[r].Cells[3].Value.ToString();
            this.txtChuThich.Text = dgvPHONG.Rows[r].Cells[4].Value.ToString();
            this.txtTinhTrang.Text = dgvPHONG.Rows[r].Cells[5].Value.ToString();
            this.txtMaNV.Text = dgvPHONG.Rows[r].Cells[6].Value.ToString();
            this.txtMaDV.Text = dgvPHONG.Rows[r].Cells[7].Value.ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;
            //this.txtMaPhong.ResetText();
            //this.txtTenPhong.ResetText();
            //this.txtChuThich.ResetText();
            this.panel1.ResetText();
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.panel1.Enabled = true;

            this.btn_Them.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Trove.Enabled = false;

            this.txtMaPhong.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(Them == true)
            {
                BLPhong blP = new BLPhong();
                if (blP.ThemPhong(this.txtMaPhong.Text, this.txtTenPhong.Text,
                    this.txtLoaiPhong.Text, Convert.ToDouble(this.txtGiaPhong.Text),
                    this.txtChuThich.Text, this.txtTinhTrang.Text,
                    this.txtMaNV.Text, this.txtMaDV.Text, ref err) == false)
                {
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show("Không thêm được!");
                }
            }
        }
    }
}
