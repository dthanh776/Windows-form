using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_QLSP;
using ET_QLSP;
namespace GUI_QLSP
{
    public partial class frmNCC : Form
    {
        public static frmNCC instance;
        public static frmNCC Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNCC();
                }
                return instance;
            }
        }
        public frmNCC()
        {
            InitializeComponent();
        }
        bus_NCC bNCC = new bus_NCC();
        private void frmNCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = bNCC.LayDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_NCC NCC = new ET_NCC(txtMsNCC.Text,txtTenNCC.Text,txtDiaChi.Text,txtSDT.Text);
            try
            {
               if(bNCC.ThemNCC(NCC) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgvNCC.DataSource = bNCC.LayDS();
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_NCC NCC = new ET_NCC(txtMsNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
            try
            {
                if (bNCC.SuaNCC(NCC) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvNCC.DataSource = bNCC.LayDS();
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMsNCC.Text;
            try
            {
                if (bNCC.XoaNCC(ma) == true)
                {
                    MessageBox.Show("Xoá Thành Công");
                    dgvNCC.DataSource = bNCC.LayDS();
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
        }

        private void frmNCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
