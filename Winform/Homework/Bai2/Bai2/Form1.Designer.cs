
namespace Bai2
{
    partial class frmCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDiv = new System.Windows.Forms.RadioButton();
            this.radMul = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(147, 31);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(82, 20);
            this.txtNumber1.TabIndex = 1;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(147, 85);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(82, 20);
            this.txtNumber2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDiv);
            this.groupBox1.Controls.Add(this.radMul);
            this.groupBox1.Controls.Add(this.radSub);
            this.groupBox1.Controls.Add(this.radAdd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // radDiv
            // 
            this.radDiv.AutoSize = true;
            this.radDiv.Location = new System.Drawing.Point(334, 33);
            this.radDiv.Name = "radDiv";
            this.radDiv.Size = new System.Drawing.Size(73, 21);
            this.radDiv.TabIndex = 3;
            this.radDiv.TabStop = true;
            this.radDiv.Text = "Division";
            this.radDiv.UseVisualStyleBackColor = true;
            this.radDiv.CheckedChanged += new System.EventHandler(this.radDiv_CheckedChanged);
            // 
            // radMul
            // 
            this.radMul.AutoSize = true;
            this.radMul.Location = new System.Drawing.Point(211, 33);
            this.radMul.Name = "radMul";
            this.radMul.Size = new System.Drawing.Size(104, 21);
            this.radMul.TabIndex = 2;
            this.radMul.TabStop = true;
            this.radMul.Text = "Multiplication";
            this.radMul.UseVisualStyleBackColor = true;
            this.radMul.CheckedChanged += new System.EventHandler(this.radMul_CheckedChanged);
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.Location = new System.Drawing.Point(100, 33);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(92, 21);
            this.radSub.TabIndex = 1;
            this.radSub.TabStop = true;
            this.radSub.Text = "Subtraction";
            this.radSub.UseVisualStyleBackColor = true;
            this.radSub.CheckedChanged += new System.EventHandler(this.radSub_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(6, 33);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(75, 21);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Addition";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.Click += new System.EventHandler(this.radAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(147, 263);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(172, 23);
            this.lblResult.TabIndex = 6;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 308);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDiv;
        private System.Windows.Forms.RadioButton radMul;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
    }
}

