using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_checkbox
{
    public partial class frmFont : Form
    {
        public frmFont()
        {
            InitializeComponent();
        }

        private void frmFont_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblXuat.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lblXuat.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
            {
                lblXuat.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
            {
                lblXuat.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked == true)
            {
                lblXuat.ForeColor = radBlack.ForeColor;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked == true)
            {
            lblXuat.Font = new Font(lblXuat.Font.Name,
                                        lblXuat.Font.Size,
                                        lblXuat.Font.Style ^ FontStyle.Bold);
            }

        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked == true)
            {
                lblXuat.Font = new Font(lblXuat.Font.Name,
                                            lblXuat.Font.Size,
                                            lblXuat.Font.Style ^ FontStyle.Italic);
            }
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderline.Checked == true)
            {
                lblXuat.Font = new Font(lblXuat.Font.Name,
                                            lblXuat.Font.Size,
                                            lblXuat.Font.Style ^ FontStyle.Underline);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
