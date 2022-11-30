using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string fullName = txtFirstName.Text + " " + txtLastName.Text;
            TreeNode root = new TreeNode(fullName);

            for (int i = 0; i < trvSort.Nodes.Count; i++)
            {
                if (txtFirstName.Text.ToUpper().Substring(0, 1) == trvSort.Nodes[i].Text)
                {
                    trvSort.Nodes[i].Nodes.Add(fullName);
                }
            }

        }
        void aphalbet()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                trvSort.Nodes.Add(i.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aphalbet();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Do you want to continue?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
