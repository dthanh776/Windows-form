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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        bus_sanpham bSanPham= new bus_sanpham();
        bus_NCC bNCC = new bus_NCC();
        bool check = true;
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataTable DS = bNCC.LayTenDS();
            for(int i=0; i < DS.Rows.Count; i++)
            {
                treDS.Nodes.Add(DS.Rows[i][0].ToString());
                treDS.Nodes[i].Tag = DS.Rows[i][1].ToString();
            }
            txtDacTa.Enabled = false;
            txtGia.Enabled = false;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
        }

        private void treDS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode a = treDS.SelectedNode;
            string Ma = a.Tag.ToString();
            dgvDS.DataSource = bSanPham.LayTenSP(Ma);
            txtNCC.Text = Ma;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                check = false;
                btnThem.Text = "Huỷ";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                txtDacTa.Enabled = true;
                txtGia.Enabled = true;
                txtMaSP.Enabled = true;
                txtTenSP.Enabled = true;
            }
            else
            {
                check = true;
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                txtDacTa.Enabled = false;
                txtGia.Enabled = false;
                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                txtDacTa.Text = "";
                txtGia.Text = "";
                txtMaSP.Text = "";
                txtTenSP.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string Ma = txtMaSP.Text;
            string Ten = txtTenSP.Text;
            string Mota = txtDacTa.Text;
            int gia = int.Parse(txtGia.Text);
            string ncc = txtNCC.Text;
            if (Ma == "" || Ten == "" || Mota == "" || gia < 0)
            {
                MessageBox.Show("Điển Đủ thông tin");
            }
            else
            {
                ET_sanpham et = new ET_sanpham(Ma, Ten, ncc, Mota, gia);
                if (bSanPham.ThemSanPham(et) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txtDacTa.Text = "";
                    txtGia.Text = "";
                    txtMaSP.Text = "";
                    txtTenSP.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
            }
            dgvDS.DataSource = bSanPham.LayTenSP(ncc);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            try
            {
                if (bSanPham.XoaSanPham(ma) == true)
                {
                    MessageBox.Show("Xoá Thành Công");
                    txtDacTa.Text = "";
                    txtGia.Text = "";
                    txtMaSP.Text = "";
                    txtTenSP.Text = "";
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
                dgvDS.DataSource = bSanPham.LayTenSP(txtNCC.Text);
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDS.CurrentCell.RowIndex;
            txtMaSP.Text = dgvDS.Rows[index].Cells[0].Value.ToString();
            txtTenSP.Text = dgvDS.Rows[index].Cells[1].Value.ToString();
            txtNCC.Text = dgvDS.Rows[index].Cells[2].Value.ToString();
            txtDacTa.Text = dgvDS.Rows[index].Cells[3].Value.ToString();
            txtGia.Text = dgvDS.Rows[index].Cells[4].Value.ToString();
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnThemAll_Click(object sender, EventArgs e)
        {
             frmNCC.Instance.Show();
        }
    }
}
