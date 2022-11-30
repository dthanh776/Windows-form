
namespace GUI_HoaDon
{
    partial class TraCuu
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
            this.btnTimTiep = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(184, 55);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTimTiep
            // 
            this.btnTimTiep.Location = new System.Drawing.Point(184, 125);
            this.btnTimTiep.Name = "btnTimTiep";
            this.btnTimTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTimTiep.TabIndex = 1;
            this.btnTimTiep.Text = "Tìm tiếp";
            this.btnTimTiep.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(334, 55);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(138, 20);
            this.txtTim.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTimTiep);
            this.Controls.Add(this.btnTim);
            this.Name = "TraCuu";
            this.Text = "TraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTimTiep;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}