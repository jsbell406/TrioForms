using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrioStudentSurvey.Models;
using System.Data;

namespace TrioStudentSurvey.Controllers
{
    public class SurveyController
    {
        private static string connString = "SurveyConnection";
       
        public List<Survey> GetSurveysToProcess(string searchBy)
        {
            List<Survey> surveys = new List<Survey>();

            SqlCommand read;
            SqlDataReader reader;
            string sql;
            SqlConnection connection = null;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[connString].ConnectionString;
                connection = new SqlConnection(connectionString);
                //sql = "SELECT * FROM Survey where @searchBy = 1";
                sql = "SELECT * FROM Survey where " + searchBy + " = 1 AND IsProcessed = 0";


                connection.Open();

                read = new SqlCommand(sql, connection);

                //SqlParameter searchByParam = new SqlParameter("@searchBy", searchBy);
           

                //read.Parameters.Add(searchByParam);

                reader = read.ExecuteReader();

                while (reader.Read())
                {
                    surveys.Add(new Survey(Convert.ToInt32(reader[0].ToString()), long.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), bool.Parse(reader[7].ToString()), bool.Parse(reader[8].ToString()), bool.Parse(reader[9].ToString()), bool.Parse(reader[10].ToString()), bool.Parse(reader[11].ToString()), bool.Parse(reader[12].ToString()), bool.Parse(reader[13].ToString()), reader[14].ToString(), bool.Parse(reader[15].ToString())));
                }

            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return surveys;
        }

        public Survey SaveSurvey(Survey survey)
        {
            SqlCommand insert;
            string sql;
            SqlConnection connection = null;


            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings[connString].ConnectionString;
                connection = new SqlConnection(connectionString);

                sql = "INSERT INTO Survey(StudentId, FirstName, LastName, Email, Phone, Tutoring, HealthAndWellness, FinancialAidAndLiteracy, DisabilityServices, CareerExplorationPlanning, AcademicCoaching, TrioClub, StudyAid, Other, IsProcessed)" +
                      " VALUES (@studentId, @firstName, @lastName, @email, @phone, @tutoring, @healthAndWellness, @financialAidAndLiteracy, @disabilityServices, @careerExplorationPlanning, @academicCoaching, @trioClub, @studyAid, @other, @isProcessed);" +
                      " SELECT CAST(SCOPE_IDENTITY() AS INT);";

                insert = new SqlCommand(sql, connection);
                connection.Open();

                SqlParameter studentId = new SqlParameter("@studentId", survey.StudentId);
                studentId.SqlDbType = SqlDbType.Int;
                insert.Parameters.Add(studentId);

                SqlParameter firstName = new SqlParameter("@firstName", survey.FirstName);
                firstName.SqlDbType = SqlDbType.VarChar;
                insert.Parameters.Add(firstName);

                SqlParameter lastName = new SqlParameter("@lastName", survey.LastName);
                lastName.SqlDbType = SqlDbType.VarChar;
                insert.Parameters.Add(lastName);

                SqlParameter email = new SqlParameter("@email", survey.Email);
                email.SqlDbType = SqlDbType.VarChar;
                insert.Parameters.Add(email);


                SqlParameter phone; 
                if (survey.Phone.Length == 0)
                {
                    phone = new SqlParameter("@phone", null);
                    phone.Value = DBNull.Value;
                }
                else
                {
                    phone = new SqlParameter("@phone", survey.Phone);
                    phone.SqlDbType = SqlDbType.VarChar;
                }
                insert.Parameters.Add(phone);


                SqlParameter tutoring;
                if(survey.Tutoring.Length == 0)
                {
                    tutoring = new SqlParameter("@tutoring", null);
                    tutoring.Value = DBNull.Value;
                }
                else
                {
                    tutoring = new SqlParameter("@tutoring", survey.Tutoring);
                    tutoring.SqlDbType = SqlDbType.VarChar;
                }
                insert.Parameters.Add(tutoring);

                SqlParameter healthAndWellness = new SqlParameter("@healthAndWellness", survey.MentalHealth);
                healthAndWellness.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(healthAndWellness);

                SqlParameter financialAidAndLiteracy = new SqlParameter("@financialAidAndLiteracy", survey.FinancialAid);
                financialAidAndLiteracy.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(financialAidAndLiteracy);

                SqlParameter disabilityServices = new SqlParameter("@disabilityServices", survey.DisabilityServices);
                disabilityServices.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(disabilityServices);

                SqlParameter careerExplorationPlanning = new SqlParameter("@careerExplorationPlanning", survey.CareerPlanning);
                careerExplorationPlanning.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(careerExplorationPlanning);

                SqlParameter academicCoaching = new SqlParameter("@academicCoaching", survey.AcademicCoaching);
                academicCoaching.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(academicCoaching);

                SqlParameter trioClub = new SqlParameter("@trioClub", survey.TrioClub);
                trioClub.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(trioClub);

                SqlParameter studyAid = new SqlParameter("@studyAid", survey.StudyAid);
                studyAid.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(studyAid);

                SqlParameter other;
                if(survey.Other.Length == 0)
                {
                    other = new SqlParameter("@other", null);
                    other.Value = DBNull.Value;
                }
                else
                {
                    other = new SqlParameter("@other", survey.Other);
                    other.SqlDbType = SqlDbType.VarChar;
                }
                insert.Parameters.Add(other);

                SqlParameter isProcessed = new SqlParameter("@isProcessed", survey.IsProcessed);
                isProcessed.SqlDbType = SqlDbType.Bit;
                insert.Parameters.Add(isProcessed);

                survey.SurveyId = (int)insert.ExecuteScalar();

            }
            catch(SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return survey;
        }
    }
}
