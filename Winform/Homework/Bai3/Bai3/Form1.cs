using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, "Hey, you forgot customer's name");
                MessageBox.Show("Enter customer's name");
            }
            else
            {
                errorProvider1.Clear();
            }

            int total = 0;
            if (chkCaoVoi.Checked == true)
            {
                total += 100000;
            }
            if (chkTayTrang.Checked == true)
            {
                total += 1200000;
            }
            if (chkChupHinh.Checked == true)
            {
                total += 200000;
            }
            total += 80000 * Convert.ToInt32(numFilling.Value);
            lblTotal.Text = total.ToString();
            MessageBox.Show( "Hello: " + txtName.Text +"\nTotal amount to be paid is: " + total + "\nSee you later");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
