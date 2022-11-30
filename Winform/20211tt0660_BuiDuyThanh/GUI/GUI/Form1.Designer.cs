
namespace GUI
{
    partial class Form1
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
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridViewHP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoTietTH = new System.Windows.Forms.TextBox();
            this.txtSoTietLT = new System.Windows.Forms.TextBox();
            this.txtSTC = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(666, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(666, 73);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(666, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(666, 127);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(666, 239);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridViewHP
            // 
            this.dataGridViewHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHP.Location = new System.Drawing.Point(21, 286);
            this.dataGridViewHP.Name = "dataGridViewHP";
            this.dataGridViewHP.Size = new System.Drawing.Size(649, 214);
            this.dataGridViewHP.TabIndex = 5;
            this.dataGridViewHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHP_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoTietTH);
            this.groupBox1.Controls.Add(this.txtSoTietLT);
            this.groupBox1.Controls.Add(this.txtSTC);
            this.groupBox1.Controls.Add(this.txtTenHP);
            this.groupBox1.Controls.Add(this.txtMaHP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(21, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN HỌC PHẦN";
            // 
            // txtSoTietTH
            // 
            this.txtSoTietTH.Location = new System.Drawing.Point(197, 191);
            this.txtSoTietTH.Name = "txtSoTietTH";
            this.txtSoTietTH.Size = new System.Drawing.Size(189, 26);
            this.txtSoTietTH.TabIndex = 9;
            // 
            // txtSoTietLT
            // 
            this.txtSoTietLT.Location = new System.Drawing.Point(197, 151);
            this.txtSoTietLT.Name = "txtSoTietLT";
            this.txtSoTietLT.Size = new System.Drawing.Size(189, 26);
            this.txtSoTietLT.TabIndex = 8;
            // 
            // txtSTC
            // 
            this.txtSTC.Location = new System.Drawing.Point(197, 111);
            this.txtSTC.Name = "txtSTC";
            this.txtSTC.Size = new System.Drawing.Size(189, 26);
            this.txtSTC.TabIndex = 7;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(197, 71);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(189, 26);
            this.txtTenHP.TabIndex = 6;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(197, 31);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(189, 26);
            this.txtMaHP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Tiết TH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Tiết LT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tìn Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Học Phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Học Phần";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewHP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridViewHP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoTietTH;
        private System.Windows.Forms.TextBox txtSoTietLT;
        private System.Windows.Forms.TextBox txtSTC;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

