This application is a C# program that I coded in Visual Studio 2019 for one of my classes. This program makes use of Visual Studio 2019's in-built
MySQL features to host a makeshift database that I can access and adjust through a console application. 

If you are starting this application for the first time, you will need to set up the local database as a connection in your Visual Studio 2019
Server Explorer. Though I can't speak for other IDEs (There's probably ways to do this in Visual Studo Code or Netbeans), setting up the connection in
Visual Studio 2019 is pretty easy. You set up a connection string (which is located in the config.json file), and then enter the following information
when you add a connection into the Server Explorer (Right-click on the Data Connections tab to do this):

Data Source: Microsoft SQL Server (SqlClient)
Server Name: (LocalDB)\MSSQLLocalDB
Select or enter a database name (radial button must be checked): Assignment2DB

-----IMPORTANT FILES-----


//-----Assignment_2.sln-----//

This is the "solution" file for the program that can be used to directly open the project with Microsoft Visual Studio 2019


//-----MarcosMovies.sql-----//

This is the SQL code that will build the database to be accessed in the program. Be sure to follow the SQL connection setup instructions above before
executing the file in Visual Studio 2019.


//-----Screenshots (folder)-----//

These are screenshots that exemplify the program running after everything is set up corerctly. These screenshots were taken by me while testing the
program during the initial assignment submission.


//-----Assignment_2 (folder)-----//

The main program configuration files are contained in this folder.


//-----INSiDE Assignment_2-----//

//-----Program.cs-----//

This file contains all the C# code responsible for the program's functionality.


//-----config.json-----//

This JSON file contains the connection string that is parsed within the C# code.


Thank you, and enjoy!
