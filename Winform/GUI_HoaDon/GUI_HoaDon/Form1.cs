using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI_HoaDon
{
    public partial class Form1 : Form
    {
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaHoaDon.Text;
            string ten = txtTenKH.Text;
            string sdt = txtSDT.Text;
            string tenHang = txtTenHang.Text;
           
            int soLuong = int.Parse(txtSoLuong.Text);
            int donGia = int.Parse(txtDonGia.Text);
            float thanhTien = float.Parse(txtThanhTien.Text);
            if (ma == "" || ten == "" || sdt == "" || tenHang == "" || soLuong < 0 || donGia < 0 || thanhTien < 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                DTO_HoaDon dto = new DTO_HoaDon(ma, ten, sdt, tenHang, Convert.ToDateTime(dtpNgayMua.Text), soLuong, donGia, thanhTien);
                if (bus_hd.ThemHoaDon(dto) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txtMaHoaDon.Text = "";
                    txtTenKH.Text = "";
                    txtSDT.Text = "";
                    txtTenHang.Text = "";
                    
                    txtSoLuong.Text = "";
                    txtDonGia.Text = "";
                    txtThanhTien.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
            }
            dataGridView1.DataSource = bus_hd.LayHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = dataGridView1.CurrentCell.RowIndex;
            if (index != -1)
            {
                try
                {
                    if (bus_hd.XoaHoaDOn(dataGridView1.Rows[index].Cells[0].Value.ToString()) == true)
                    {
                        MessageBox.Show("Xoá Thành Công");
                        txtMaHoaDon.Text = "";
                        txtTenKH.Text = "";
                        txtSDT.Text = "";
                        txtTenHang.Text = "";

                        txtSoLuong.Text = "";
                        txtDonGia.Text = "";
                        txtThanhTien.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xoá Không Thành Công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dataGridView1.DataSource = bus_hd.LayHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Chọn hàng cần xoá");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus_hd.LayHoaDon();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaHoaDon.Text;
            string ten = txtTenKH.Text;
            string sdt = txtSDT.Text;
            string tenHang = txtTenHang.Text;

            int soLuong = int.Parse(txtSoLuong.Text);
            int donGia = int.Parse(txtDonGia.Text);
            float thanhTien = float.Parse(txtThanhTien.Text);
            if (ma == "" || ten == "" || sdt == "" || tenHang == "" || soLuong < 0 || donGia < 0 || thanhTien < 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                DTO_HoaDon dto = new DTO_HoaDon(ma, ten, sdt, tenHang, Convert.ToDateTime(dtpNgayMua.Text), soLuong, donGia, thanhTien);
                if (bus_hd.SuaHoaDon(dto) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    txtMaHoaDon.Text = "";
                    txtTenKH.Text = "";
                    txtSDT.Text = "";
                    txtTenHang.Text = "";

                    txtSoLuong.Text = "";
                    txtDonGia.Text = "";
                    txtThanhTien.Text = "";
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                }
            }
            dataGridView1.DataSource = bus_hd.LayHoaDon();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            txtMaHoaDon.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtTenHang.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            dtpNgayMua.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtSoLuong.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            txtThanhTien.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
        }
    }
}
