﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Main_Form : Form
    {
        public static bool isLogin; 
        public Main_Form()
        {
            isLogin = false;          
            InitializeComponent();
            KhoiTaoMoi();
        }
        private void KhoiTaoMoi()
        {
            if (isLogin == false)
            {
                this.thốngKêToolStripMenuItem.Enabled = false;
                this.quảnLýToolStripMenuItem.Enabled = false;
                this.đăngNhậpToolStripMenuItem.Enabled = true;
                this.đăngXuấtToolStripMenuItem.Enabled = false;
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form Temp = new Login_Form();
            Temp.ShowDialog();
            if (Main_Form.isLogin == true)
            {
                this.thốngKêToolStripMenuItem.Enabled = true;
                this.quảnLýToolStripMenuItem.Enabled = true;
                this.đăngNhậpToolStripMenuItem.Enabled = false;
                this.đăngXuấtToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogin = false;
            KhoiTaoMoi();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhong_Form Temp = new QuanLyPhong_Form();
            Temp.ShowDialog();
        }
    }
}