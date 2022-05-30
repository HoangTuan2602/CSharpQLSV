using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.BLL;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.GUI
{
    public partial class ThemSuaKhoa : Form
    {
        DTO_Khoa dtoKhoa;
        BLL_Khoa bllKhoa = new BLL_Khoa();
        bool themSua;
        Khoa _khoa;
        public ThemSuaKhoa(Khoa khoa, string formName, bool themSua, string maKhoa, string tenKhoa)
        {
            InitializeComponent();
            Text = formName;
            _khoa = khoa;
            this.themSua = themSua;
            dtoKhoa = new DTO_Khoa(maKhoa, tenKhoa);
            if (!themSua)
            {
                txtMaKhoa.Enabled = false;
                txtMaKhoa.BackColor = Color.White;
                txtMaKhoa.Text = maKhoa;
                txtTenKhoa.Text = tenKhoa;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_Khoa newKhoa = new DTO_Khoa(txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim());
            if (themSua) // Thêm khoa
            {
                if (bllKhoa.themKhoa(newKhoa))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                    txtMaKhoa.Focus();
                }
            }
            else // Sửa khoa
            {
                if (bllKhoa.suaKhoa(newKhoa))
                {
                    MessageBox.Show("Sửa khoa thành công");
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa khoa không thành công");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn huỷ thao tác vừa rồi không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (themSua)
            {
                btnLuu.Enabled = (txtMaKhoa.Text.Trim().Length > 0 && txtTenKhoa.Text.Trim().Length > 0);
            }
            else
            {
                btnLuu.Enabled = (txtTenKhoa.Text.Trim() != dtoKhoa.tenKhoa && txtTenKhoa.Text.Trim().Length > 0);
            }
        }

        private void ThemSuaKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            _khoa.loadKhoa();
        }
    }
}
