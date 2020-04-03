using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrioAdminSurvey.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public long StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Tutoring { get; set; }
        public bool MentalHealth { get; set; }
        public bool FinancialAid { get; set; }
        public bool DisabilityServices { get; set; }
        public bool CareerPlanning { get; set; }
        public bool AcademicCoaching { get; set; }
        public bool TrioClub { get; set; }
        public bool StudyAid { get; set; }
        public string Other { get; set; }

        public bool IsProcessed { get; set; }

        public Survey()
        {
        }

        public Survey(int surveyId, long studentId, string firstName, string lastName, string email, string phone, string tutoring, bool mentalHealth, bool financialAid, bool disabilityServices, bool careerPlanning, bool academicCoaching, bool trioClub, bool studyAid, string other, bool isProcessed)
        {
            SurveyId = surveyId;
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Tutoring = tutoring;
            MentalHealth = mentalHealth;
            FinancialAid = financialAid;
            DisabilityServices = disabilityServices;
            CareerPlanning = careerPlanning;
            AcademicCoaching = academicCoaching;
            TrioClub = trioClub;
            StudyAid = studyAid;
            Other = other;
            IsProcessed = isProcessed;
        }
    }
}
