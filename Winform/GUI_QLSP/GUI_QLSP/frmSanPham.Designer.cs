
namespace GUI_QLSP
{
    partial class frmSanPham
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
            this.btnThemAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDacTa = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.treDS = new System.Windows.Forms.TreeView();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemAll
            // 
            this.btnThemAll.Location = new System.Drawing.Point(35, 407);
            this.btnThemAll.Name = "btnThemAll";
            this.btnThemAll.Size = new System.Drawing.Size(207, 23);
            this.btnThemAll.TabIndex = 26;
            this.btnThemAll.Text = "Thêm nhà Cung Cấp";
            this.btnThemAll.UseVisualStyleBackColor = true;
            this.btnThemAll.Click += new System.EventHandler(this.btnThemAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtDacTa);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(288, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 166);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Sản Phẩm";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(152, 139);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.ReadOnly = true;
            this.txtNCC.Size = new System.Drawing.Size(304, 22);
            this.txtNCC.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhà Cung Cấp:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(152, 111);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(304, 22);
            this.txtGia.TabIndex = 7;
            // 
            // txtDacTa
            // 
            this.txtDacTa.Location = new System.Drawing.Point(152, 83);
            this.txtDacTa.Name = "txtDacTa";
            this.txtDacTa.Size = new System.Drawing.Size(304, 22);
            this.txtDacTa.TabIndex = 6;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(152, 55);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(304, 22);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(152, 27);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(304, 22);
            this.txtMaSP.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá DV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đặc Tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // treDS
            // 
            this.treDS.HideSelection = false;
            this.treDS.Location = new System.Drawing.Point(20, 76);
            this.treDS.Name = "treDS";
            this.treDS.Size = new System.Drawing.Size(236, 321);
            this.treDS.TabIndex = 22;
            this.treDS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treDS_AfterSelect);
            // 
            // dgvDS
            // 
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Location = new System.Drawing.Point(284, 64);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 24;
            this.dgvDS.Size = new System.Drawing.Size(496, 143);
            this.dgvDS.TabIndex = 21;
            this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(705, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(440, 407);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(574, 407);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(312, 407);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treDS);
            this.Controls.Add(this.dgvDS);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmSanPham";
            this.Text = "winfrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDacTa;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treDS;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}