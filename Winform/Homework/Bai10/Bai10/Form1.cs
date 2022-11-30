using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhuVuc.SelectedIndex.ToString() == "0")
            {
                lblDinhMuc.Text = "50";
            }
            else if (cboKhuVuc.SelectedIndex.ToString() == "1")
            {
                lblDinhMuc.Text = "100";
            }
            else
            {
                lblDinhMuc.Text = "150";
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tinhTien = int.Parse(txtSoMoi.Text) - int.Parse(txtSoCu.Text);
            lblTieuThu.Text = tinhTien.ToString();
            int tong = int.Parse(lblDinhMuc.Text) * tinhTien;
            lblThanhTien.Text = tong.ToString();
            ListViewItem items = new ListViewItem();
            items.Text = txtHoten.Text;
            items.SubItems.Add(cboKhuVuc.SelectedItem.ToString());
            items.SubItems.Add(lblDinhMuc.Text);
            items.SubItems.Add(lblTieuThu.Text);
            items.SubItems.Add(lblThanhTien.Text);
            lvDanhSach.Items.Add(items);
            int tongtien = int.Parse(lblTongTien.Text);
            lblTongTien.Text = (tongtien + tong).ToString();
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoten.Text = "";
            txtSoCu.Text = "";
            txtSoMoi.Text = "";
            lblDinhMuc.Text = "";
            lblTieuThu.Text = "";
            lblThanhTien.Text = "";
            txtHoten.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
