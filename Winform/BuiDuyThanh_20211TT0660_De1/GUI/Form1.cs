using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nhậpHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHoaDon fNhapHoaDon = new frmNhapHoaDon();
            fNhapHoaDon.Show();
        }

        private void tìmKiếmHoáĐơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }

        private void inHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao fBaoCao = new frmBaoCao();
            fBaoCao.Show();
        }
    }
}
