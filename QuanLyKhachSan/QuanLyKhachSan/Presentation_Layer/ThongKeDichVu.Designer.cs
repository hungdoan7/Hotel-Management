namespace QuanLyKhachSan
{
    partial class ThongKeDichVu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDT
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartDT.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartDT.Legends.Add(legend3);
            this.ChartDT.Location = new System.Drawing.Point(743, 34);
            this.ChartDT.Name = "ChartDT";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "TienDV";
            this.ChartDT.Series.Add(series3);
            this.ChartDT.Size = new System.Drawing.Size(330, 300);
            this.ChartDT.TabIndex = 0;
            this.ChartDT.Text = "chart1";
            title3.Name = "Biểu Đồ Tiền Thu Từ Dịch Vụ";
            title3.Text = "Biểu Đồ Tiền Thu Từ Dịch Vụ";
            this.ChartDT.Titles.Add(title3);
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.GiaTien,
            this.SoNgaySD,
            this.TongTienThu});
            this.dgvDV.Location = new System.Drawing.Point(11, 33);
            this.dgvDV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(675, 301);
            this.dgvDV.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bảng Thống Kê Dịch Vụ";
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên Dịch Vụ";
            this.TenDV.Name = "TenDV";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaDV";
            this.GiaTien.HeaderText = "Giá Dịch Vụ";
            this.GiaTien.Name = "GiaTien";
            // 
            // SoNgaySD
            // 
            this.SoNgaySD.DataPropertyName = "SoLanSD";
            this.SoNgaySD.HeaderText = "Số Ngày Sử Dụng Dịch Vụ";
            this.SoNgaySD.Name = "SoNgaySD";
            // 
            // TongTienThu
            // 
            this.TongTienThu.HeaderText = "Mô Tả Thêm Nếu Có ";
            this.TongTienThu.Name = "TongTienThu";
            // 
            // ThongKeDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.ChartDT);
            this.Name = "ThongKeDichVu";
            this.Text = "ThongKeDichVu";
            this.Load += new System.EventHandler(this.ThongKeDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDT;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgaySD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienThu;
    }
}