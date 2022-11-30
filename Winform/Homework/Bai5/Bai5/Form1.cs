using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {           
            lstA.Items.Add(txtName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstA.Items.RemoveAt(lstA.SelectedIndex);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lstB.Items.Add(lstA.SelectedItem);
            lstA.Items.RemoveAt(lstA.SelectedIndex);
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            string[] ptlstA = new string[lstA.SelectedItems.Count];
            int i = 0;
            foreach (object item in lstA.SelectedItems)
            {
                lstB.Items.Add(item);
                ptlstA[i] = item.ToString();
                i++;
            }
            foreach (object item in ptlstA)
            {
                lstA.Items.Remove(item);
            }

        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            lstA.Items.Add(lstB.SelectedItem);
            lstB.Items.RemoveAt(lstB.SelectedIndex);
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            string[] ptlstB = new string[lstB.SelectedItems.Count];
            int i = 0;
            foreach (object item in lstB.SelectedItems)
            {
                lstA.Items.Add(item);
                ptlstB[i] = item.ToString();
                i++;
            }
            foreach (object item in ptlstB)
            {
                lstB.Items.Remove(item);
            }
        }
    }
}
