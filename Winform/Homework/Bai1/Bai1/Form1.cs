using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs =  MessageBox.Show("Do you want to close this Form", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            int tuoi = 0;
            if (name.Length == 0)
            {
                errorProvider1.SetError(txtName, "Enter your name, please");

            }
            if (age.Length == 0)
            {
                errorProvider1.SetError(txtAge, "Enter your date of birth, please");
            }
            else if (age.Length > 0 && name.Length > 0  && char.IsDigit(age,age.Length - 1))
            {
                tuoi = DateTime.Now.Year - Convert.ToInt32(age);
            errorProvider1.Clear();
            MessageBox.Show("My name is: " + name + "\nAge: " + tuoi);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtName.Clear();
        }
    }
}
