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
using ET;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BUS_HP bus_hp = new BUS_HP();


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewHP.DataSource = bus_hp.LayDSHP();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = false;

            txtMaHP.Enabled = false;
            txtSoTietLT.Enabled = false;
            txtSoTietTH.Enabled = false;
            txtSTC.Enabled = false;
            txtTenHP.Enabled = false;
            dataGridViewHP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        bool KiemTra = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra == false)
            {
                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
                btnTim.Enabled = true;

                txtMaHP.Enabled = true;
                txtSoTietLT.Enabled = true;
                txtSoTietTH.Enabled = true;
                txtSTC.Enabled = true;
                txtTenHP.Enabled = true;
                KiemTra = true;
            }
            else
            {
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                btnTim.Enabled = false;

                txtMaHP.Enabled = false;
                txtSoTietLT.Enabled = false;
                txtSoTietTH.Enabled = false;
                txtSTC.Enabled = false;
                txtTenHP.Enabled = false;
                KiemTra = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaHP.Text;
            string ten = txtTenHP.Text;
            int stc = int.Parse(txtSTC.Text);
            int soTietLT = int.Parse(txtSoTietLT.Text);
            int soTietTH = int.Parse(txtSoTietTH.Text);
            if (ma == "" || ten == "" || stc < 0 || soTietLT < 0 || soTietTH < 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                HocPhan et = new HocPhan(ma, ten, stc, soTietLT, soTietTH);
                if (bus_hp.ThemHP(et) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txtMaHP.Text = "";
                    txtTenHP.Text = "";
                    txtSTC.Text = "";
                    txtSoTietLT.Text = "";
                    txtSoTietTH.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
            }
            dataGridViewHP.DataSource = bus_hp.LayDSHP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = dataGridViewHP.CurrentCell.RowIndex;
            if (index != -1)
            {
                try
                {
                    if (bus_hp.XoaHP(dataGridViewHP.Rows[index].Cells[0].Value.ToString()) == true)
                    {
                        MessageBox.Show("Xoá Thành Công");
                        txtTenHP.Text = "";
                        txtSoTietLT.Text = "";
                        txtSoTietTH.Text = "";
                        txtSTC.Text = "";
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
                    dataGridViewHP.DataSource = bus_hp.LayDSHP();
                }
            }
            else
            {
                MessageBox.Show("Chọn hàng cần xoá");
            }
        }

        private void dataGridViewHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewHP.CurrentCell.RowIndex;
            txtMaHP.Text = dataGridViewHP.Rows[index].Cells[0].Value.ToString();
            txtTenHP.Text = dataGridViewHP.Rows[index].Cells[1].Value.ToString();
            txtSTC.Text = dataGridViewHP.Rows[index].Cells[2].Value.ToString();
            txtSoTietLT.Text = dataGridViewHP.Rows[index].Cells[3].Value.ToString();
            txtSoTietTH.Text = dataGridViewHP.Rows[index].Cells[4].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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


    }
}
