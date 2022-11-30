
namespace Bai5
{
    partial class frmStudentList
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(199, 172);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 23);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Location = new System.Drawing.Point(199, 225);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(55, 23);
            this.btnRightAll.TabIndex = 7;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(199, 278);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 23);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Location = new System.Drawing.Point(199, 331);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(55, 23);
            this.btnLeftAll.TabIndex = 9;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(329, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(378, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(329, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(286, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 207);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class B";
            // 
            // lstA
            // 
            this.lstA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 16;
            this.lstA.Location = new System.Drawing.Point(3, 18);
            this.lstA.Name = "lstA";
            this.lstA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstA.Size = new System.Drawing.Size(164, 183);
            this.lstA.TabIndex = 0;
            // 
            // lstB
            // 
            this.lstB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 16;
            this.lstB.Location = new System.Drawing.Point(3, 18);
            this.lstB.Name = "lstB";
            this.lstB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstB.Size = new System.Drawing.Size(164, 186);
            this.lstB.TabIndex = 0;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnLeftAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnRight);
            this.Name = "frmStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstB;
    }
}

