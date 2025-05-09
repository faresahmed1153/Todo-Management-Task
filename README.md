# TodoManagement.Solution

## Prerequisites & Setup
Ensure SQL Server is installed and running on your machine.

Set TodoManagement.Solution.EntityFrameworkCore as the startup project.

In the Package Manager Console (assuming you're using Visual Studio), set the same project as the default project, and run the following command to apply database migrations:

Update-Database

Set TodoManagement.Solution.HttpApi.Host as the startup project and run it.

Wait a few seconds for the application to start.

Open the index.html file from the associated frontend repository in your browser — the application should now be running correctly.

ℹ️ Note: CORS has already been configured to allow requests from the frontend.




