Proposals 

Personal Management Scheduler 

Some kind of web store 

Event Management System – Clean Up Australia Day? 

National Park/Environmental Data Management System - SELECTED 

Library Management System 

 

Environmental Monitoring System 

Soil Data Management 

pH Level 

Moisture Level 

Nitrogen Level 

Hydrology Data Management 

Water Level 

Rainfall 

Salinity 

Species Management 

SpeciesName 

Population 

Shared Data (Interface?) 

Location 

DateTime 

 

Functionality 

Add/Remove Record 

Filter by [Data]/[Date]/[Location] (Uses LINQ) 

Visualise Data (Generate Chart) 

 

Frameworks 

WinForms <== Most likely 

ASP.NET <!= Too much web application development to learn, strike out 

WPF <== Possible but need to learn; preferred I think, apparently similar to using WinForms because it was made to be a vastly improved WinForms, has the benefit of looking better too 

 

 

Target System Overview 

The target system will serve as a data collection and compilation system to be used by environmental and conservation staff covering a particular site/area (a section of a national park, a segment of a reef, a point along a river, a single suburb of a city, etc.).  

The system will be a desktop application to be run on a computer kept in an office or lab. The application will store the data on a local database, with the option to package/export stored data to be loaded onto another device running the application.  

The target system is aimed towards monitoring general ecosystem and environmental health. For this, it should be able to handle Soil Quality, Water Quality and Species Population data. In addition, exceptional or abnormal events should be able to be logged for specific reference on the user’s notifications feed. 

The system should also include the ability for the user to schedule or set reminders/events/tasks that will appear when relevant as notifications. 

 

Screens/Stages 

Login: Entry login screen for the application; user must enter a valid username with matching password to enter application. User enters username and password into relevant fields then presses a Log In button. System verifies and validates received username and password with stored username-password pairs on it. Displays a warning if either username or password are invalid. If valid, automatically navigates to Home/Main menu page. 

Home/Main: Landing page for the application after logging in or returning from any other page/screen. Has buttons to navigate to the other job modules of the application. Also has a listed view of notifications and a separate listed view of tasks set; user can click any notification to navigate to a detailed view of the notification or any task to navigate to a detailed view of the task. Also has a Logout button that will take user to Logout Confirmation page.  

Soil Management: Entry job module page for handling soil data. Displays data both in tabular and visual form for all tracked measures for soil data. Has a button to navigate to Add Soil Data page. Also has a Home button to return to Home/Main menu. Also has a Logout button to navigate directly to Logout Confirmation page. 

Water Management: Entry job module page for handling water data. Displays data both in tabular and visual form for all tracked measures for water data. Has a button to navigate to Add Water Data page. Also has a Home button to return to Home/Main menu. Also has a Logout button to navigate directly to Logout Confirmation page. 

Species Management: Entry job module page for handling species data. Displays data both in tabular and visual form for all tracked measures for water data. Has buttons to navigate to Add New Species and Add Species Data pages. Also has a Home button to return to Home/Manu menu. Also has a Logout button to navigate directly to Logout Confirmation page. 

Add Soil Data: Page/screen to add a new record for soil data. User can enter data into applicable fields, which will be entered into the database when the user presses an Add Record button. Pressing Add Record will add data in fields to the database, clear the entry fields and display a message indicating a new record has been added to the database and enabling the user to potentially add another record. Also has a Clear button to clear all fields without adding a new record to the database. User can press a Return button to navigate back to the Soil Data menu. 

Add Water Data: Page/screen to add a new record for water data. User can enter data into applicable fields, which will be entered into the database when the user presses an Add Record button. Pressing Add Record will add data in fields to the database, clear the entry fields and display a message indicating a new record has been added to the database and enabling the user to potentially add another record. Also has a Clear button to clear all fields without adding a new record to the database. User can press a Return button to navigate back to the Soil Data menu. 

Add New Species: Page for the user to add a new species to keep data for in the system. Has a listed view of all species currently in the system (to double check it isn’t already on the system). User enters the name of a new species into a field and presses Add Species to add it to the system, clearing the name field and displaying a message indicating a new species has been added to the database. User can return to the Species Management page by pressing a Return button. 

