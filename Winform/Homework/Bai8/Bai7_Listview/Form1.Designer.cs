
namespace Bai7_Listview
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ly",
            "Thi Bong",
            "23456"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyen",
            "Van Chinh",
            "4655",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tran",
            "Chanh Truc",
            "123456",
            ""}, -1);
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatListviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddName = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEmployee
            // 
            this.lvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastname,
            this.firstname,
            this.phone});
            this.lvEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployee.GridLines = true;
            this.lvEmployee.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.lvEmployee.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvEmployee.Location = new System.Drawing.Point(12, 55);
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(319, 254);
            this.lvEmployee.TabIndex = 8;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
            this.lvEmployee.View = System.Windows.Forms.View.Details;
            // 
            // lastname
            // 
            this.lastname.Text = "Last Name";
            this.lastname.Width = 90;
            // 
            // firstname
            // 
            this.firstname.Text = "First Name";
            this.firstname.Width = 121;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 133;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.formatListviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem,
            this.listToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.smallIconToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "View";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // formatListviewToolStripMenuItem
            // 
            this.formatListviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem});
            this.formatListviewToolStripMenuItem.Name = "formatListviewToolStripMenuItem";
            this.formatListviewToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.formatListviewToolStripMenuItem.Text = "Format Listview";
            // 
            // btnAddName
            // 
            this.btnAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddName.Location = new System.Drawing.Point(388, 262);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(98, 32);
            this.btnAddName.TabIndex = 6;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(385, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(146, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(385, 146);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(385, 209);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lvEmployee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ToolStripMenuItem formatListviewToolStripMenuItem;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
    }
}

