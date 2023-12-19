namespace BELMS
{
    partial class formAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddAccount));
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblPassCheck = new System.Windows.Forms.Label();
            this.lblPassGuide = new System.Windows.Forms.Label();
            this.comboSection = new System.Windows.Forms.ComboBox();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.panelUsertype = new System.Windows.Forms.Panel();
            this.radioFaculty = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.radioBlocked = new System.Windows.Forms.RadioButton();
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCheckPass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelUsertype.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblPassCheck);
            this.panelMain.Controls.Add(this.lblPassGuide);
            this.panelMain.Controls.Add(this.comboSection);
            this.panelMain.Controls.Add(this.comboGrade);
            this.panelMain.Controls.Add(this.panelUsertype);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Controls.Add(this.txtCheckPass);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.txtPhone);
            this.panelMain.Controls.Add(this.txtFname);
            this.panelMain.Controls.Add(this.txtLname);
            this.panelMain.Controls.Add(this.txtID);
            this.panelMain.Controls.Add(this.label12);
            this.panelMain.Controls.Add(this.btnCreate);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label13);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 34);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 621);
            this.panelMain.TabIndex = 0;
            // 
            // lblPassCheck
            // 
            this.lblPassCheck.AutoSize = true;
            this.lblPassCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassCheck.ForeColor = System.Drawing.Color.Red;
            this.lblPassCheck.Location = new System.Drawing.Point(619, 319);
            this.lblPassCheck.Name = "lblPassCheck";
            this.lblPassCheck.Size = new System.Drawing.Size(39, 15);
            this.lblPassCheck.TabIndex = 20;
            this.lblPassCheck.Text = "- - - - -";
            // 
            // lblPassGuide
            // 
            this.lblPassGuide.AutoSize = true;
            this.lblPassGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassGuide.Location = new System.Drawing.Point(586, 403);
            this.lblPassGuide.Name = "lblPassGuide";
            this.lblPassGuide.Size = new System.Drawing.Size(328, 96);
            this.lblPassGuide.TabIndex = 19;
            this.lblPassGuide.Text = resources.GetString("lblPassGuide.Text");
            // 
            // comboSection
            // 
            this.comboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSection.FormattingEnabled = true;
            this.comboSection.Items.AddRange(new object[] {
            "Section A",
            "Section B",
            "Section C",
            "Section D",
            "Special Science"});
            this.comboSection.Location = new System.Drawing.Point(380, 228);
            this.comboSection.Name = "comboSection";
            this.comboSection.Size = new System.Drawing.Size(222, 24);
            this.comboSection.TabIndex = 5;
            // 
            // comboGrade
            // 
            this.comboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Items.AddRange(new object[] {
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6",
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "Grade 11",
            "Grade 12"});
            this.comboGrade.Location = new System.Drawing.Point(88, 228);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(222, 24);
            this.comboGrade.TabIndex = 4;
            // 
            // panelUsertype
            // 
            this.panelUsertype.Controls.Add(this.radioFaculty);
            this.panelUsertype.Controls.Add(this.radioStudent);
            this.panelUsertype.Controls.Add(this.label7);
            this.panelUsertype.Location = new System.Drawing.Point(88, 396);
            this.panelUsertype.Name = "panelUsertype";
            this.panelUsertype.Size = new System.Drawing.Size(143, 110);
            this.panelUsertype.TabIndex = 16;
            // 
            // radioFaculty
            // 
            this.radioFaculty.AutoSize = true;
            this.radioFaculty.Location = new System.Drawing.Point(24, 82);
            this.radioFaculty.Name = "radioFaculty";
            this.radioFaculty.Size = new System.Drawing.Size(59, 17);
            this.radioFaculty.TabIndex = 11;
            this.radioFaculty.TabStop = true;
            this.radioFaculty.Text = "Faculty";
            this.radioFaculty.UseVisualStyleBackColor = true;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(24, 50);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(62, 17);
            this.radioStudent.TabIndex = 10;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-4, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Usertype:";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.radioBlocked);
            this.panelStatus.Controls.Add(this.radioActive);
            this.panelStatus.Controls.Add(this.label9);
            this.panelStatus.Location = new System.Drawing.Point(380, 396);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(143, 110);
            this.panelStatus.TabIndex = 16;
            // 
            // radioBlocked
            // 
            this.radioBlocked.AutoSize = true;
            this.radioBlocked.Location = new System.Drawing.Point(26, 82);
            this.radioBlocked.Name = "radioBlocked";
            this.radioBlocked.Size = new System.Drawing.Size(64, 17);
            this.radioBlocked.TabIndex = 13;
            this.radioBlocked.Text = "Blocked";
            this.radioBlocked.UseVisualStyleBackColor = true;
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Checked = true;
            this.radioActive.Location = new System.Drawing.Point(26, 50);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(55, 17);
            this.radioActive.TabIndex = 12;
            this.radioActive.TabStop = true;
            this.radioActive.Text = "Active";
            this.radioActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-4, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Status:";
            // 
            // txtCheckPass
            // 
            this.txtCheckPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckPass.Location = new System.Drawing.Point(380, 314);
            this.txtCheckPass.Name = "txtCheckPass";
            this.txtCheckPass.PasswordChar = '*';
            this.txtCheckPass.Size = new System.Drawing.Size(222, 24);
            this.txtCheckPass.TabIndex = 7;
            this.txtCheckPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckPass);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(88, 314);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(222, 24);
            this.txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(665, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 24);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(665, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 24);
            this.txtPhone.TabIndex = 8;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(88, 149);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(222, 24);
            this.txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(380, 149);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(222, 24);
            this.txtLname.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(88, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 24);
            this.txtID.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(376, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Section:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(804, 538);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 41);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(661, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Check Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Grade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD AN ACCOUNT";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.PaleGreen;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(950, 34);
            this.panelTop.TabIndex = 1;
            // 
            // formAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 655);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAddAccount";
            this.Load += new System.EventHandler(this.formAddAccount_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelUsertype.ResumeLayout(false);
            this.panelUsertype.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheckPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelUsertype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.RadioButton radioFaculty;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioBlocked;
        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboSection;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.Label lblPassGuide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPassCheck;
    }
}