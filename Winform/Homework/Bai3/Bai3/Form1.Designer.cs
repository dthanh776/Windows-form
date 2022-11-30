
namespace Bai3
{
    partial class frmPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkCaoVoi = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkChupHinh = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(194, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "$200.000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "$100.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trám răng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer\'s name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "$1.200.000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 397);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "$80.000/cái";
            // 
            // chkCaoVoi
            // 
            this.chkCaoVoi.AutoSize = true;
            this.chkCaoVoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaoVoi.Location = new System.Drawing.Point(69, 163);
            this.chkCaoVoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCaoVoi.Name = "chkCaoVoi";
            this.chkCaoVoi.Size = new System.Drawing.Size(76, 23);
            this.chkCaoVoi.TabIndex = 1;
            this.chkCaoVoi.Text = "Cạo vôi";
            this.chkCaoVoi.UseVisualStyleBackColor = true;
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTayTrang.Location = new System.Drawing.Point(69, 219);
            this.chkTayTrang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTayTrang.Name = "chkTayTrang";
            this.chkTayTrang.Size = new System.Drawing.Size(85, 23);
            this.chkTayTrang.TabIndex = 1;
            this.chkTayTrang.Text = "Tẩy trắng";
            this.chkTayTrang.UseVisualStyleBackColor = true;
            // 
            // chkChupHinh
            // 
            this.chkChupHinh.AutoSize = true;
            this.chkChupHinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChupHinh.Location = new System.Drawing.Point(69, 275);
            this.chkChupHinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkChupHinh.Name = "chkChupHinh";
            this.chkChupHinh.Size = new System.Drawing.Size(119, 23);
            this.chkChupHinh.TabIndex = 1;
            this.chkChupHinh.Text = "Chụp hình răng";
            this.chkChupHinh.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 97);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(254, 397);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 19);
            this.lblTotal.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(69, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(328, 454);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(151, 332);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(89, 22);
            this.numFilling.TabIndex = 5;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(495, 519);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.chkChupHinh);
            this.Controls.Add(this.chkTayTrang);
            this.Controls.Add(this.chkCaoVoi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Payment Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCaoVoi;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkChupHinh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numFilling;
    }
}

