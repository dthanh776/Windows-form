
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHoáĐơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpThôngTinToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpThôngTinToolStripMenuItem
            // 
            this.nhậpThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHoáĐơnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.nhậpThôngTinToolStripMenuItem.Name = "nhậpThôngTinToolStripMenuItem";
            this.nhậpThôngTinToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.nhậpThôngTinToolStripMenuItem.Text = "Nhập thông tin";
            // 
            // nhậpHoáĐơnToolStripMenuItem
            // 
            this.nhậpHoáĐơnToolStripMenuItem.Name = "nhậpHoáĐơnToolStripMenuItem";
            this.nhậpHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nhậpHoáĐơnToolStripMenuItem.Text = "Nhập hoá đơn";
            this.nhậpHoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.nhậpHoáĐơnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmHoáĐơnThuốcToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tìmKiếmHoáĐơnThuốcToolStripMenuItem
            // 
            this.tìmKiếmHoáĐơnThuốcToolStripMenuItem.Name = "tìmKiếmHoáĐơnThuốcToolStripMenuItem";
            this.tìmKiếmHoáĐơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tìmKiếmHoáĐơnThuốcToolStripMenuItem.Text = "Tìm kiếm hoá đơn - Thuốc";
            this.tìmKiếmHoáĐơnThuốcToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmHoáĐơnThuốcToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inHoáĐơnToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // inHoáĐơnToolStripMenuItem
            // 
            this.inHoáĐơnToolStripMenuItem.Name = "inHoáĐơnToolStripMenuItem";
            this.inHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inHoáĐơnToolStripMenuItem.Text = "In hoá đơn";
            this.inHoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHoáĐơnToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BẢN THUỐC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHoáĐơnThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

