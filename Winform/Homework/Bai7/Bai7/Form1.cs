using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employy Name: " + txtName.Text +
                            "\nDate of Birth: " + mskBirth.Text +
                            "\nAddress: " + txtAddress.Text + 
                            "\nCity: " + txtCity.Text + 
                            "\nCountry: " + cboCountry.SelectedItem +
                            "\nQualification: "+txtQuali.Text +
                            "\nPhone: " + mskPhone.Text +
                            "\nEmail: " + txtEmail.Text +
                            "\nDate of Joinning: " + dtpJoining.Text);
        }
    }
}
