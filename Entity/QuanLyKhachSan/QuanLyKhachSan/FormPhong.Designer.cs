namespace QuanLyKhachSan
{
    partial class FormPhong
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
            this.dgvPHONG = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtChuThich = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lb_MaDV = new System.Windows.Forms.Label();
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.lb_TinhTrang = new System.Windows.Forms.Label();
            this.lb_ChuThich = new System.Windows.Forms.Label();
            this.lb_GiaPhong = new System.Windows.Forms.Label();
            this.lb_LoaiPhong = new System.Windows.Forms.Label();
            this.lb_TenPhong = new System.Windows.Forms.Label();
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Trove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPHONG
            // 
            this.dgvPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHONG.Location = new System.Drawing.Point(29, 146);
            this.dgvPHONG.Name = "dgvPHONG";
            this.dgvPHONG.RowTemplate.Height = 24;
            this.dgvPHONG.Size = new System.Drawing.Size(987, 454);
            this.dgvPHONG.TabIndex = 0;
            this.dgvPHONG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPHONG_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtChuThich);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.txtGiaPhong);
            this.panel1.Controls.Add(this.txtTinhTrang);
            this.panel1.Controls.Add(this.txtTenPhong);
            this.panel1.Controls.Add(this.txtLoaiPhong);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.lb_MaDV);
            this.panel1.Controls.Add(this.lb_MaNV);
            this.panel1.Controls.Add(this.lb_TinhTrang);
            this.panel1.Controls.Add(this.lb_ChuThich);
            this.panel1.Controls.Add(this.lb_GiaPhong);
            this.panel1.Controls.Add(this.lb_LoaiPhong);
            this.panel1.Controls.Add(this.lb_TenPhong);
            this.panel1.Controls.Add(this.lb_MaPhong);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 117);
            this.panel1.TabIndex = 1;
            // 
            // txtChuThich
            // 
            this.txtChuThich.Location = new System.Drawing.Point(799, 16);
            this.txtChuThich.Multiline = true;
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Size = new System.Drawing.Size(181, 91);
            this.txtChuThich.TabIndex = 15;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(618, 16);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(83, 22);
            this.txtMaNV.TabIndex = 14;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(618, 56);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(83, 22);
            this.txtMaDV.TabIndex = 13;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(380, 16);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(119, 22);
            this.txtGiaPhong.TabIndex = 12;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(380, 50);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(85, 22);
            this.txtTinhTrang.TabIndex = 11;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(93, 47);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(181, 22);
            this.txtTenPhong.TabIndex = 10;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(93, 85);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(104, 22);
            this.txtLoaiPhong.TabIndex = 9;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(93, 16);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(181, 22);
            this.txtMaPhong.TabIndex = 8;
            // 
            // lb_MaDV
            // 
            this.lb_MaDV.AutoSize = true;
            this.lb_MaDV.Location = new System.Drawing.Point(515, 50);
            this.lb_MaDV.Name = "lb_MaDV";
            this.lb_MaDV.Size = new System.Drawing.Size(80, 17);
            this.lb_MaDV.TabIndex = 7;
            this.lb_MaDV.Text = "Mã Dịch Vụ";
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Location = new System.Drawing.Point(515, 16);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(97, 17);
            this.lb_MaNV.TabIndex = 6;
            this.lb_MaNV.Text = "Mã Nhân Viên";
            // 
            // lb_TinhTrang
            // 
            this.lb_TinhTrang.AutoSize = true;
            this.lb_TinhTrang.Location = new System.Drawing.Point(299, 50);
            this.lb_TinhTrang.Name = "lb_TinhTrang";
            this.lb_TinhTrang.Size = new System.Drawing.Size(78, 17);
            this.lb_TinhTrang.TabIndex = 5;
            this.lb_TinhTrang.Text = "Tình Trạng";
            // 
            // lb_ChuThich
            // 
            this.lb_ChuThich.AutoSize = true;
            this.lb_ChuThich.Location = new System.Drawing.Point(721, 16);
            this.lb_ChuThich.Name = "lb_ChuThich";
            this.lb_ChuThich.Size = new System.Drawing.Size(72, 17);
            this.lb_ChuThich.TabIndex = 4;
            this.lb_ChuThich.Text = "Chú Thích";
            // 
            // lb_GiaPhong
            // 
            this.lb_GiaPhong.AutoSize = true;
            this.lb_GiaPhong.Location = new System.Drawing.Point(299, 16);
            this.lb_GiaPhong.Name = "lb_GiaPhong";
            this.lb_GiaPhong.Size = new System.Drawing.Size(75, 17);
            this.lb_GiaPhong.TabIndex = 3;
            this.lb_GiaPhong.Text = "Giá Phòng";
            // 
            // lb_LoaiPhong
            // 
            this.lb_LoaiPhong.AutoSize = true;
            this.lb_LoaiPhong.Location = new System.Drawing.Point(15, 88);
            this.lb_LoaiPhong.Name = "lb_LoaiPhong";
            this.lb_LoaiPhong.Size = new System.Drawing.Size(80, 17);
            this.lb_LoaiPhong.TabIndex = 2;
            this.lb_LoaiPhong.Text = "Loại Phòng";
            // 
            // lb_TenPhong
            // 
            this.lb_TenPhong.AutoSize = true;
            this.lb_TenPhong.Location = new System.Drawing.Point(15, 52);
            this.lb_TenPhong.Name = "lb_TenPhong";
            this.lb_TenPhong.Size = new System.Drawing.Size(78, 17);
            this.lb_TenPhong.TabIndex = 1;
            this.lb_TenPhong.Text = "Tên Phòng";
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Location = new System.Drawing.Point(15, 16);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(72, 17);
            this.lb_MaPhong.TabIndex = 0;
            this.lb_MaPhong.Text = "Mã Phòng";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(29, 606);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(134, 38);
            this.btn_Reload.TabIndex = 2;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(29, 667);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 38);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(185, 606);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(134, 38);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(185, 667);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(134, 38);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(342, 606);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(134, 38);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(342, 667);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(134, 38);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Trove
            // 
            this.btn_Trove.Location = new System.Drawing.Point(501, 606);
            this.btn_Trove.Name = "btn_Trove";
            this.btn_Trove.Size = new System.Drawing.Size(134, 38);
            this.btn_Trove.TabIndex = 8;
            this.btn_Trove.Text = "Trở về";
            this.btn_Trove.UseVisualStyleBackColor = true;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 717);
            this.Controls.Add(this.btn_Trove);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPHONG);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPHONG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_MaDV;
        private System.Windows.Forms.Label lb_MaNV;
        private System.Windows.Forms.Label lb_TinhTrang;
        private System.Windows.Forms.Label lb_ChuThich;
        private System.Windows.Forms.Label lb_GiaPhong;
        private System.Windows.Forms.Label lb_LoaiPhong;
        private System.Windows.Forms.Label lb_TenPhong;
        private System.Windows.Forms.Label lb_MaPhong;
        private System.Windows.Forms.TextBox txtChuThich;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Trove;
    }
}

