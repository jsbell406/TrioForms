package com.trio.student.survey;


import com.vaadin.flow.component.applayout.AppLayout;
import com.vaadin.flow.component.applayout.DrawerToggle;
import com.vaadin.flow.component.orderedlayout.VerticalLayout;
import com.vaadin.flow.router.Route;
import com.vaadin.flow.router.RouterLink;

@Route("")
public class MainAppLayout extends AppLayout {

	/**
	 * 
	 */
	private static final long serialVersionUID = -1049438444261180135L;

	public MainAppLayout() {
		super();
		
		addToNavbar(new DrawerToggle());
		
		VerticalLayout vlDrawer = new VerticalLayout();
		vlDrawer.add(new RouterLink("Trio Survey", SurveyView.class));
	
		
		addToDrawer(vlDrawer);
	}
	
}
