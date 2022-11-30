using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtStudentCode.Text != string.Empty || txtFullName.Text != string.Empty || txtAddress.Text != string.Empty)
            {
                ListViewItem items = new ListViewItem();
                items.Text = txtStudentCode.Text;
                items.SubItems.Add(txtFullName.Text);
                items.SubItems.Add(txtAddress.Text);
                items.SubItems.Add(dptDate.Text);
                items.SubItems.Add(cboClass.Text);

                lvStudentInfomation.Items.Add(items);
                txtStudentCode.Text = "";
                txtAddress.Text = "";
                txtFullName.Text = "";
                cboClass.SelectedIndex = 0;
                txtStudentCode.Focus();
            }
            else
            {
                MessageBox.Show("Not entered data");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int row = lvStudentInfomation.SelectedIndices[0];
            lvStudentInfomation.Items[row].SubItems[0].Text = txtStudentCode.Text;
            lvStudentInfomation.Items[row].SubItems[1].Text = txtFullName.Text;
            lvStudentInfomation.Items[row].SubItems[2].Text = txtAddress.Text;
            lvStudentInfomation.Items[row].SubItems[3].Text = dptDate.Text;
            lvStudentInfomation.Items[row].SubItems[4].Text = txtStudentCode.Text;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            ListViewItem item = lvStudentInfomation.SelectedItems[0];
            lvStudentInfomation.Items.Remove(item);
        }

        private void lvStudentInfomation_Click(object sender, EventArgs e)
        {
            int row = lvStudentInfomation.SelectedIndices[0];
            txtStudentCode.Text = lvStudentInfomation.Items[row].SubItems[0].Text;
            txtFullName.Text = lvStudentInfomation.Items[row].SubItems[1].Text;
            txtAddress.Text = lvStudentInfomation.Items[row].SubItems[2].Text;
            dptDate.Text = lvStudentInfomation.Items[row].SubItems[3].Text;
            cboClass.Text = lvStudentInfomation.Items[row].SubItems[4].Text;
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
