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
    public partial class frmNhapHoaDon : Form
    {
        public frmNhapHoaDon()
        {
            InitializeComponent();
        }
        bool check = true;
        BLL_NhapHoaDon bll_NhapHoaDon = new BLL_NhapHoaDon();

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhapHoaDon_Load(object sender, EventArgs e)
        {
            dgvNhapHoaDon.DataSource = bll_NhapHoaDon.hienThiHoaDon();
            dgvNhapHoaDon.Columns["MaHD"].HeaderText = "Mã hoá đơn";
            dgvNhapHoaDon.Columns["Ngayban"].HeaderText = "Ngày bán";
            dgvNhapHoaDon.Columns["TenHieuThuoc"].HeaderText = "Tên hiệu thuốc";
            dgvNhapHoaDon.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }

        private void frmNhapHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                check = false;
                txtMaHoaDon.Enabled = true;
                txtTenHieuThuoc.Enabled = true;
                txtDiaChi.Enabled = true;
                dtpNgayBan.Enabled = true;
            }
            else
            {
                check = true;
                txtMaHoaDon.Enabled = false;
                txtTenHieuThuoc.Enabled = false;
                txtDiaChi.Enabled = false;
                dtpNgayBan.Enabled = false;
                txtMaHoaDon.Text = "";
                txtTenHieuThuoc.Text = "";
                txtDiaChi.Text = "";
                dtpNgayBan.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiaChi.Text == "" || txtMaHoaDon.Text == "" || txtTenHieuThuoc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    DTO_NhapHoaDon nhapHoaDon = new DTO_NhapHoaDon(txtMaHoaDon.Text, dtpNgayBan.Value, txtTenHieuThuoc.Text, txtDiaChi.Text);
                    if (bll_NhapHoaDon.CheckTonTai(nhapHoaDon))
                    {
                        MessageBox.Show("Đã tồn tại mã hoá đơn này");
                    }
                    else
                    {
                        if (bll_NhapHoaDon.ThemHoaDon(nhapHoaDon) > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                            dgvNhapHoaDon.DataSource = bll_NhapHoaDon.hienThiHoaDon();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhapHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhapHoaDon.CurrentCell.RowIndex;
            txtMaHoaDon.Text = dgvNhapHoaDon.Rows[index].Cells[0].Value.ToString();
            dtpNgayBan.Text = dgvNhapHoaDon.Rows[index].Cells[1].Value.ToString();
            txtTenHieuThuoc.Text = dgvNhapHoaDon.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhapHoaDon.Rows[index].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                check = false;
                txtMaHoaDon.Enabled = true;
                txtTenHieuThuoc.Enabled = true;
                txtDiaChi.Enabled = true;
                dtpNgayBan.Enabled = true;
            }
            else
            {
                DTO_NhapHoaDon nhapHoaDon = new DTO_NhapHoaDon(txtMaHoaDon.Text, dtpNgayBan.Value, txtTenHieuThuoc.Text, txtDiaChi.Text);
                if (bll_NhapHoaDon.CheckTonTai(nhapHoaDon))
                {
                    if (bll_NhapHoaDon.SuaHoaDon(nhapHoaDon) > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvNhapHoaDon.DataSource = bll_NhapHoaDon.hienThiHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mã hoá đơn không tồn tại");
                }
            }
        }
        public void Reset()
        {
            txtDiaChi.Text = "";
            txtMaHoaDon.Text = "";
            txtTenHieuThuoc.Text = "";
            dtpNgayBan.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHoaDon.Text;
            try
            {
                if (!string.IsNullOrEmpty(txtMaHoaDon.Text) || !string.IsNullOrEmpty(txtDiaChi.Text) || !string.IsNullOrEmpty(txtTenHieuThuoc.Text))
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        if (bll_NhapHoaDon.XoaHoaDon(ma) == true)
                        {
                            MessageBox.Show("Xoá Thành Công");
                            dgvNhapHoaDon.DataSource = bll_NhapHoaDon.hienThiHoaDon();
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("Xoá Không Thành Công");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hoá đơn để xoá");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
