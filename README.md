## Overview
    This is a console-based Employee Management System built with C# and Entity Framework Core. 
    It allows users to manage employees, departments, and projects through a menu-driven interface.
    Users can add, display, edit, and delete records, as well as assign employees to departments and projects. 
    The application uses a SQLite database and follows a service-based architecture for modularity.  

## Features:
  - Add: Create new employees, departments, and projects.
  - Display: View lists of employees, departments, and projects with their relationships ( employees in a department, projects assigned to employees).
  - Edit: Update employee details, department names, project names, assign employees to departments or projects, and remove employees from projects.
  - Delete: Remove employees, departments, and projects (with checks to prevent deletion of departments/projects with assigned employees).
  - Interactive Menu: Navigate the main menu using UpArrow, DownArrow, and Enter keys, with highlighted selections.

## Project Structure:
   1- ** Models:**
       - Employee.cs: Represents an employee with properties like Id, FullName, DepartmentId, and navigation properties for Department and EmployeeProjects
       - Department.cs: Represents a department with Id, Name, and a collection of Employees.
       - Projects.cs: Represents a project with Id, Name, and a collection of EmployeeProjects.
       - EmployeeProject.cs: Junction table for the many-to-many relationship between Employee and Projects.
       - AppDBContext.cs: Entity Framework Core DbContext for SQLite database configuration and model relationships.
   2- ** Services:**
       - AddService.cs: Handles adding new employees, departments, and projects.
       - DisplayService.cs: Displays lists of employees, departments, and projects with their relationships.
       - EditService.cs: Manages updating records and assigning/removing employees to/from departments and projects.
       - DeleteService.cs: Handles deletion of employees, departments, and projects with validation checks.
   3-  ** Program.cs:**
         Main entry point with an interactive console menu for navigating Add, Display, Edit, Delete, and Exit options.


 ## Prerequisites: 
  - .NET SDK: Version 6.0 or later.
  - Entity Framework Core: Install the required EF Core packages (see setup instructions).
  - SQLite: The application uses a SQLite database (app.db).





         
      