Add Species Data: Page/screen to add a new record for data for a certain species. User first selects a species from a dropdown menu to add a record for. User can then enter data into applicable fields, which will be entered into the database when the user presses an Add Record button. Pressing Add Record will add data in fields to the database, clear the entry fields and display a message indicating a new record has been added to the database and enabling the user to potentially add another record. Also has a Clear button to clear all fields without adding a new record to the database. User can press a Return button to navigate back to the Soil Data menu. 

Export Data: Page to enable the user to export sets of data from their local database into a portable format. Has a dropdown menu for the user to select which type of data (Soil, Water, Species) to export. Data will be exported out as some comma-separated set of values that can be potentially read by another system. 

View Notification: Displays an expanded/detailed view of a notification. Notifications are reminders or notes that the user may wish to keep on top of (heightened bushfire risk, elevated levels of nitrates in monitored soil, new presence of an invasive species). User can press a Terminate button to stop the notification appearing on the Notification feed anymore. Also has a Logout button to navigate to the Logout Confirmation page if they want to leave after checking a notification. 

View Task: Displays an expanded/detailed view of a task. Tasks are reminders specifically of actions/plans the user should carry out (test for chlorine levels as well this week, test upstream and downstream of the usual monitoring zone, etc.). Tasks are ongoing by default, so the user can press a Terminate button to mark the task as done and terminate it from the Tasks feed. Also has a Logout button to navigate to the Logout Confirmation page if they want to leave after checking a task. 

Set Notification: Page to enable a user to detail and set up a notification to appear on their Notifications feed. Has a dropdown for the user to select either Single (one-off) or Ongoing (continuous). User then fills in the details of the notification and presses a Set Notification button to add a new Notification to the system and display a message indicating as such. Also has a Clear button to clear all fields without adding a Notification to the system. Also has a Home button to return back to the Home/Main menu. 

Set Task: Page to enable a user to detail and set up a task to appear on their Tasks feed. User fills in the details of the task and presses a Set Task button to add a new Task to the system and display a message indicating as such. Also has a Clear button to clear all fields without adding a Task to the system. Also has a Home button to return back to the Home/Main menu. 

User Details: Displays the details of the user/user’s account stored on the system. Password displayed will only show first and last characters and has a Change Password button next to it to navigate to the Change Password page. Also has a Home button to return to the Home/Main menu. Also has a Logout button to navigate to the Logout Confirmation page.  

Change Password: Changes the current user’s login password on the system. Shows the current user’s username and redacted current password. User enters a new password into a New Password field and presses a Change Password button to set their password in the system to their entered new password. When password change has been submitted, the system automatically navigates back to the User Details page. 

Logout Confirmation: Requests the user confirm they wish to log out before actually logging them out. Asks if user are sure they want to log out. User can press the No button to cancel the logout process and return back to the Home/Main menu page. If they press the Yes button, the user is logged out and brought back to the Login page.  

 

Soil Quality Measures 

PH/Acidity 

Moisture/dryness 

Nitrogen/nitrates 

Phosphorus/phosphates 

Sulphur/sulphates 

Water Quality Measures 

pH/Acidity 

Dissolved oxygen 

Turbidity 

Salinity/saltiness 

Hardness (calcium and magnesium levels) 

Eutrophic potential (nitrate and phosphate levels) 

Microbiology 

Additional contaminant presence 

Temperature? 

Species Population Measures 

 

 

 

Architecture (Example Draft?) 

EnvironmentalMonitoringSystem/ 

EnvironmentalMonitoringSystem.sln 

 EMS.Core/ 				(Main Code Logic) 

Models/ 

SoilData.cs 

HydrologyData.cs 

SpeciesData.cs 

Interfaces/ 

IDataManager.cs 

IExportable.cs 

Services/ 

SoilDataManager.cs 

HydrologyDataManager.cs 

SpeciesDataManager.cs 

Utilities/ 

FileHelper.cs 

Extensions.cs 

Enums/ 

SoilType.cs 

WaterQuality.cs 

EMS.UI/ 				(Uses Windows Forms) 

MainForm.cs 

SoilDataForm.cs 

HydrologyForm.cs 

SpeciesForm.cs 

UploadDataForm.cs 