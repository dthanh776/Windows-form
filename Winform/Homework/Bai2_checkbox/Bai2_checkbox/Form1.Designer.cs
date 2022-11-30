
namespace Bai2_checkbox
{
    partial class frmFont
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
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.lblXuat = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.radBlack);
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(27, 148);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(57, 17);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radBlue.Location = new System.Drawing.Point(27, 111);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(50, 17);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(27, 74);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(59, 17);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(27, 37);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(48, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.chkUnderline);
            this.groupBox2.Controls.Add(this.chkItalic);
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(424, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(21, 132);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(133, 17);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Gạch chân (Underline)";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(21, 85);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(107, 17);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "In nghiêng (Italic)";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(21, 38);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(102, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "In đậm (Bold)";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.Location = new System.Drawing.Point(66, 32);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(82, 20);
            this.lblNhapTen.TabIndex = 0;
            this.lblNhapTen.Text = "Nhập tên";
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinh.Location = new System.Drawing.Point(66, 383);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(109, 20);
            this.lblLapTrinh.TabIndex = 4;
            this.lblLapTrinh.Text = "Lập trình bởi";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(181, 32);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(189, 20);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // lblXuat
            // 
            this.lblXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXuat.Location = new System.Drawing.Point(204, 383);
            this.lblXuat.Name = "lblXuat";
            this.lblXuat.Size = new System.Drawing.Size(195, 23);
            this.lblXuat.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(468, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblXuat);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.lblNhapTen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi chữ";
            this.Load += new System.EventHandler(this.frmFont_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Label lblXuat;
        private System.Windows.Forms.Button btnThoat;
    }
}

