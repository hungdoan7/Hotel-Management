namespace QuanLyKhachSan
{
    partial class ThongKeTaiChinh_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReport = new QuanLyKhachSan.DataSetReport();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTableAdapter = new QuanLyKhachSan.DataSetReportTableAdapters.HoaDonTableAdapter();
            this.ChartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(774, 290);
            this.reportViewer1.TabIndex = 52;
            // 
            // DataSetReport
            // 
            this.DataSetReport.DataSetName = "DataSetReport";
            this.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.DataSetReport;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // ChartDT
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Doanh Thu";
            legend1.Title = "Doanh Thu";
            this.ChartDT.Legends.Add(legend1);
            this.ChartDT.Location = new System.Drawing.Point(281, 326);
            this.ChartDT.Name = "ChartDT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Doanh Thu";
            series1.Name = "DoanhThu";
            this.ChartDT.Series.Add(series1);
            this.ChartDT.Size = new System.Drawing.Size(505, 400);
            this.ChartDT.TabIndex = 53;
            this.ChartDT.Text = "chart1";
            title1.Name = "Thống kê danh thu mỗi tháng ";
            title1.Text = "Thống kê danh thu mỗi tháng ";
            this.ChartDT.Titles.Add(title1);
            // 
            // ThongKeTaiChinh_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 738);
            this.Controls.Add(this.ChartDT);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKeTaiChinh_Form";
            this.Text = "ThongKeTaiChinh_Form";
            this.Load += new System.EventHandler(this.ThongKeTaiChinh_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDT;
    }
}