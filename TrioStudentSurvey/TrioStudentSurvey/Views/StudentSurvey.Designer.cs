namespace TrioStudentSurvey
{
    partial class StudentSurvey
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
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTutoring = new System.Windows.Forms.TextBox();
            this.txbOther = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ckbMentalHealth = new System.Windows.Forms.CheckBox();
            this.ckbFinancialAid = new System.Windows.Forms.CheckBox();
            this.ckbRegisterDisability = new System.Windows.Forms.CheckBox();
            this.ckbCareerExploration = new System.Windows.Forms.CheckBox();
            this.ckbAcademicCoaching = new System.Windows.Forms.CheckBox();
            this.ckbTrioClub = new System.Windows.Forms.CheckBox();
            this.ckbStudyAid = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTutoring = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblStudentIdRequired = new System.Windows.Forms.Label();
            this.lblFirstNameRequired = new System.Windows.Forms.Label();
            this.lblLastNameRequired = new System.Windows.Forms.Label();
            this.lblEmailRequired = new System.Windows.Forms.Label();
            this.lblSaveSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(338, 134);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(184, 26);
            this.txtStudentId.TabIndex = 0;
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(338, 196);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(184, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(338, 256);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(184, 26);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(338, 317);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 26);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(338, 377);
            this.txtPhone.MaxLength = 14;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(184, 26);
            this.txtPhone.TabIndex = 4;
            // 
            // txtTutoring
            // 
            this.txtTutoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutoring.Location = new System.Drawing.Point(833, 130);
            this.txtTutoring.Name = "txtTutoring";
            this.txtTutoring.Size = new System.Drawing.Size(178, 26);
            this.txtTutoring.TabIndex = 6;
            // 
            // txbOther
            // 
            this.txbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOther.Location = new System.Drawing.Point(821, 491);
            this.txbOther.Name = "txbOther";
            this.txbOther.Size = new System.Drawing.Size(268, 103);
            this.txbOther.TabIndex = 7;
            this.txbOther.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(288, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(431, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ckbMentalHealth
            // 
            this.ckbMentalHealth.AutoSize = true;
            this.ckbMentalHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMentalHealth.Location = new System.Drawing.Point(682, 196);
            this.ckbMentalHealth.Name = "ckbMentalHealth";
            this.ckbMentalHealth.Size = new System.Drawing.Size(380, 24);
            this.ckbMentalHealth.TabIndex = 10;
            this.ckbMentalHealth.Text = "Mental Health and Wellness Workshops & Activities";
            this.ckbMentalHealth.UseVisualStyleBackColor = true;
            // 
            // ckbFinancialAid
            // 
            this.ckbFinancialAid.AutoSize = true;
            this.ckbFinancialAid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFinancialAid.Location = new System.Drawing.Point(682, 237);
            this.ckbFinancialAid.Name = "ckbFinancialAid";
            this.ckbFinancialAid.Size = new System.Drawing.Size(448, 24);
            this.ckbFinancialAid.TabIndex = 11;
            this.ckbFinancialAid.Text = "Financial Aid Assistance and Literacy (FAFSA, Scholarship)";
            this.ckbFinancialAid.UseVisualStyleBackColor = true;
            // 
            // ckbRegisterDisability
            // 
            this.ckbRegisterDisability.AutoSize = true;
            this.ckbRegisterDisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRegisterDisability.Location = new System.Drawing.Point(682, 277);
            this.ckbRegisterDisability.Name = "ckbRegisterDisability";
            this.ckbRegisterDisability.Size = new System.Drawing.Size(250, 24);
            this.ckbRegisterDisability.TabIndex = 12;
            this.ckbRegisterDisability.Text = "Register with Disability Services";
            this.ckbRegisterDisability.UseVisualStyleBackColor = true;
            // 
            // ckbCareerExploration
            // 
            this.ckbCareerExploration.AutoSize = true;
            this.ckbCareerExploration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCareerExploration.Location = new System.Drawing.Point(682, 317);
            this.ckbCareerExploration.Name = "ckbCareerExploration";
            this.ckbCareerExploration.Size = new System.Drawing.Size(415, 24);
            this.ckbCareerExploration.TabIndex = 13;
            this.ckbCareerExploration.Text = "Career Exploration Planning (MCIS, LinkedIn, Resume)";
            this.ckbCareerExploration.UseVisualStyleBackColor = true;
            // 
            // ckbAcademicCoaching
            // 
            this.ckbAcademicCoaching.AutoSize = true;
            this.ckbAcademicCoaching.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAcademicCoaching.Location = new System.Drawing.Point(682, 357);
            this.ckbAcademicCoaching.Name = "ckbAcademicCoaching";
            this.ckbAcademicCoaching.Size = new System.Drawing.Size(169, 24);
            this.ckbAcademicCoaching.TabIndex = 14;
            this.ckbAcademicCoaching.Text = "Academic Coaching";
            this.ckbAcademicCoaching.UseVisualStyleBackColor = true;
            // 
            // ckbTrioClub
            // 
            this.ckbTrioClub.AutoSize = true;
            this.ckbTrioClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTrioClub.Location = new System.Drawing.Point(682, 395);
            this.ckbTrioClub.Name = "ckbTrioClub";
            this.ckbTrioClub.Size = new System.Drawing.Size(125, 24);
            this.ckbTrioClub.TabIndex = 15;
            this.ckbTrioClub.Text = "Trio S2S Club";
            this.ckbTrioClub.UseVisualStyleBackColor = true;
            // 
            // ckbStudyAid
            // 
            this.ckbStudyAid.AutoSize = true;
            this.ckbStudyAid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStudyAid.Location = new System.Drawing.Point(682, 434);
            this.ckbStudyAid.Name = "ckbStudyAid";
            this.ckbStudyAid.Size = new System.Drawing.Size(96, 24);
            this.ckbStudyAid.TabIndex = 16;
            this.ckbStudyAid.Text = "Study Aid";
            this.ckbStudyAid.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(380, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(447, 46);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Personalized TRIO Plan";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(694, 88);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(106, 29);
            this.lblServices.TabIndex = 18;
            this.lblServices.Text = "Services";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(245, 137);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(87, 20);
            this.lblStudentId.TabIndex = 19;
            this.lblStudentId.Text = "Student ID";
            this.lblStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(246, 199);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(246, 259);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(284, 320);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(277, 380);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTutoring
            // 
            this.lblTutoring.AutoSize = true;
            this.lblTutoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutoring.Location = new System.Drawing.Point(645, 134);
            this.lblTutoring.Name = "lblTutoring";
            this.lblTutoring.Size = new System.Drawing.Size(182, 20);
            this.lblTutoring.TabIndex = 25;
            this.lblTutoring.Text = "Tutoring ( Course Name)";
            this.lblTutoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(679, 491);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(135, 60);
            this.lblOther.TabIndex = 26;
            this.lblOther.Text = "Other\r\nWorkshops, TRIO\r\nTalks, Events";
            // 
            // lblStudentIdRequired
            // 
            this.lblStudentIdRequired.AutoSize = true;
            this.lblStudentIdRequired.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentIdRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIdRequired.ForeColor = System.Drawing.Color.Red;
            this.lblStudentIdRequired.Location = new System.Drawing.Point(360, 163);
            this.lblStudentIdRequired.Name = "lblStudentIdRequired";
            this.lblStudentIdRequired.Size = new System.Drawing.Size(136, 17);
            this.lblStudentIdRequired.TabIndex = 27;
            this.lblStudentIdRequired.Text = "Student ID Required";
            // 
            // lblFirstNameRequired
            // 
            this.lblFirstNameRequired.AutoSize = true;
            this.lblFirstNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameRequired.Location = new System.Drawing.Point(360, 225);
            this.lblFirstNameRequired.Name = "lblFirstNameRequired";
            this.lblFirstNameRequired.Size = new System.Drawing.Size(138, 17);
            this.lblFirstNameRequired.TabIndex = 28;
            this.lblFirstNameRequired.Text = "First Name Required";
            // 
            // lblLastNameRequired
            // 
            this.lblLastNameRequired.AutoSize = true;
            this.lblLastNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameRequired.Location = new System.Drawing.Point(360, 285);
            this.lblLastNameRequired.Name = "lblLastNameRequired";
            this.lblLastNameRequired.Size = new System.Drawing.Size(138, 17);
            this.lblLastNameRequired.TabIndex = 29;
            this.lblLastNameRequired.Text = "Last Name Required";
            // 
            // lblEmailRequired
            // 
            this.lblEmailRequired.AutoSize = true;
            this.lblEmailRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRequired.ForeColor = System.Drawing.Color.Red;
            this.lblEmailRequired.Location = new System.Drawing.Point(371, 346);
            this.lblEmailRequired.Name = "lblEmailRequired";
            this.lblEmailRequired.Size = new System.Drawing.Size(104, 17);
            this.lblEmailRequired.TabIndex = 30;
            this.lblEmailRequired.Text = "Email Required";
            // 
            // lblSaveSuccess
            // 
            this.lblSaveSuccess.AutoSize = true;
            this.lblSaveSuccess.Location = new System.Drawing.Point(371, 538);
            this.lblSaveSuccess.Name = "lblSaveSuccess";
            this.lblSaveSuccess.Size = new System.Drawing.Size(76, 13);
            this.lblSaveSuccess.TabIndex = 31;
            this.lblSaveSuccess.Text = "Save Success";
            // 
            // StudentSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 663);
            this.Controls.Add(this.lblSaveSuccess);
            this.Controls.Add(this.lblEmailRequired);
            this.Controls.Add(this.lblLastNameRequired);
            this.Controls.Add(this.lblFirstNameRequired);
            this.Controls.Add(this.lblStudentIdRequired);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblTutoring);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ckbStudyAid);
            this.Controls.Add(this.ckbTrioClub);
            this.Controls.Add(this.ckbAcademicCoaching);
            this.Controls.Add(this.ckbCareerExploration);
            this.Controls.Add(this.ckbRegisterDisability);
            this.Controls.Add(this.ckbFinancialAid);
            this.Controls.Add(this.ckbMentalHealth);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbOther);
            this.Controls.Add(this.txtTutoring);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentSurvey";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTutoring;
        private System.Windows.Forms.RichTextBox txbOther;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox ckbMentalHealth;
        private System.Windows.Forms.CheckBox ckbFinancialAid;
        private System.Windows.Forms.CheckBox ckbRegisterDisability;
        private System.Windows.Forms.CheckBox ckbCareerExploration;
        private System.Windows.Forms.CheckBox ckbAcademicCoaching;
        private System.Windows.Forms.CheckBox ckbTrioClub;
        private System.Windows.Forms.CheckBox ckbStudyAid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTutoring;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblStudentIdRequired;
        private System.Windows.Forms.Label lblFirstNameRequired;
        private System.Windows.Forms.Label lblLastNameRequired;
        private System.Windows.Forms.Label lblEmailRequired;
        private System.Windows.Forms.Label lblSaveSuccess;
    }
}

