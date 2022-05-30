using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void qlKhoa_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa(this);
            khoa.Show();
            this.Hide();
        }

        private void qlGV_Click(object sender, EventArgs e)
        {
            GiangVien giangVien = new GiangVien(this);
            giangVien.Show();
            this.Hide();
        }

        private void qlLop_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(this);
            lop.Show();
            this.Hide();
        }
    }
}
