using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_ListBox
{
    public partial class frmTenSinhVien : Form
    {
        public frmTenSinhVien()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lstA.Items.Add(txtTenSinhVien.Text);         
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lstB.Items.Add(lstA.SelectedItem);
            lstA.Items.Remove(lstA.SelectedItem);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lstA.Items.Add(lstB.SelectedItem);
            lstB.Items.Remove(lstB.SelectedItem);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (true) //&& txtTenSinhVien.Text == lstB.Text)
            {
                lstA.Items.Remove(txtTenSinhVien.Text);
                //lstB.Items.Remove(txtTenSinhVien.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy phần tử cần xoá", "Chú ý nhập lại",MessageBoxButtons.YesNoCancel);              
            }
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            string[] rA = new string[lstA.SelectedItems.Count];
            int i = 0;
            foreach (object rightAll in lstA.SelectedItems)
            {
                lstB.Items.Add(rightAll);
                rA[i] = rightAll.ToString();
                i++;
            }
            foreach (object rightAll in rA)
            {
                lstA.Items.Remove(rightAll);
            }
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            string[] lF = new string[lstB.SelectedItems.Count];
            int i = 0;
            foreach (object leftAll in lstB.SelectedItems)
            {
                lstA.Items.Add(leftAll);
                lF[i] = leftAll.ToString();
                i++;
            }
            foreach (object leftAll in lF)
            {
                lstB.Items.Remove(leftAll);
            }
        }
    }
}
