
namespace Bai6
{
    partial class frmCourseReg
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cbbSchoolYear = new System.Windows.Forms.ComboBox();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.chkSubject = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(153, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE REGISTRATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "School Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Subject";
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(206, 103);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(121, 20);
            this.txtStudentCode.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(206, 150);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(229, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // cbbSchoolYear
            // 
            this.cbbSchoolYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSchoolYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSchoolYear.FormattingEnabled = true;
            this.cbbSchoolYear.Items.AddRange(new object[] {
            "2016-2017",
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022"});
            this.cbbSchoolYear.Location = new System.Drawing.Point(206, 194);
            this.cbbSchoolYear.Name = "cbbSchoolYear";
            this.cbbSchoolYear.Size = new System.Drawing.Size(100, 21);
            this.cbbSchoolYear.TabIndex = 3;
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Items.AddRange(new object[] {
            "20TT1",
            "20TT2",
            "20TT3",
            "20TT4",
            "20TT5",
            "20TT6"});
            this.cbbClass.Location = new System.Drawing.Point(206, 244);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(121, 21);
            this.cbbClass.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(91, 482);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(235, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1.Location = new System.Drawing.Point(206, 289);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(29, 20);
            this.rad1.TabIndex = 6;
            this.rad1.TabStop = true;
            this.rad1.Text = "I";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad2.Location = new System.Drawing.Point(277, 289);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(32, 20);
            this.rad2.TabIndex = 6;
            this.rad2.TabStop = true;
            this.rad2.Text = "II";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad3.Location = new System.Drawing.Point(351, 289);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(35, 20);
            this.rad3.TabIndex = 6;
            this.rad3.TabStop = true;
            this.rad3.Text = "III";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad4.Location = new System.Drawing.Point(428, 289);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(38, 20);
            this.rad4.TabIndex = 6;
            this.rad4.TabStop = true;
            this.rad4.Text = "IV";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // chkSubject
            // 
            this.chkSubject.FormattingEnabled = true;
            this.chkSubject.Items.AddRange(new object[] {
            "LT WIndows",
            "LT Internet",
            "Mạng máy tính",
            "URM",
            "Lập trình C#"});
            this.chkSubject.Location = new System.Drawing.Point(206, 337);
            this.chkSubject.Name = "chkSubject";
            this.chkSubject.Size = new System.Drawing.Size(120, 64);
            this.chkSubject.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCourseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 527);
            this.Controls.Add(this.chkSubject);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.cbbSchoolYear);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtStudentCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCourseReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Registration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cbbSchoolYear;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.CheckedListBox chkSubject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

