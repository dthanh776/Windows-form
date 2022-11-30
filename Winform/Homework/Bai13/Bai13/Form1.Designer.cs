
namespace Bai13
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đồng Nai");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("9912578-Nguyễn Văn A", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("NCTH3KA", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("NCTH3KB");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("CDTH11K");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Danh sách lớp", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            this.trvDanhSach = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDanhSach
            // 
            this.trvDanhSach.Location = new System.Drawing.Point(26, 27);
            this.trvDanhSach.Name = "trvDanhSach";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Đồng Nai";
            treeNode2.Name = "Node5";
            treeNode2.Text = "9912578-Nguyễn Văn A";
            treeNode3.Name = "Node2";
            treeNode3.Text = "NCTH3KA";
            treeNode4.Name = "Node7";
            treeNode4.Text = "NCTH3KB";
            treeNode5.Name = "Node8";
            treeNode5.Text = "CDTH11K";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Danh sách lớp";
            this.trvDanhSach.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.trvDanhSach.Size = new System.Drawing.Size(236, 330);
            this.trvDanhSach.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhap);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(306, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(211, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(70, 210);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhap.TabIndex = 2;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(101, 155);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(159, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(101, 93);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(159, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(101, 36);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(159, 20);
            this.txtMa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trvDanhSach);
            this.Name = "frmMain";
            this.Text = "Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

