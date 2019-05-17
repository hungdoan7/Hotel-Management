namespace QuanLyKhachSan
{
    partial class NhanPhong_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NhanPhong_RadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.TenKH_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_TextBox = new System.Windows.Forms.TextBox();
            this.SDT_Label = new System.Windows.Forms.Label();
            this.Nu_RadioButton = new System.Windows.Forms.RadioButton();
            this.Nam_RadioButton = new System.Windows.Forms.RadioButton();
            this.XuatXu_TextBox = new System.Windows.Forms.TextBox();
            this.CMND_TextBox = new System.Windows.Forms.TextBox();
            this.MaKH_TextBox = new System.Windows.Forms.TextBox();
            this.XuatXu_Label = new System.Windows.Forms.Label();
            this.GioiTinh_Label = new System.Windows.Forms.Label();
            this.CMND_Label = new System.Windows.Forms.Label();
            this.TenKH_Label = new System.Windows.Forms.Label();
            this.MaKH_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.dgvPHONG = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Today_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanPhong_RadioButton
            // 
            this.NhanPhong_RadioButton.AutoSize = true;
            this.NhanPhong_RadioButton.Location = new System.Drawing.Point(53, 13);
            this.NhanPhong_RadioButton.Name = "NhanPhong_RadioButton";
            this.NhanPhong_RadioButton.Size = new System.Drawing.Size(145, 17);
            this.NhanPhong_RadioButton.TabIndex = 0;
            this.NhanPhong_RadioButton.TabStop = true;
            this.NhanPhong_RadioButton.Text = "Khách hàng đã từng đến";
            this.NhanPhong_RadioButton.UseVisualStyleBackColor = true;
            this.NhanPhong_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(204, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Khách đến lần đầu tiên";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.TenKH_TextBox);
            this.panel.Controls.Add(this.SDT_TextBox);
            this.panel.Controls.Add(this.SDT_Label);
            this.panel.Controls.Add(this.Nu_RadioButton);
            this.panel.Controls.Add(this.Add_Button);
            this.panel.Controls.Add(this.Nam_RadioButton);
            this.panel.Controls.Add(this.XuatXu_TextBox);
            this.panel.Controls.Add(this.CMND_TextBox);
            this.panel.Controls.Add(this.MaKH_TextBox);
            this.panel.Controls.Add(this.XuatXu_Label);
            this.panel.Controls.Add(this.GioiTinh_Label);
            this.panel.Controls.Add(this.CMND_Label);
            this.panel.Controls.Add(this.TenKH_Label);
            this.panel.Controls.Add(this.MaKH_Label);
            this.panel.Location = new System.Drawing.Point(53, 44);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(682, 95);
            this.panel.TabIndex = 16;
            // 
            // TenKH_TextBox
            // 
            this.TenKH_TextBox.Location = new System.Drawing.Point(100, 51);
            this.TenKH_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TenKH_TextBox.Name = "TenKH_TextBox";
            this.TenKH_TextBox.Size = new System.Drawing.Size(120, 20);
            this.TenKH_TextBox.TabIndex = 19;
            // 
            // SDT_TextBox
            // 
            this.SDT_TextBox.Location = new System.Drawing.Point(285, 51);
            this.SDT_TextBox.Name = "SDT_TextBox";
            this.SDT_TextBox.Size = new System.Drawing.Size(90, 20);
            this.SDT_TextBox.TabIndex = 18;
            // 
            // SDT_Label
            // 
            this.SDT_Label.AutoSize = true;
            this.SDT_Label.Location = new System.Drawing.Point(236, 58);
            this.SDT_Label.Name = "SDT_Label";
            this.SDT_Label.Size = new System.Drawing.Size(29, 13);
            this.SDT_Label.TabIndex = 17;
            this.SDT_Label.Text = "SĐT";
            // 
            // Nu_RadioButton
            // 
            this.Nu_RadioButton.AutoSize = true;
            this.Nu_RadioButton.Location = new System.Drawing.Point(477, 71);
            this.Nu_RadioButton.Name = "Nu_RadioButton";
            this.Nu_RadioButton.Size = new System.Drawing.Size(39, 17);
            this.Nu_RadioButton.TabIndex = 16;
            this.Nu_RadioButton.TabStop = true;
            this.Nu_RadioButton.Text = "Nữ";
            this.Nu_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Nam_RadioButton
            // 
            this.Nam_RadioButton.AutoSize = true;
            this.Nam_RadioButton.Location = new System.Drawing.Point(477, 47);
            this.Nam_RadioButton.Name = "Nam_RadioButton";
            this.Nam_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.Nam_RadioButton.TabIndex = 15;
            this.Nam_RadioButton.TabStop = true;
            this.Nam_RadioButton.Text = "Nam";
            this.Nam_RadioButton.UseVisualStyleBackColor = true;
            // 
            // XuatXu_TextBox
            // 
            this.XuatXu_TextBox.Location = new System.Drawing.Point(464, 13);
            this.XuatXu_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XuatXu_TextBox.Name = "XuatXu_TextBox";
            this.XuatXu_TextBox.Size = new System.Drawing.Size(127, 20);
            this.XuatXu_TextBox.TabIndex = 14;
            // 
            // CMND_TextBox
            // 
            this.CMND_TextBox.Location = new System.Drawing.Point(285, 13);
            this.CMND_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CMND_TextBox.Name = "CMND_TextBox";
            this.CMND_TextBox.Size = new System.Drawing.Size(90, 20);
            this.CMND_TextBox.TabIndex = 12;
            // 
            // MaKH_TextBox
            // 
            this.MaKH_TextBox.Location = new System.Drawing.Point(100, 13);
            this.MaKH_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaKH_TextBox.Name = "MaKH_TextBox";
            this.MaKH_TextBox.Size = new System.Drawing.Size(120, 20);
            this.MaKH_TextBox.TabIndex = 8;
            // 
            // XuatXu_Label
            // 
            this.XuatXu_Label.AutoSize = true;
            this.XuatXu_Label.Location = new System.Drawing.Point(386, 13);
            this.XuatXu_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XuatXu_Label.Name = "XuatXu_Label";
            this.XuatXu_Label.Size = new System.Drawing.Size(45, 13);
            this.XuatXu_Label.TabIndex = 6;
            this.XuatXu_Label.Text = "Xuất Xứ";
            // 
            // GioiTinh_Label
            // 
            this.GioiTinh_Label.AutoSize = true;
            this.GioiTinh_Label.Location = new System.Drawing.Point(386, 56);
            this.GioiTinh_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GioiTinh_Label.Name = "GioiTinh_Label";
            this.GioiTinh_Label.Size = new System.Drawing.Size(51, 13);
            this.GioiTinh_Label.TabIndex = 5;
            this.GioiTinh_Label.Text = "Giới Tính";
            // 
            // CMND_Label
            // 
            this.CMND_Label.AutoSize = true;
            this.CMND_Label.Location = new System.Drawing.Point(236, 16);
            this.CMND_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CMND_Label.Name = "CMND_Label";
            this.CMND_Label.Size = new System.Drawing.Size(39, 13);
            this.CMND_Label.TabIndex = 3;
            this.CMND_Label.Text = "CMND";
            // 
            // TenKH_Label
            // 
            this.TenKH_Label.AutoSize = true;
            this.TenKH_Label.Location = new System.Drawing.Point(11, 51);
            this.TenKH_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenKH_Label.Name = "TenKH_Label";
            this.TenKH_Label.Size = new System.Drawing.Size(89, 13);
            this.TenKH_Label.TabIndex = 2;
            this.TenKH_Label.Text = "Tên Khách Hàng";
            // 
            // MaKH_Label
            // 
            this.MaKH_Label.AutoSize = true;
            this.MaKH_Label.Location = new System.Drawing.Point(11, 16);
            this.MaKH_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaKH_Label.Name = "MaKH_Label";
            this.MaKH_Label.Size = new System.Drawing.Size(85, 13);
            this.MaKH_Label.TabIndex = 0;
            this.MaKH_Label.Text = "Mã Khách Hàng";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(568, 56);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(100, 31);
            this.Add_Button.TabIndex = 20;
            this.Add_Button.Text = "Thêm";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_ComboBox);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Location = new System.Drawing.Point(3, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 62);
            this.panel1.TabIndex = 23;
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
            "Mã Phòng",
            "Loại Phòng",
            "Tình Trạng",
            "Giá Phòng",
            "Mã Nhân Viên Phụ Trách",
            "SĐT"});
            this.Search_ComboBox.Location = new System.Drawing.Point(9, 23);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Search_ComboBox.TabIndex = 12;
            this.Search_ComboBox.Text = "Mã Phòng";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(142, 24);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(177, 20);
            this.Search_TextBox.TabIndex = 10;
            // 
            // dgvPHONG
            // 
            this.dgvPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHONG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.TinhTrang,
            this.GiaPhong,
            this.SDT,
            this.MaNV});
            this.dgvPHONG.Location = new System.Drawing.Point(5, 5);
            this.dgvPHONG.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPHONG.Name = "dgvPHONG";
            this.dgvPHONG.RowTemplate.Height = 24;
            this.dgvPHONG.Size = new System.Drawing.Size(668, 114);
            this.dgvPHONG.TabIndex = 22;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá Phòng";
            this.GiaPhong.Name = "GiaPhong";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Nhân Viên Phụ Trách";
            this.MaNV.Name = "MaNV";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(25, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 53);
            this.panel2.TabIndex = 25;
            this.panel2.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã KH",
            "Tên KH",
            "CMND",
            "Giới Tính",
            "SĐT",
            "Xuất Xứ"});
            this.comboBox1.Location = new System.Drawing.Point(9, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Mã KH";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.CMND,
            this.dataGridViewTextBoxColumn1,
            this.XuatXu});
            this.dgvKH.Location = new System.Drawing.Point(25, 8);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(566, 129);
            this.dgvKH.TabIndex = 24;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn1.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất Xứ";
            this.XuatXu.Name = "XuatXu";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(547, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // Today_Label
            // 
            this.Today_Label.AutoSize = true;
            this.Today_Label.Location = new System.Drawing.Point(487, 2);
            this.Today_Label.Name = "Today_Label";
            this.Today_Label.Size = new System.Drawing.Size(54, 13);
            this.Today_Label.TabIndex = 27;
            this.Today_Label.Text = "Hôm Nay:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dgvKH);
            this.panel3.Location = new System.Drawing.Point(53, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 204);
            this.panel3.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.dgvPHONG);
            this.panel4.Location = new System.Drawing.Point(53, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(682, 197);
            this.panel4.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "Chọn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dgvHD);
            this.panel5.Location = new System.Drawing.Point(53, 599);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(682, 111);
            this.panel5.TabIndex = 31;
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.dataGridViewTextBoxColumn2,
            this.NgayThue});
            this.dgvHD.Location = new System.Drawing.Point(12, 33);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(352, 64);
            this.dgvHD.TabIndex = 41;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHopDong";
            this.MaHD.HeaderText = "Mã Hợp Đồng";
            this.MaHD.Name = "MaHD";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // NgayThue
            // 
            this.NgayThue.DataPropertyName = "NgayThue";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.NgayThue.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayThue.HeaderText = "Ngày Bắt Đầu Thuê";
            this.NgayThue.Name = "NgayThue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Hợp đồng sẽ là :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 66);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 31);
            this.button3.TabIndex = 43;
            this.button3.Text = "Thêm Hợp Đồng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NhanPhong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 725);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Today_Label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.NhanPhong_RadioButton);
            this.Name = "NhanPhong_Form";
            this.Text = "NhanPhong_Form";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton NhanPhong_RadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox TenKH_TextBox;
        private System.Windows.Forms.TextBox SDT_TextBox;
        private System.Windows.Forms.Label SDT_Label;
        private System.Windows.Forms.RadioButton Nu_RadioButton;
        private System.Windows.Forms.RadioButton Nam_RadioButton;
        private System.Windows.Forms.TextBox XuatXu_TextBox;
        private System.Windows.Forms.TextBox CMND_TextBox;
        private System.Windows.Forms.TextBox MaKH_TextBox;
        private System.Windows.Forms.Label XuatXu_Label;
        private System.Windows.Forms.Label GioiTinh_Label;
        private System.Windows.Forms.Label CMND_Label;
        private System.Windows.Forms.Label TenKH_Label;
        private System.Windows.Forms.Label MaKH_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.DataGridView dgvPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Today_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
    }
}