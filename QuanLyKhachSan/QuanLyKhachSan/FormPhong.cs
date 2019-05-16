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
    public partial class QuanLyPhong_Form : Form
    {
        DataTable dtPhong = null;
        bool Them;
        BLPhong blP = new BLPhong();
        public QuanLyPhong_Form()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtPhong = new DataTable();
                dtPhong.Clear();
                DataSet ds = blP.LayDSPhong();
                dtPhong =ds.Tables[0];
                dgvPHONG.DataSource = dtPhong;
                this.MaNV_TextBox.ResetText();
                this.MaPhong_Textbox.ResetText();
                this.GiaPhong_TextBox.ResetText();
                this.SDT_TextBox.ResetText();
                this.LoaiPhong_ComboBox.ResetText();

                this.Reload_Button.Enabled = true;
                this.Edit_Button.Enabled = true;
                this.Delete_Button.Enabled = true;
                this.Back_Button.Enabled = true;
                this.Add_Button.Enabled = true;

                this.Cancel_Button.Enabled = false;
                this.Save_Button.Enabled = false;
                this.panel.Enabled = false;
            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung  trong table Phong !");
            }
        }
        private void FrmQuanLyDanhMucPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPHONG.CurrentCell.RowIndex;
            
            this.MaPhong_Textbox.Text = dgvPHONG.Rows[r].Cells[0].Value.ToString();
            this.GiaPhong_TextBox.Text = dgvPHONG.Rows[r].Cells[3].Value.ToString();
            this.SDT_TextBox.Text = dgvPHONG.Rows[r].Cells[4].Value.ToString();
            this.MaNV_TextBox.Text = dgvPHONG.Rows[r].Cells[5].Value.ToString();

            switch (dgvPHONG.Rows[r].Cells[1].Value.ToString())
            {
                case "Đơn":
                    {
                        LoaiPhong_ComboBox.Text = "Đơn";
                        break;
                    }
                case "Đôi":
                    {
                        LoaiPhong_ComboBox.Text = "Đôi";
                        break;
                    }
                case "Cao Cấp":
                    {
                        LoaiPhong_ComboBox.Text = "Cao Cấp";
                        break;
                    }
            }
            string Temp = dgvPHONG.Rows[r].Cells[2].Value.ToString();
            if (Temp.Length == 8)
            {
                DaThue_RadioButton.Checked = true;
            }
            else
            {
                Trong_RadioButton.Checked = true;
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them = true;

            this.Save_Button.Enabled = true;
            this.Cancel_Button.Enabled = true;
            this.panel.Enabled = true;

            this.Add_Button.Enabled = false;
            this.Edit_Button.Enabled = false;
            this.Delete_Button.Enabled = false;
            this.Back_Button.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
           
        }
    }
}
