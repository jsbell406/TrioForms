package com.trio.student.models;

public class Survey {
	
	//studetId needs to be long
	
	
	private int id;
	private int studentId;
	private String firstName;
	private String lastName;
	private String email;
	private String phone;
	private String tutoring;
	private boolean healthAndWellness;
	private boolean financialAidAndLiteracy;
	private boolean disabilityServices;
	private boolean careerExplorationPlanning;
	private boolean acedemicCoaching;
	private boolean trioClub;
	private boolean studyAid;
	private String other;
	
	public Survey() {super();}
	
	

	public Survey(int studentId, String firstName, String lastName, String email, String phone, String tutoring,
			boolean healthAndWellness, boolean financialAidAndLiteracy, boolean disabilityServices,
			boolean careerExplorationPlanning, boolean acedemicCoaching, boolean trioClub, boolean studyAid,
			String other) {
		super();
		this.studentId = studentId;
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
		this.phone = phone;
		this.tutoring = tutoring;
		this.healthAndWellness = healthAndWellness;
		this.financialAidAndLiteracy = financialAidAndLiteracy;
		this.disabilityServices = disabilityServices;
		this.careerExplorationPlanning = careerExplorationPlanning;
		this.acedemicCoaching = acedemicCoaching;
		this.trioClub = trioClub;
		this.studyAid = studyAid;
		this.other = other;
	}



	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}
	

	public int getStudentId() {
		return studentId;
	}

	public void setStudentId(int studentId) {
		this.studentId = studentId;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getPhone() {
		return phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getTutoring() {
		return tutoring;
	}

	public void setTutoring(String tutoring) {
		this.tutoring = tutoring;
	}

	public boolean isHealthAndWellness() {
		return healthAndWellness;
	}

	public void setHealthAndWellness(boolean healthAndWellness) {
		this.healthAndWellness = healthAndWellness;
	}

	public boolean isFinancialAidAndLiteracy() {
		return financialAidAndLiteracy;
	}

	public void setFinancialAidAndLiteracy(boolean financialAidAndLiteracy) {
		this.financialAidAndLiteracy = financialAidAndLiteracy;
	}

	public boolean isDisabilityServices() {
		return disabilityServices;
	}

	public void setDisabilityServices(boolean disabilityServices) {
		this.disabilityServices = disabilityServices;
	}

	public boolean isCareerExplorationPlanning() {
		return careerExplorationPlanning;
	}

	public void setCareerExplorationPlanning(boolean careerExplorationPlanning) {
		this.careerExplorationPlanning = careerExplorationPlanning;
	}

	public boolean isAcedemicCoaching() {
		return acedemicCoaching;
	}

	public void setAcedemicCoaching(boolean acedemicCoaching) {
		this.acedemicCoaching = acedemicCoaching;
	}

	public boolean isTrioClub() {
		return trioClub;
	}

	public void setTrioClub(boolean trioClub) {
		this.trioClub = trioClub;
	}

	public boolean isStudyAid() {
		return studyAid;
	}

	public void setStudyAid(boolean studyAid) {
		this.studyAid = studyAid;
	}

	public String getOther() {
		return other;
	}

	public void setOther(String other) {
		this.other = other;
	}
}
