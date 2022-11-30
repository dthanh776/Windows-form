using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void ThemNode(TreeNode node, string Value)
        {
            node.Nodes.Add(Value);
        }
        private bool KT(string masv)
        {
            for (int i = 0; i < trvDanhSach.Nodes[0].Nodes.Count; i++)
            {
                for (int j = 0; j < trvDanhSach.Nodes[0].Nodes[i].Nodes.Count; j++)
                {
                    string[] kt = trvDanhSach.Nodes[0].Nodes[i].Nodes[j].Text.Split("-");
                    if (kt[0] == masv)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtMa.Text != "" && txtDiaChi.Text != "")
            {
                TreeNode a = trvDanhSach.SelectedNode;
                bool check = false;
                if (KT(txtMa.Text) == true)
                {
                    for (int i = 0; i < trvDanhSach.Nodes[0].Nodes.Count; i++)
                    {
                        if (trvDanhSach.Nodes[0].Nodes[i].Text == a.Text)
                        {
                            trvDanhSach.Nodes[0].Nodes[i].Nodes.Add(txtMa.Text + "-" + txtMa.Text);
                            int so = trvDanhSach.Nodes[0].Nodes[i].Nodes.Count;
                            if (so != 0)
                            {
                                ThemNode(trvDanhSach.Nodes[0].Nodes[i].Nodes[so - 1], txtDiaChi.Text);
                            }
                            else
                            {
                                ThemNode(trvDanhSach.Nodes[0].Nodes[i].Nodes[0], txtDiaChi.Text);
                            }
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        MessageBox.Show("Chưa chọn lớp cần thêm!!");
                    }
                }
                else
                {
                    MessageBox.Show("Đã có Mã SV này rồi");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập dữ liệu!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < trvDanhSach.Nodes[0].Nodes.Count; i++)
            {
                for (int j = 0; j < trvDanhSach.Nodes[0].Nodes[i].Nodes.Count; j++)
                {
                    if (trvDanhSach.Nodes[0].Nodes[i].Nodes[j].Text == trvDanhSach.SelectedNode.Text)
                    {
                        check = true;
                        DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (kq == DialogResult.Yes)
                        {
                            trvDanhSach.Nodes[0].Nodes[i].Nodes[j].Remove();
                        }
                        else
                        {
                        }
                        break;
                    }
                }
            }
            if (check == false)
            {
                MessageBox.Show("Chưa chọn SV cần xóa!!!");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
