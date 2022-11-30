using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode trv = treeView1.SelectedNode;
            if (treeView1.SelectedNode.Text == "Khoa tin học")
            {
                lvSinhVien.Items.Clear();
                for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
                {
                    for (int j = 0; j < treeView1.Nodes[0].Nodes[0].Nodes.Count; j++)
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = treeView1.Nodes[0].Nodes[i].Nodes[j].Text;
                        items.SubItems.Add(treeView1.Nodes[0].Nodes[i].Text);
                        lvSinhVien.Items.Add(items);
                    }
                }
            }
            else if (trv.Text == treeView1.Nodes[0].Nodes[0].Text || trv.Text == treeView1.Nodes[0].Nodes[1].Text || trv.Text == treeView1.Nodes[0].Nodes[2].Text)
            {
                lvSinhVien.Items.Clear();
                for (int j = 0; j < trv.Nodes.Count; j++)
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = trv.Nodes[j].Text;
                    items.SubItems.Add(trv.Text);
                    lvSinhVien.Items.Add(items);
                }
            }
            else
            {
                lvSinhVien.Items.Clear();
                ListViewItem items = new ListViewItem();
                items.Text = trv.Text;
                lvSinhVien.Items.Add(items);
            }
        }
    }
}
