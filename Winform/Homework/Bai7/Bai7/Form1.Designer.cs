
namespace Bai7
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtQuali = new System.Windows.Forms.TextBox();
            this.dtpJoining = new System.Windows.Forms.DateTimePicker();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblQuali = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblJoinning = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.mskBirth = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(238, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(167, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(238, 168);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(167, 76);
            this.txtCity.TabIndex = 0;
            // 
            // txtQuali
            // 
            this.txtQuali.Location = new System.Drawing.Point(238, 306);
            this.txtQuali.Multiline = true;
            this.txtQuali.Name = "txtQuali";
            this.txtQuali.Size = new System.Drawing.Size(167, 71);
            this.txtQuali.TabIndex = 0;
            // 
            // dtpJoining
            // 
            this.dtpJoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoining.Location = new System.Drawing.Point(238, 483);
            this.dtpJoining.Name = "dtpJoining";
            this.dtpJoining.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpJoining.RightToLeftLayout = true;
            this.dtpJoining.Size = new System.Drawing.Size(167, 22);
            this.dtpJoining.TabIndex = 1;
            this.dtpJoining.Value = new System.DateTime(2021, 10, 13, 15, 42, 42, 0);
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(238, 399);
            this.mskPhone.Mask = "000-0000000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(167, 20);
            this.mskPhone.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(238, 538);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(363, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(69, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Employee Name:";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(85, 79);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(90, 32);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "Date of Birth\r\n(mm/dd/yyyy)";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(111, 132);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(132, 172);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 16);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(113, 270);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(53, 16);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "Country";
            // 
            // lblQuali
            // 
            this.lblQuali.AutoSize = true;
            this.lblQuali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuali.Location = new System.Drawing.Point(91, 310);
            this.lblQuali.Name = "lblQuali";
            this.lblQuali.Size = new System.Drawing.Size(81, 16);
            this.lblQuali.TabIndex = 4;
            this.lblQuali.Text = "Qualification";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(124, 443);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(118, 403);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 16);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblJoinning
            // 
            this.lblJoinning.AutoSize = true;
            this.lblJoinning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinning.Location = new System.Drawing.Point(72, 483);
            this.lblJoinning.Name = "lblJoinning";
            this.lblJoinning.Size = new System.Drawing.Size(104, 32);
            this.lblJoinning.TabIndex = 4;
            this.lblJoinning.Text = "Date of Joinning\r\n(mm/dd/yyyy)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(238, 439);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // cboCountry
            // 
            this.cboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "VietNam",
            "ThaiLan"});
            this.cboCountry.Location = new System.Drawing.Point(238, 264);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(167, 21);
            this.cboCountry.TabIndex = 5;
            // 
            // mskBirth
            // 
            this.mskBirth.Location = new System.Drawing.Point(238, 79);
            this.mskBirth.Mask = "00/00/0000";
            this.mskBirth.Name = "mskBirth";
            this.mskBirth.Size = new System.Drawing.Size(167, 20);
            this.mskBirth.TabIndex = 2;
            this.mskBirth.ValidatingType = typeof(System.DateTime);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 579);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblJoinning);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblQuali);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.mskBirth);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.dtpJoining);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtQuali);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtQuali;
        private System.Windows.Forms.DateTimePicker dtpJoining;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblQuali;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblJoinning;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.MaskedTextBox mskBirth;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

