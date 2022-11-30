
namespace GUI
{
    partial class frmTimKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMaHoaDon = new System.Windows.Forms.RadioButton();
            this.radMaThuoc = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtNhapThongTin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvNhapHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMaHoaDon);
            this.groupBox1.Controls.Add(this.radMaThuoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tim tìm kiếm";
            // 
            // radMaHoaDon
            // 
            this.radMaHoaDon.AutoSize = true;
            this.radMaHoaDon.Location = new System.Drawing.Point(145, 51);
            this.radMaHoaDon.Name = "radMaHoaDon";
            this.radMaHoaDon.Size = new System.Drawing.Size(130, 28);
            this.radMaHoaDon.TabIndex = 1;
            this.radMaHoaDon.TabStop = true;
            this.radMaHoaDon.Text = "Mã hoá đơn";
            this.radMaHoaDon.UseVisualStyleBackColor = true;
            // 
            // radMaThuoc
            // 
            this.radMaThuoc.AutoSize = true;
            this.radMaThuoc.Location = new System.Drawing.Point(7, 51);
            this.radMaThuoc.Name = "radMaThuoc";
            this.radMaThuoc.Size = new System.Drawing.Size(106, 28);
            this.radMaThuoc.TabIndex = 0;
            this.radMaThuoc.TabStop = true;
            this.radMaThuoc.Text = "Mã thuốc";
            this.radMaThuoc.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(659, 48);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(108, 45);
            this.btnTim.TabIndex = 94;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtNhapThongTin
            // 
            this.txtNhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapThongTin.Location = new System.Drawing.Point(194, 189);
            this.txtNhapThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapThongTin.Name = "txtNhapThongTin";
            this.txtNhapThongTin.Size = new System.Drawing.Size(175, 29);
            this.txtNhapThongTin.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 96;
            this.label5.Text = "Nhập thông tin";
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Location = new System.Drawing.Point(659, 127);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(108, 45);
            this.btnTiepTuc.TabIndex = 97;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(659, 208);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 45);
            this.btnThoat.TabIndex = 98;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvNhapHoaDon
            // 
            this.dgvNhapHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHoaDon.Location = new System.Drawing.Point(-6, 280);
            this.dgvNhapHoaDon.Name = "dgvNhapHoaDon";
            this.dgvNhapHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHoaDon.Size = new System.Drawing.Size(812, 175);
            this.dgvNhapHoaDon.TabIndex = 99;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.dgvNhapHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.txtNhapThongTin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiem_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMaHoaDon;
        private System.Windows.Forms.RadioButton radMaThuoc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtNhapThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvNhapHoaDon;
    }
}