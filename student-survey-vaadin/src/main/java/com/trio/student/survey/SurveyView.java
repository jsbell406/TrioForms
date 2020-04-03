package com.trio.student.survey;

import com.trio.student.dbutil.SurveyController;
import com.trio.student.models.Survey;
import com.vaadin.flow.component.UI;
import com.vaadin.flow.component.button.Button;
import com.vaadin.flow.component.checkbox.Checkbox;
import com.vaadin.flow.component.dialog.Dialog;
import com.vaadin.flow.component.formlayout.FormLayout;
import com.vaadin.flow.component.html.Label;
import com.vaadin.flow.component.orderedlayout.HorizontalLayout;
import com.vaadin.flow.component.orderedlayout.VerticalLayout;
import com.vaadin.flow.component.page.Page;
import com.vaadin.flow.component.splitlayout.SplitLayout;
import com.vaadin.flow.component.textfield.EmailField;
import com.vaadin.flow.component.textfield.TextArea;
import com.vaadin.flow.component.textfield.TextField;
import com.vaadin.flow.data.value.ValueChangeMode;
import com.vaadin.flow.router.Route;

@Route(value = "SurveyView", layout = MainAppLayout.class)
public class SurveyView extends VerticalLayout {
	/**
	 * 
	 */
	private static final long serialVersionUID = -1690013542898220398L;

	// form controller
	private SurveyController controller;
	
	// layouts
	private VerticalLayout mainLayout;
	private SplitLayout splitLayout;
	private VerticalLayout layoutPrimary;
	private VerticalLayout layoutSecondary;
	private VerticalLayout title;
	private VerticalLayout secondaryTitle; 
	private HorizontalLayout buttonBar;

	// form fields
	private TextField studentId;
	private TextField firstName;
	private TextField lastName;
	private EmailField email;
	private TextField phone;
	private TextField tutoring;
	private Checkbox healthAndWellness;
	private Checkbox financialAidAssistance;
	private Checkbox disabilityServices;
	private Checkbox careerExploration;
	private Checkbox acedemicCoaching;
	private Checkbox trioClub;
	private Checkbox studyAid;
	private TextArea other;
	
	// form controls
	private Button saveButton;
	private Button clearButton;
	
	// form other
	private Label otherLabel;
		
	public SurveyView()
	{
		super();
		buildForm();	
	}
	
	private void buildForm()
	{
		controller = new SurveyController();
		
		
		splitLayout = new SplitLayout();
		
		layoutPrimary = new VerticalLayout();
		layoutSecondary = new VerticalLayout();
					
		
		studentId = new TextField();
		studentId.setValueChangeMode(ValueChangeMode.EAGER);
		studentId.setClearButtonVisible(true);
		studentId.setLabel("Student ID");
		studentId.setErrorMessage("Student ID is required");
		studentId.setRequired(true);
		
		firstName = new TextField();
		firstName.setValueChangeMode(ValueChangeMode.EAGER);
		firstName.setClearButtonVisible(true);
		firstName.setLabel("First Name");
		firstName.setErrorMessage("First Name is required");
		firstName.setRequired(true);
		
		lastName = new TextField();
		lastName.setValueChangeMode(ValueChangeMode.EAGER);
		lastName.setClearButtonVisible(true);
		lastName.setLabel("Last Name");
		lastName.setErrorMessage("Last Name is required");
		lastName.setRequired(true);
		
		email = new EmailField();
		email.setValueChangeMode(ValueChangeMode.EAGER);
		email.setClearButtonVisible(true);
		email.setErrorMessage("Please enter a valid email address");
		email.setLabel("Email");
		email.setRequiredIndicatorVisible(true);
		
		phone = new TextField();
		phone.setValueChangeMode(ValueChangeMode.EAGER);
		phone.setClearButtonVisible(true);
		phone.setLabel("Phone");
		
		tutoring = new TextField();
		tutoring.setValueChangeMode(ValueChangeMode.EAGER);
		tutoring.setLabel("Tutoring (Course Name)");
		
		healthAndWellness = new Checkbox();
		healthAndWellness.setLabel("Mental Health and Wellness Workshops & Activities");
		
		financialAidAssistance = new Checkbox();
		financialAidAssistance.setLabel("Financial Aid Assistance and Literacy (FAFSA, Scholarship)");
		
		disabilityServices = new Checkbox();
		disabilityServices.setLabel("Register with Disability Services");
		
		careerExploration = new Checkbox();
		careerExploration.setLabel("Career Exploration Planning (MCIS, LinkedIn, Resume)");
		
		acedemicCoaching = new Checkbox();
		acedemicCoaching.setLabel("Academic Coaching");
		
		trioClub = new Checkbox();
		trioClub.setLabel("TRIO S2S Club");
		
		studyAid = new Checkbox();
		studyAid.setLabel("Study Aid");
		
		other = new TextArea();
		other.setPlaceholder("Other Workshops, TRIO Talks, Events");
		
		title = new VerticalLayout();
		title.add("Personalized TRIO Plan");
		layoutPrimary.add(title);
		
		layoutPrimary.add(studentId);
		layoutPrimary.add(firstName);
		layoutPrimary.add(lastName);
		layoutPrimary.add(email);
		layoutPrimary.add(phone);
		
		secondaryTitle = new VerticalLayout();
		secondaryTitle.add("Services");
		layoutSecondary.add(secondaryTitle);
		
		layoutSecondary.add(tutoring,healthAndWellness,financialAidAssistance,disabilityServices,careerExploration,acedemicCoaching,trioClub,studyAid);
		
		otherLabel = new Label();
		otherLabel.add("Other Workshops, TRIO Talks, Events");
		
		
		layoutSecondary.add(otherLabel);
		layoutSecondary.add(other);
		
		splitLayout.addToPrimary(layoutPrimary);
		splitLayout.addToSecondary(layoutSecondary);
	
		buttonBar = new HorizontalLayout();
		
		saveButton = new Button("Save");
		saveButton.addClickListener(b -> saveButtonPressed());
				
		clearButton = new Button("Clear");
		clearButton.addClickListener(b -> clearButtonPressed());
		
		buttonBar.add(saveButton,clearButton);
				
		mainLayout = new VerticalLayout();
		mainLayout.addAndExpand(splitLayout);
		mainLayout.addAndExpand(buttonBar);
		
		
		add(mainLayout);
	}
	
