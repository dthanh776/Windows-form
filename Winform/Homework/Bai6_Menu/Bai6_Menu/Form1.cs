using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Red;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Gray;
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Random rd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(0,50).ToString(); // i
                flowLayoutPanel1.Controls.Add(btn);
                btn.ContextMenuStrip = contextMenuStrip1;
                
            }
        }
    }
}
