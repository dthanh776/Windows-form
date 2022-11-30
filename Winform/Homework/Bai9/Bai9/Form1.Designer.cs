
namespace Bai9
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "SV001",
            "Lê Quang Thọ",
            "Bình Thạnh",
            "01/01/1990",
            "Lớp A"}, -1);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.dptDate = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvStudentInfomation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.dptDate);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtStudentCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Infomation";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(430, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(430, 173);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(78, 44);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(430, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(430, 41);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(78, 44);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "TT1",
            "TT2",
            "TT3",
            "TT4"});
            this.cboClass.Location = new System.Drawing.Point(196, 257);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(174, 24);
            this.cboClass.TabIndex = 3;
            // 
            // dptDate
            // 
            this.dptDate.Location = new System.Drawing.Point(196, 203);
            this.dptDate.Name = "dptDate";
            this.dptDate.Size = new System.Drawing.Size(174, 22);
            this.dptDate.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(196, 95);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(174, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(196, 149);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(196, 41);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(174, 22);
            this.txtStudentCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Code";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.smallToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 114);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.smallToolStripMenuItem.Text = "Small";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            // 
            // lvStudentInfomation
            // 
            this.lvStudentInfomation.BackColor = System.Drawing.SystemColors.Window;
            this.lvStudentInfomation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStudentInfomation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvStudentInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStudentInfomation.FullRowSelect = true;
            this.lvStudentInfomation.GridLines = true;
            this.lvStudentInfomation.HideSelection = false;
            this.lvStudentInfomation.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvStudentInfomation.Location = new System.Drawing.Point(52, 343);
            this.lvStudentInfomation.Name = "lvStudentInfomation";
            this.lvStudentInfomation.Size = new System.Drawing.Size(646, 162);
            this.lvStudentInfomation.TabIndex = 2;
            this.lvStudentInfomation.UseCompatibleStateImageBehavior = false;
            this.lvStudentInfomation.View = System.Windows.Forms.View.Details;
            this.lvStudentInfomation.Click += new System.EventHandler(this.lvStudentInfomation_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student Code";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date of Birth";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Class";
            this.columnHeader5.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.lvStudentInfomation);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.DateTimePicker dptDate;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ListView lvStudentInfomation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