	private void saveButtonPressed() {
			
		// validate form
		if(isFormValid())
		{
			// collect form
			Survey survey = new Survey();
			survey.setStudentId(Integer.parseInt(studentId.getValue().trim()));
			survey.setFirstName(firstName.getValue().trim());
			survey.setLastName(lastName.getValue().trim());
			survey.setEmail(email.getValue().trim());
			survey.setPhone(phone.getValue().trim());
			survey.setTutoring(tutoring.getValue().trim());
			survey.setHealthAndWellness(healthAndWellness.getValue());
			survey.setFinancialAidAndLiteracy(financialAidAssistance.getValue());
			survey.setDisabilityServices(disabilityServices.getValue());
			survey.setCareerExplorationPlanning(careerExploration.getValue());
			survey.setAcedemicCoaching(acedemicCoaching.getValue());
			survey.setTrioClub(trioClub.getValue());
			survey.setStudyAid(studyAid.getValue());
			survey.setOther(other.getValue().trim());
			
	
			// save survey
			survey = controller.saveSurvey(survey);
					
			
			// verify save
			if(survey.getId() > 0) {
				Dialog success = new Dialog();
				success.add("Success");
				
				success.open();
				success.addDialogCloseActionListener( a -> {
					success.close();
					clearForm();
				});
			}
			else
			{
				Dialog invalidForm = new Dialog();
				invalidForm.add("Something went wrong please try again");
				invalidForm.open();
				invalidForm.addDialogCloseActionListener(a -> {
					invalidForm.close();
					clearForm();
				});
			}
		}
		else {
			// form not valid
			
			// popup
			Dialog invalidForm = new Dialog();
			invalidForm.add("Something went wrong please try again");
			invalidForm.open();
			invalidForm.addDialogCloseActionListener(a -> {
				invalidForm.close();
				clearForm();
			});
		}
	}
	
	private boolean isFormValid() {
		boolean isValid = true;
		
		if(studentId.getValue().trim().length() == 0)
			return false;
		if(firstName.getValue().trim().length() == 0)
			return false;
		if(lastName.getValue().trim().length() == 0)
			return false;
		if(email.isInvalid())
			return false;
		return isValid;
	}
	
	private void clearForm() {	
		UI.getCurrent().getPage().reload();
	}
	private void clearButtonPressed() {	
		clearForm();	
	}
}
