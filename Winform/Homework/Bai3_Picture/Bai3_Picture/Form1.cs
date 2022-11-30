using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Picture
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (picOn.Visible == false)
            {
            btnTurnOnOFF.Text = txtName.Text + ". Turn on the light, please";
            }
            else
            {
            btnTurnOnOFF.Text = txtName.Text + ". Turn off the light, please";
            }
        }

        private void btnTurnOnOFF_Click(object sender, EventArgs e)
        {
            if (picOn.Visible == false)
            {
                picOn.Visible = true;
                picOff.Visible = false;
                btnTurnOnOFF.Text = btnTurnOnOFF.Text.Replace("on", "off");
            }
            else
            {
                picOn.Visible = false;
                picOff.Visible = true;
                btnTurnOnOFF.Text = btnTurnOnOFF.Text.Replace("off", "on");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
