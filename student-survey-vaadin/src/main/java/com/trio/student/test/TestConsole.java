package com.trio.student.test;

import com.trio.student.dbutil.SurveyController;
import com.trio.student.models.Survey;

public class TestConsole {

	public static void main(String[] args) {
		SurveyController test = new SurveyController();

		Survey s = new Survey(191,"bill","billy","billy@bill.com","888-383-9999","no",true,false,true,false,false,true,true,"other");
		
		Survey s1 = new Survey();
		
		s = test.saveSurvey(s);
		
		
	
		
		System.out.print(s.getId() + " " + s.getFirstName());
		
		
		
		
		
		
			
	}

}
