package com.trio.student.dbutil;



import java.sql.ResultSet;
import java.sql.SQLException;

import com.mysql.jdbc.Connection;
import com.mysql.jdbc.PreparedStatement;
import com.mysql.jdbc.Statement;
import com.mysql.jdbc.jdbc2.optional.MysqlDataSource;
import com.trio.student.models.Survey;

public class SurveyController {

	private MysqlDataSource dataSource;
	private Connection connection;
	
	public SurveyController() {
		dataSource = new MysqlDataSource();
		dataSource.setUser("triostudentuser");
		dataSource.setPassword("triostudentpassword");
		dataSource.setDatabaseName("triodata");
		dataSource.setPort(3306);
		dataSource.setServerName("localhost");		
	}
	
	public Survey testStatement() {
		Survey survey = new Survey();
		
		try {
			connection = (Connection) dataSource.getConnection();
			Statement stmt = (Statement) connection.createStatement();
			try(ResultSet rs = stmt.executeQuery("SELECT * FROM SURVEY")){
				if(rs.next()) {
					survey.setId(rs.getInt("id"));
					survey.setFirstName(rs.getString("firstName"));
				}
			}			
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
				
		return survey;
	}
	
	public Survey saveSurvey(Survey survey)
	{
		PreparedStatement statement = null;
		ResultSet results = null;
		try {
			connection = (Connection) dataSource.getConnection();
			String query = "INSERT INTO survey (id, studentId, firstName, lastName, email, phone, tutoring, healthAndWellness, financialAidAndLiteracy, disabilityServices, careerExplorationPlanning, acedemicCoaching, trioClub, studyAid, other) values(NULL,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
			statement = (PreparedStatement) connection.prepareStatement(query, Statement.RETURN_GENERATED_KEYS);
			
			statement.setInt(1, survey.getStudentId());			
			statement.setString(2, survey.getFirstName());
			statement.setString(3, survey.getLastName());
			statement.setString(4, survey.getEmail());
			statement.setString(5, survey.getPhone());
			statement.setString(6, survey.getTutoring());
			statement.setInt(7, booleanToIntParser(survey.isHealthAndWellness()));
			statement.setInt(8, booleanToIntParser(survey.isFinancialAidAndLiteracy()));
			statement.setInt(9, booleanToIntParser(survey.isDisabilityServices()));
			statement.setInt(10, booleanToIntParser(survey.isCareerExplorationPlanning()));
			statement.setInt(11, booleanToIntParser(survey.isAcedemicCoaching()));
			statement.setInt(12, booleanToIntParser(survey.isTrioClub()));
			statement.setInt(13, booleanToIntParser(survey.isStudyAid()));
			statement.setString(14, survey.getOther());;
			
			int rows = statement.executeUpdate();
			
			results = statement.getGeneratedKeys();
			if(results != null && results.next())
				survey.setId(results.getInt(1));
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		catch(Exception e )
		{
			e.printStackTrace();
		}
		finally
		{
			// close stuff
			try {
				results.close();
				statement.close();
				connection.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}			
		}
		
		return survey;
	}
	
	private int booleanToIntParser(boolean b)
	{
		if(b)
			return 1;
		else
			return 0;
	}
 }
	

