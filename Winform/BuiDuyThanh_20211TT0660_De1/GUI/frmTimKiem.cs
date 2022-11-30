using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        BLL_NhapHoaDon bLL_NhapHoaDon = new BLL_NhapHoaDon();

        private void frmTimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNhapThongTin.Text = "";
            txtNhapThongTin.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtNhapThongTin.Focus();
            if (radMaHoaDon.Checked == true)
            {
                dgvNhapHoaDon.DataSource = bLL_NhapHoaDon.hienThiHoaDon();
                fillData();
                dgvNhapHoaDon.DataSource = bLL_NhapHoaDon.TimHoaDon(txtNhapThongTin.Text);
            }
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }
        public void fillData()
        {
            dgvNhapHoaDon.DataSource = bLL_NhapHoaDon.hienThiHoaDon();
            dgvNhapHoaDon.Columns["MaHD"].HeaderText = "Mã hoá đơn";
            dgvNhapHoaDon.Columns["Ngayban"].HeaderText = "Ngày bán";
            dgvNhapHoaDon.Columns["TenHieuThuoc"].HeaderText = "Tên hiệu thuốc";
            dgvNhapHoaDon.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }

    }
}
