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
    public partial class ThongKeTaiChinh_Form : Form
    {
        DataTable dtHD = null;
        BLHoaDon blHD = new BLHoaDon();
        int[] S;
        public ThongKeTaiChinh_Form()
        {
            InitializeComponent();
        }

        private void ThongKeTaiChinh_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.DataSetReport.HoaDon);
            this.reportViewer1.RefreshReport();


            dtHD = new DataTable();
            dtHD.Clear();
            DataSet ds = blHD.LayDSHD();
            dtHD = ds.Tables[0];

            int SoThang = DateTime.Now.Month;
            int[] S = new int[SoThang];
            for (int i = SoThang; i > 0; i--)
            {
                S[i-1] = 0;
                for (int j = 0; j < dtHD.Rows.Count; j++)
                {
                    string[] a = dtHD.Rows[j].ItemArray[5].ToString().Split('/');
                    if (Convert.ToInt32(a[0]) == i)
                    {
                        S[i-1] += Convert.ToInt32(dtHD.Rows[j].ItemArray[4]);
                    }
                }
            }

            for (int i = 0; i < SoThang; i++)
            {
                ChartDT.Series["DoanhThu"].Points.Add(S[i]);
                ChartDT.Series["DoanhThu"].Points[i].Label = S[i].ToString();
                ChartDT.Series["DoanhThu"].Points[i].Color =Color.Blue;
                ChartDT.Series["DoanhThu"].Points[i].AxisLabel = "Tháng "+(i+1).ToString();
            }

            //int SoNgay = DateTime.Now.Day;
            //S = int[7];
        }
    }
}
