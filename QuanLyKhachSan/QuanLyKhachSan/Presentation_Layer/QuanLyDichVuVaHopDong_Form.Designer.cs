﻿namespace QuanLyKhachSan
{
    partial class QuanLyDichVuVaHopDong_Form
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
            this.panel = new System.Windows.Forms.Panel();
            this.SoNgaySD_Label = new System.Windows.Forms.Label();
            this.MaHD_Label = new System.Windows.Forms.Label();
            this.SoNgaySD_TextBox = new System.Windows.Forms.TextBox();
            this.MaHD_TextBox = new System.Windows.Forms.TextBox();
            this.MaDV_Label = new System.Windows.Forms.Label();
            this.MaDV_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.dgvDVvaHD = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_Button = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVvaHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.SoNgaySD_Label);
            this.panel.Controls.Add(this.MaHD_Label);
            this.panel.Controls.Add(this.SoNgaySD_TextBox);
            this.panel.Controls.Add(this.MaHD_TextBox);
            this.panel.Controls.Add(this.MaDV_Label);
            this.panel.Controls.Add(this.MaDV_TextBox);
            this.panel.Location = new System.Drawing.Point(42, 21);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(404, 100);
            this.panel.TabIndex = 39;
            // 
            // SoNgaySD_Label
            // 
            this.SoNgaySD_Label.AutoSize = true;
            this.SoNgaySD_Label.Location = new System.Drawing.Point(195, 17);
            this.SoNgaySD_Label.Name = "SoNgaySD_Label";
            this.SoNgaySD_Label.Size = new System.Drawing.Size(93, 13);
            this.SoNgaySD_Label.TabIndex = 28;
            this.SoNgaySD_Label.Text = "Số Ngày Sử Dụng";
            // 
            // MaHD_Label
            // 
            this.MaHD_Label.AutoSize = true;
            this.MaHD_Label.Location = new System.Drawing.Point(3, 63);
            this.MaHD_Label.Name = "MaHD_Label";
            this.MaHD_Label.Size = new System.Drawing.Size(74, 13);
            this.MaHD_Label.TabIndex = 27;
            this.MaHD_Label.Text = "Mã Hợp Đồng";
            // 
            // SoNgaySD_TextBox
            // 
            this.SoNgaySD_TextBox.Location = new System.Drawing.Point(294, 14);
            this.SoNgaySD_TextBox.Name = "SoNgaySD_TextBox";
            this.SoNgaySD_TextBox.Size = new System.Drawing.Size(100, 20);
            this.SoNgaySD_TextBox.TabIndex = 25;
            // 
            // MaHD_TextBox
            // 
            this.MaHD_TextBox.Location = new System.Drawing.Point(81, 63);
            this.MaHD_TextBox.Name = "MaHD_TextBox";
            this.MaHD_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MaHD_TextBox.TabIndex = 24;
            // 
            // MaDV_Label
            // 
            this.MaDV_Label.AutoSize = true;
            this.MaDV_Label.Location = new System.Drawing.Point(3, 14);
            this.MaDV_Label.Name = "MaDV_Label";
            this.MaDV_Label.Size = new System.Drawing.Size(63, 13);
            this.MaDV_Label.TabIndex = 26;
            this.MaDV_Label.Text = "Mã Dịch Vụ";
            // 
            // MaDV_TextBox
            // 
            this.MaDV_TextBox.Location = new System.Drawing.Point(81, 14);
            this.MaDV_TextBox.Name = "MaDV_TextBox";
            this.MaDV_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MaDV_TextBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(42, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 62);
            this.panel1.TabIndex = 38;
            this.panel1.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
            // 
            // Search_ComboBox
            // 
            this.Search_ComboBox.FormattingEnabled = true;
            this.Search_ComboBox.Items.AddRange(new object[] {
            "Mã Dịch Vụ",
            "Mã Hợp Đồng",
            "Số Ngày Sử Dụng Dịch Vụ"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã Dịch Vụ";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(142, 24);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(47, 506);
            this.Reload_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(100, 31);
            this.Reload_Button.TabIndex = 31;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(281, 506);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 31);
            this.Back_Button.TabIndex = 37;
            this.Back_Button.Text = "Trở về";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(281, 556);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(100, 31);
            this.Delete_Button.TabIndex = 36;
            this.Delete_Button.Text = "Xóa";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(164, 506);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(100, 31);
            this.Edit_Button.TabIndex = 35;
            this.Edit_Button.Text = "Sửa";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(164, 556);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 34;
            this.Cancel_Button.Text = "Hủy";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // dgvDVvaHD
            // 
            this.dgvDVvaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVvaHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.MaHD,
            this.SoNgaySD});
            this.dgvDVvaHD.Location = new System.Drawing.Point(42, 133);
            this.dgvDVvaHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDVvaHD.Name = "dgvDVvaHD";
            this.dgvDVvaHD.RowTemplate.Height = 24;
            this.dgvDVvaHD.Size = new System.Drawing.Size(461, 283);
            this.dgvDVvaHD.TabIndex = 30;
            this.dgvDVvaHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVvaHD_CellClick);
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hợp Đồng";
            this.MaHD.Name = "MaHD";
            // 
            // SoNgaySD
            // 
            this.SoNgaySD.DataPropertyName = "SoNgaySD";
            this.SoNgaySD.HeaderText = "Số Ngày Sử Dụng Dịch Vụ";
            this.SoNgaySD.Name = "SoNgaySD";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(47, 556);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 31);
            this.Save_Button.TabIndex = 32;
            this.Save_Button.Text = "Lưu";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // QuanLyDichVuVaHopDong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 613);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.dgvDVvaHD);
            this.Controls.Add(this.Save_Button);
            this.Name = "QuanLyDichVuVaHopDong_Form";
            this.Text = "QuanLyDichVuVaHopDong_Form";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVvaHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label SoNgaySD_Label;
        private System.Windows.Forms.Label MaHD_Label;
        private System.Windows.Forms.TextBox SoNgaySD_TextBox;
        private System.Windows.Forms.TextBox MaHD_TextBox;
        private System.Windows.Forms.Label MaDV_Label;
        private System.Windows.Forms.TextBox MaDV_TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.DataGridView dgvDVvaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgaySD;
        private System.Windows.Forms.Button Save_Button;
    }
}