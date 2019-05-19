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

namespace QuanLyKhachSan.Presentation
{
    public partial class QuanLyKhachDat : Form
    {

        public QuanLyKhachDat()
        {
            InitializeComponent();
        }

        private void QuanLyKhachDat_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataNguoiDat()
        {
            //try
            //{
            //    dtND = new DataTable();
            //    dtND.Clear();
            //    DataSet ds = blNP.LayDSKhachDat();
            //    dtND = ds.Tables[0];
            //    dgvKhachDat.DataSource = dtND;
            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("Không lấy được nội dung trong table DanhSachDatTruoc !");
            //}
        }
    }
}
