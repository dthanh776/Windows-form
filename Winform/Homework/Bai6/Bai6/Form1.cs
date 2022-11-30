using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmCourseReg : Form
    {
        public frmCourseReg()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string rad = "";
            if (rad1.Checked == true)
            {
                rad = "semester 1 ";
            }
            else if (rad2.Checked)
            {
                rad = "semester 2 ";
            }
            else if (rad3.Checked)
            {
                rad = "semester 3 ";
            }
            else
            {
                rad = "semester 4 ";
            }

            string subject = "";
                for (int i = 0; i < chkSubject.CheckedItems.Count; i++)
                {
                    subject += "\n"+ chkSubject.CheckedItems[i].ToString();
                }              


            MessageBox.Show("Student: " + txtFullName.Text +
                            "\nClass: " + cbbClass.SelectedItem +
                            "\nSchool Year: " + cbbSchoolYear.SelectedItem +
                            "\nRegistered for the course " + rad +
                            "subjects: " + subject
                            );
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentCode.Clear();
            txtFullName.Clear();
            cbbClass.Text = string.Empty;
            cbbSchoolYear.Text = string.Empty;
            rad1.Checked = false;
            rad2.Checked = false;
            rad3.Checked = false;
            rad4.Checked = false;

        }
    }
}
