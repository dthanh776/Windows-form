
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nguyễn Văn Tuấn");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nguyễn Thị Lan");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nguyễn Văn Lương");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("THTH5A", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Lê Nghiệp");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Trần Long");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Lý Hải");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("THTH5B", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Lê Trung");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Trần Minh");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nguyễn Du");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("THTH5C", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khoa tin học", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(24, 89);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Nguyễn Văn Tuấn";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Nguyễn Thị Lan";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Nguyễn Văn Lương";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node2";
            treeNode4.Text = "THTH5A";
            treeNode5.Name = "Node23";
            treeNode5.Text = "Lê Nghiệp";
            treeNode6.Name = "Node25";
            treeNode6.Text = "Trần Long";
            treeNode7.Name = "Node26";
            treeNode7.Text = "Lý Hải";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "Node21";
            treeNode8.Text = "THTH5B";
            treeNode9.Name = "Node32";
            treeNode9.Text = "Lê Trung";
            treeNode10.Name = "Node33";
            treeNode10.Text = "Trần Minh";
            treeNode11.Name = "Node34";
            treeNode11.Text = "Nguyễn Du";
            treeNode12.ImageIndex = 5;
            treeNode12.Name = "Node29";
            treeNode12.Text = "THTH5C";
            treeNode13.ImageIndex = 0;
            treeNode13.Name = "Node0";
            treeNode13.Text = "Khoa tin học";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(258, 260);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "accept.png");
            this.imageList1.Images.SetKeyName(2, "accept_page.png");
            this.imageList1.Images.SetKeyName(3, "add.png");
            this.imageList1.Images.SetKeyName(4, "add_page.png");
            this.imageList1.Images.SetKeyName(5, "user.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(306, 23);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(165, 20);
            this.txtNhapTen.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(503, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.LargeImageList = this.imageList1;
            this.lvSinhVien.Location = new System.Drawing.Point(306, 89);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(272, 260);
            this.lvSinhVien.SmallImageList = this.imageList1;
            this.lvSinhVien.TabIndex = 4;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sinh viên";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lớp";
            this.columnHeader2.Width = 92;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 388);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

