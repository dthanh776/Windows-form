using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HoaDon
{
    public partial class ChucNang : Form
    {
        public ChucNang()
        {
            InitializeComponent();
        }

        private void quảnLýHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChucNang_Load(object sender, EventArgs e)
        {

        }

        private void ChucNang_FormClosing(object sender, FormClosingEventArgs e)
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

        private void traCứuHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuu tc = new TraCuu();
            tc.Show();
        }
    }
}
