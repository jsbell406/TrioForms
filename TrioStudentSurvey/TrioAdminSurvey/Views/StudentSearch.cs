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

namespace TrioAdminSurvey.Views
{
    public partial class StudentSearch : Form
    {
        private SurveyController controller;
        private bool isBusy = false;
        public StudentSearch()
        {
            InitializeComponent();
            controller = new SurveyController();
           

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isBusy)
                return;

            isBusy = true;


            bool academic = rdbAcademic.Checked;
            bool career = rdbCareer.Checked;
            bool disability = rdbDisability.Checked;
            bool financial = rdbFinancialAid.Checked;
            bool mental = rdbMentalHealth.Checked;
            bool study = rdbStudy.Checked;
            bool club = rdbTrioClub.Checked;

            string searchBy = "";

            if(academic)
            {
                searchBy = "AcademicCoaching";
            }
            else if(career)
            {
                searchBy = "CareerExplorationPlanning";
            }
            else if(disability)
            {
                searchBy = "DisabilityServices";
            }
            else if(financial)
            {
                searchBy = "FinancialAidAndLiteracy";
            }
            else if(mental)
            {
                searchBy = "HealthAndWellness";
            }
            else if(study)
            {
                searchBy = "StudyAid";
            }
            else if (club)
            {
                searchBy = "TrioClub";
            }
            else
            {
                return;
            }
            lstStudents.Items.Clear();

            List<Survey> surveysToProcess = controller.GetSurveysToProcess(searchBy);
            foreach (var survey in surveysToProcess)
            {
                var row = new string[] { survey.StudentId.ToString(), survey.FirstName, survey.LastName, survey.Email, survey.Phone };

                var lvi = new ListViewItem(row);
                lvi.Tag = survey;


                lstStudents.Items.Add(lvi);


            }
            isBusy = false;

        }

        private void lstStudents_ItemActivate(object sender, EventArgs e)
        {

            
            Survey s = lstStudents.SelectedItems[0].Tag as Survey;

            //MessageBox.Show("Item Activate " + s.FirstName + " " + s.LastName);

            StudentDetail f = new StudentDetail(s, this);
            f.Show();
            f.Focus();
            this.Hide();
          
        }
    }
}
