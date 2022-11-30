using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7_Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != string.Empty || txtFirstName.Text != string.Empty || txtPhone.Text != string.Empty)
            {
            ListViewItem items = new ListViewItem(txtLastName.Text);
            items.SubItems.Add(txtFirstName.Text);
            items.SubItems.Add(txtPhone.Text);
            lvEmployee.Items.Add(items);
            }
            else
            {
                MessageBox.Show("Please do not leave it blank");
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvEmployee.View = View.Details;          
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvEmployee.View = View.List;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvEmployee.View = View.LargeIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvEmployee.View = View.Tile;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvEmployee.View = View.SmallIcon;
        }

    }
}
