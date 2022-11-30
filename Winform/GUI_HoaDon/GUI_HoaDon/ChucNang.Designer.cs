
namespace GUI_HoaDon
{
    partial class ChucNang
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHoáĐơnToolStripMenuItem,
            this.traCứuHoáĐơnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quảnLýHoáĐơnToolStripMenuItem
            // 
            this.quảnLýHoáĐơnToolStripMenuItem.Name = "quảnLýHoáĐơnToolStripMenuItem";
            this.quảnLýHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýHoáĐơnToolStripMenuItem.Text = "Quản lý hoá đơn";
            this.quảnLýHoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHoáĐơnToolStripMenuItem_Click);
            // 
            // traCứuHoáĐơnToolStripMenuItem
            // 
            this.traCứuHoáĐơnToolStripMenuItem.Name = "traCứuHoáĐơnToolStripMenuItem";
            this.traCứuHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.traCứuHoáĐơnToolStripMenuItem.Text = "Tra cứu hoá đơn";
            this.traCứuHoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.traCứuHoáĐơnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChucNang";
            this.Text = "ChucNang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChucNang_FormClosing);
            this.Load += new System.EventHandler(this.ChucNang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}