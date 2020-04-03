using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrioStudentSurvey.Controllers;
using TrioStudentSurvey.Models;
using TrioStudentSurvey.Utility;

namespace TrioStudentSurvey
{
    public partial class StudentSurvey : Form
    {
        private Survey Survey;
        private SurveyController Controller;

        private bool isBusy = false;
        public StudentSurvey()
        {
            InitializeComponent();

            HideRequired();

            Survey = new Survey();
            Controller = new SurveyController();

            lblSaveSuccess.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isContinue = true;

            if(isBusy)
                return;
            
            isBusy = true;

            // Student ID validation
            if (!StudentIdHandling())           
                isContinue = false;
            
            // First Name Validation
            if(!FirstNameHandling())           
                isContinue = false;
                      
            // Last Name Validation
            if(!LastNameHandling())            
                isContinue = false;

            // Email Validation
            if (!EmailHandling())
                isContinue = false;
            
            if(!isContinue)
            {
                isBusy = false;
                return;
            }

            Survey.Phone = txtPhone.Text.Trim();

            Survey.Tutoring = txtTutoring.Text.Trim();

            Survey.MentalHealth = ckbMentalHealth.Checked;
            Survey.FinancialAid = ckbFinancialAid.Checked;
            Survey.AcademicCoaching = ckbAcademicCoaching.Checked;
            Survey.CareerPlanning = ckbCareerExploration.Checked;
            Survey.DisabilityServices = ckbRegisterDisability.Checked;
            Survey.TrioClub = ckbTrioClub.Checked;
            Survey.StudyAid = ckbStudyAid.Checked;

            Survey.Other = txbOther.Text.Trim();
            Survey.IsProcessed = false;

            Survey.SurveyId = 0;

            Survey = Controller.SaveSurvey(Survey);

            if (Survey.SurveyId > 0)
            {
                lblSaveSuccess.Visible = true;
                lblSaveSuccess.Text = WarningMessages.CONFIRMATION_SAVE_SUCCESS;
            }
            else
            {
                lblSaveSuccess.Visible = true;
                lblSaveSuccess.Text = WarningMessages.CONFIRMATION_SAVE_FAILURE;
            }

            ResetForm();

            isBusy = false;
        }

        private bool EmailHandling()
        {
            bool isValid = true;

            string email = txtEmail.Text.Trim();
            if(email.Length == 0)
            {
                lblEmailRequired.Text = WarningMessages.WARNING_EMAIL_REQUIRED;
                lblEmailRequired.Visible = true;
                txtEmail.Clear();
                return false;
            }
            else
            {
                lblEmailRequired.Visible = false;
            }

            // add custom email validation here.


            Survey.Email = email;

            return isValid;

        }

        private bool LastNameHandling()
        {
            bool isValid = true;

            string lName = txtLastName.Text.Trim();
            if (lName.Length == 0)
            {
                lblLastNameRequired.Text = WarningMessages.WARNING_LASTNAME_REQUIRED;
                lblLastNameRequired.Visible = true;
                txtLastName.Clear();
                return false;
            }
            else
            {
                lblLastNameRequired.Visible = false;
                Survey.LastName = lName;
            }
            return isValid;
        }
        private bool FirstNameHandling()
        {
            bool isValid = true;

            string fName = txtFirstName.Text.Trim();

            if(fName.Length == 0)
            {
                lblFirstNameRequired.Text = WarningMessages.WARNING_FIRSTNAME_REQUIRED;
                lblFirstNameRequired.Visible = true;
                txtFirstName.Clear();
                return false;
            }
            else
            {
                lblFirstNameRequired.Visible = false;
                Survey.FirstName = fName;
            }
            return isValid;
        }
        private bool StudentIdHandling()
        {
            bool isValid = true;
            string studentId = txtStudentId.Text.Trim();

            if (studentId.Length == 0)
            {
                lblStudentIdRequired.Text = WarningMessages.WARNING_STUDENTID_REQUIRED;
                lblStudentIdRequired.Visible = true;
                txtStudentId.Clear();
                return false;
            }

            if (long.TryParse(txtStudentId.Text, out long studId))
            {
                Survey.StudentId = studId;
                lblStudentIdRequired.Visible = false;
            }
            else
            {
                lblStudentIdRequired.Text = WarningMessages.WARNING_NUMBERSONLY;
                lblStudentIdRequired.Visible = true;
                txtStudentId.Clear();
                
                return false;
            }
            return isValid;
        }
      
        private void btnClear_Click(object sender, EventArgs e)
        {
            HideRequired();
            ResetForm();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (email.Length > 0)
                lblEmailRequired.Visible = false;
        }

        private void HideRequired()
        {
            lblStudentIdRequired.Visible = false;
            lblFirstNameRequired.Visible = false;
            lblLastNameRequired.Visible = false;
            lblEmailRequired.Visible = false;

            lblSaveSuccess.Visible = false;
        }

        private void ResetForm()
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtTutoring.Clear();
            ckbMentalHealth.Checked = false;
            ckbFinancialAid.Checked = false;
            ckbRegisterDisability.Checked = false;
            ckbCareerExploration.Checked = false;
            ckbAcademicCoaching.Checked = false;
            ckbTrioClub.Checked = false;
            ckbStudyAid.Checked = false;
            txbOther.Clear();

            Survey = new Survey();
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            // validation light
            if(txtStudentId.Text.Trim().Length > 0 )
            {
                if (!long.TryParse(txtStudentId.Text, out long studId))
                {
                    lblStudentIdRequired.Text = WarningMessages.WARNING_NUMBERSONLY;
                    lblStudentIdRequired.Visible = true;
                }
                else
                {
                    lblStudentIdRequired.Visible = false;
                }
            }
          
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string fName = txtFirstName.Text.Trim();

            if (fName.Length > 0)
                lblFirstNameRequired.Visible = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string lName = txtLastName.Text.Trim();

            if (lName.Length > 0)
                lblLastNameRequired.Visible = false;
        }    
    }
}
