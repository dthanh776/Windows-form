using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_BangLaiXe
{
    public partial class frmLaiXe : Form
    {
        public frmLaiXe()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errPro.SetError(txtHoTen, "");
            errPro.SetError(txtTuoi, "");
            errPro.SetError(dtpNgay, "");
            if (txtHoTen.Text == "")
            {
                errPro.SetError(txtHoTen, "Vui lòng nhập tên");
                return;
            }
            int tuoi = 0;
            if (int.TryParse(txtTuoi.Text,out tuoi) == false)
            {
                errPro.SetError(txtTuoi, "Nhập sai");
            }
            else
            {
                if (tuoi < 18)
                {
                    errPro.SetError(txtTuoi, "Tuổi phải lớn hơn 17");
                    return;
                }
            }
            if (dtpNgay.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errPro.SetError(dtpNgay, "Chủ nhật nghỉ");
                return;
            }
            MessageBox.Show("Đăng kí thành công");
        }

    }
}
