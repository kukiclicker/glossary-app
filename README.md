# Glossary Application
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)      ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
## Overview
The Glossary Application is a C# .NET WinForms desktop application built on the .NET Framework 4.7.2. It provides a user interface for managing a glossary of terms and their definitions. The application is backed by Entity Framework 6.0 for data access, utilizing a SQL database to persist glossary entries.

## Setup
To set up the project, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Ensure that you have the necessary prerequisites installed, including .NET Framework 4.7.2.
4. Install [SQL server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) on your PC, create new instance and run script "GlossaryAppDB.script.sql" from "Database" folder of this project
6. Change connection string inside of an "App.config" file within the application layer
5. Build the solution to restore NuGet packages and compile the application.

## How to Run
To run the Glossary Application:

1. Set the startup project to the WinForms application.
2. Press F5 or use the "Start Debugging" button in Visual Studio.

The application will launch, providing a user interface for managing glossary terms.

## Tests
Automated tests for the Glossary Application are implemented using a unit test framework for .NET. To run the tests:

1. Navigate to the test project in the solution.
2. Run the tests using your preferred unit test runner or through Visual Studio's built-in test explorer.



## Dependencies
The Glossary Application relies on the following dependencies:

- C# .NET Framework 4.7.2
- Entity Framework 6.0 for data access
- Microsoft SQL Server


## Additional Notes
- The application allows users to perform CRUD operations on glossary entries, enabling the addition, editing, and deletion of terms and their definitions.
- Users can search for the definition of a specific term, providing a quick way to access information.
- The application provides information on the total number of defined terms, offering insights into the size of the glossary.


