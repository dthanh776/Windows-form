
namespace Bai5_ListBox
{
    partial class frmTenSinhVien
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
            this.lbls = new System.Windows.Forms.Label();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Location = new System.Drawing.Point(70, 48);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(71, 13);
            this.lbls.TabIndex = 0;
            this.lbls.Text = "Tên sinh viên";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(213, 40);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(207, 20);
            this.txtTenSinhVien.TabIndex = 2;
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Location = new System.Drawing.Point(57, 159);
            this.lstA.Name = "lstA";
            this.lstA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstA.Size = new System.Drawing.Size(119, 186);
            this.lstA.TabIndex = 3;
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.Location = new System.Drawing.Point(312, 159);
            this.lstB.Name = "lstB";
            this.lstB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstB.Size = new System.Drawing.Size(120, 186);
            this.lstB.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(213, 85);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(200, 159);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Location = new System.Drawing.Point(200, 213);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(75, 23);
            this.btnRightAll.TabIndex = 4;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(406, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(200, 267);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Location = new System.Drawing.Point(200, 321);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(75, 23);
            this.btnLeftAll.TabIndex = 4;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(352, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmTenSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLeftAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lstB);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.lbls);
            this.Name = "frmTenSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tên Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnXoa;
    }
}

