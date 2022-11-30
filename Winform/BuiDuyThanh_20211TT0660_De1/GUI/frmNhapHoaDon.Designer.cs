
namespace GUI
{
    partial class frmNhapHoaDon
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
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtTenHieuThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoa = new System.Windows.Forms.Button();
            this.dgvNhapHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(153, 40);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(175, 29);
            this.txtMaHoaDon.TabIndex = 81;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Mã hoá đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ngày bán";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(153, 134);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(175, 29);
            this.dtpNgayBan.TabIndex = 85;
            // 
            // txtTenHieuThuoc
            // 
            this.txtTenHieuThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHieuThuoc.Location = new System.Drawing.Point(562, 40);
            this.txtTenHieuThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHieuThuoc.Name = "txtTenHieuThuoc";
            this.txtTenHieuThuoc.Size = new System.Drawing.Size(175, 29);
            this.txtTenHieuThuoc.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tên hiệu thuốc";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(562, 134);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(175, 29);
            this.txtDiaChi.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 89;
            this.label3.Text = "Địa chỉ";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(61, 221);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 90;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(196, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(466, 221);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 45);
            this.btnLuu.TabIndex = 93;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(331, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 45);
            this.btnSua.TabIndex = 92;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoa
            // 
            this.btnThoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoa.Location = new System.Drawing.Point(601, 221);
            this.btnThoa.Name = "btnThoa";
            this.btnThoa.Size = new System.Drawing.Size(75, 45);
            this.btnThoa.TabIndex = 94;
            this.btnThoa.Text = "Thoát";
            this.btnThoa.UseVisualStyleBackColor = true;
            this.btnThoa.Click += new System.EventHandler(this.btnThoa_Click);
            // 
            // dgvNhapHoaDon
            // 
            this.dgvNhapHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHoaDon.Location = new System.Drawing.Point(-5, 321);
            this.dgvNhapHoaDon.Name = "dgvNhapHoaDon";
            this.dgvNhapHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHoaDon.Size = new System.Drawing.Size(812, 175);
            this.dgvNhapHoaDon.TabIndex = 95;
            this.dgvNhapHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHoaDon_CellClick);
            // 
            // frmNhapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 494);
            this.Controls.Add(this.dgvNhapHoaDon);
            this.Controls.Add(this.btnThoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHieuThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label5);
            this.Name = "frmNhapHoaDon";
            this.Text = "frmNhapHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmNhapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtTenHieuThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoa;
        private System.Windows.Forms.DataGridView dgvNhapHoaDon;
    }
}