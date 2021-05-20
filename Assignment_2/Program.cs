using System;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.IO;

/*
 * In this console program, the user will be able to access the contents of the database with abilities to view,
 * insert, update, and delete entries avaiable via a key input environment. 
 * 
 * REMEMBER TO RUN THE SQL QUERY I HAVE ATTACHED (CALLED MARCOSMOVIES.SQL TO ACEESS MY CUSTOM DATABASE.
 * YOU CAN ALSO SEE MY CONNECTION STRING IN MY 'CONFIG.JSON' FILE.
 * */
namespace Assignment_2
{
    class Program {

        /*
         * This is the main program that launches the database functions when instructed.
         */
        static void Main(string[] args) {

            Console.Write("Welcome to Marco's Assignment 2 Program!" +
                "         \nThis assignment consists of a makeshift movie database for you to use and test!" +
                "         \nThe program utilizes a database where the movies are stored as well as the ability" +
                "         \nfor the user to insert, update, and delete any movies they see fit! " +
                "         \n\n" +
                "         \nTo search and view if a movie is in the database, press 1!" +
                "         \nTo enter a new movie into the database, press 2!" +
                "         \nTo update a pre-existing entry for a movie in the database, press 3!" +
                "         \nTo delete a movie from the database, press 4!" +
                "         \nTo exit the program, press 5!");
            string userInput = Console.ReadLine();

            if (userInput == "1") {
                SearchMovie();  //Search for a movie by name or genre and view contents
            }
            else if (userInput == "2") {
                InsertMovie();  //Insert a new movie into the database
            }
            else if (userInput == "3") {
                UpdateMovie();  //Update an existing movie entry
            }
            else if (userInput == "4") {
                DeleteMovie();  //Delete a movie entry
            }
            else if (userInput == "5") {
                Environment.Exit(0);    //Exit the program
            }
            else {
                throw new Exception("Error: You have not entered a specified value.");  //Should only happen if the values entered are not 1-5
            }
        } //End of Main

        /*
         * This function serves as the access point for my Movies database.
         * This serves as the connection string that must be initialized at the beginning of every method to ensure
         * connectivity with the database.
         */
        static string GetConnectionString(string connectionName) {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder(); //Build string connection
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory()); //Find working directory
            configurationBuilder.AddJsonFile("config.json"); //JSON file where connection string property is located
            IConfiguration config = configurationBuilder.Build();  //Build configuration function once info is found

            return config["ConnectionStrings:"+connectionName]; //Return config via connection parameter present in each connection initialization
        } //End of GetConnectionString()

        /*
         * This method serves as the searching function in which a user must input what they want to search from the database.
         * The user can view the contents in the movie database by typing in a movie and having the database program return the
         * entry for said movie, or by typing in a genre and viewing all entries present for said genre.
         */
        static void SearchMovie() {

            string cs = GetConnectionString("Assignment2DB");   //Initialize connection string

            using (SqlConnection scon = new SqlConnection(cs)) {

                Console.WriteLine("\n\nWith this option, you will be allowed to search a movie from our database" +
                                  " by either name or genre.");
                Console.WriteLine("\nTo search a movie by name, press 1!");
                Console.WriteLine("\nTo search a movie by genre, press 2!");
                string choice = Console.ReadLine(); //User must make a choice

                if (choice == "1") {
                    Console.WriteLine("\n\nType a movie into the field and let's see if we have it!");
                    string inputMovie = Console.ReadLine();
                    string query = "select * from Movies where MovieName like '" + inputMovie + "'";    //SQL query to be used later
                    SqlCommand cmd = new SqlCommand(query, scon); //Create a command shortcut that will use connection and query to form a command that will erturn data to user
                    scon.Open();    //Open connection for use
                    SqlDataReader reader = cmd.ExecuteReader(); //Create reader that will display all entry columns to user

                    Console.WriteLine("\nTable Columns:  Movie - ISBN - Year - Country - Genre - Rating - Duration - Price");
                    //Information will display as long as there are entries in the database that have not been displayed yet
                    while (reader.Read()) {
                        string movieName = (string)reader["MovieName"];
                        decimal isbnNo = (decimal)reader["ISBNNumber"];
                        decimal releaseYear = (decimal)reader["ReleaseYear"];
                        string location = (string)reader["Location"];
                        string genre = (string)reader["Genre"];
                        decimal rating = (decimal)reader["Rating"];
                        decimal duration = (decimal)reader["Duration"];
                        decimal price = (decimal)reader["Price"];

                        
                        Console.WriteLine($"{movieName,-35}  {isbnNo,20}" +
                                          $"{releaseYear,6}  {location,-10}" +
                                          $"{genre,-12}  {rating,3}" +
                                          $"{duration,5}  {price,5}");
                    } //End of while

                    scon.Close();   //Close connection after use

                } //End of if
                else if (choice == "2") {
                    Console.WriteLine("\n\nType in a genre to see all movies listed under that genre.");
                    Console.WriteLine("\nGenres in the database include art, action, comedy, drama, documentary," +
                                      "fantasy, horror, mystery, scifi, and thriller. " +
                                      "\nPlease type entries in all lowercase to avoid confusion.");
                    string inputGenre = Console.ReadLine();
                    string query = "select * from Movies where Genre like '" + inputGenre + "'";    //SQL query to be used later
                    SqlCommand cmd = new SqlCommand(query, scon); //Create a command shortcut that will use connection and query to form a command that will erturn data to user
                    scon.Open();    //Open connection for use
                    SqlDataReader reader = cmd.ExecuteReader(); //Create reader that will display all entry columns to user

                    Console.WriteLine("\nTable Columns:  Movie - ISBN - Year - Country - Genre - Rating - Duration - Price");
                    //Information will display as long as there are entries in the database that have not been displayed yet
                    while (reader.Read()) {
                        string movieName = (string)reader["MovieName"];
                        decimal isbnNo = (decimal)reader["ISBNNumber"];
                        decimal releaseYear = (decimal)reader["ReleaseYear"];
                        string location = (string)reader["Location"];
                        string genre = (string)reader["Genre"];
                        decimal rating = (decimal)reader["Rating"];
                        decimal duration = (decimal)reader["Duration"];
                        decimal price = (decimal)reader["Price"];

                        
                        Console.WriteLine($"{movieName,-35}  {isbnNo,20}" +
                                          $"{releaseYear,6}  {location,-10}" +
                                          $"{genre,-12}  {rating,3}" +
                                          $"{duration,5}  {price,5}");
                    } //End of while

                    scon.Close();    //Close connection after use

                }  //End of else  if       

            }   //End of connection

            /*
             * After each function performed in the program, the user will be given a chance to return to the main menu
             * to perform any additional tasks, or exit the program.
             */
            Console.WriteLine("\n\nAre you ready to go back to the main menu? Press y for yes, or any other key" +
                              " to exit the program.");
            string choice2 = Console.ReadLine();
            if (choice2 == "y") {
                System.Diagnostics.Process.Start("Assignment_2");   //Restart the program
            }
            else {
                Environment.Exit(0);    //Exit the program
            }

        }   //End of SearchMovie()

        /*
         * This method provides a way for the user to enter any new movies into the database. The new movie title, ISBN number,
         * year of release, country of filming/production, genre, rating, duration in minutes, and a made up price for distribution
         * will all be taken via user input. 
         */
        static void InsertMovie() {

            string cs = GetConnectionString("Assignment2DB");   //Initialize connection string

            Console.WriteLine("\n\nFor this option, you are going to create new entries for any movies" +
                              " not in the database that you think should exist!");
            Console.WriteLine("\nEnter the corresponding information indicated by each prompt that shows up.");
            Console.WriteLine("\nThis is a fairly lengthy process, so are you ready to begin?" +
                              " Press y for yes, and any other key to exit back to the main menu.");
            string choice = Console.ReadLine();

            if (choice == "y") {

                using (SqlConnection scon = new SqlConnection(cs)) {

                    Console.WriteLine("\n\nEnter a new movie title. To avoid confusion with the database, " +
                                      "make sure your movie titles are in all uppercase with spacing where appropriate: ");
                        string newMovieName = Console.ReadLine(); //New movie title
                    Console.WriteLine("\nEnter an ISBN number: ");
                        string newisbnNoCast = Console.ReadLine();  
                        decimal newisbnNo = decimal.Parse(newisbnNoCast); //New ISBN number
                    Console.WriteLine("\nEnter the year the movie was released: ");
                        string newReleaseYearCast = Console.ReadLine();
                        decimal newReleaseYear = decimal.Parse(newReleaseYearCast); //New year of release
                    Console.WriteLine("\nEnter the country where the movie was filmed. " +
                        "Make sure the country entry is typed in all uppercase: ");
                        string newLocation = Console.ReadLine(); //New location of filming
                    Console.WriteLine("\nEnter the genre of the movie. Make sure the genre entry is typed in all lowercase: ");
                        string newGenre = Console.ReadLine(); //New genre
                    Console.WriteLine("\nWhat would you rate this movie out of five stars?" +
                                      " Enter a number from 1 through 5: ");
                        string newRatingCast = Console.ReadLine();
                        decimal newRating = decimal.Parse(newRatingCast); //New rating
                    Console.WriteLine("\nEnter the amount of minutes the movie lasts: ");
                        string newDurationCast = Console.ReadLine();
                        decimal newDuration = decimal.Parse(newDurationCast); //New duration
                    Console.WriteLine("\nHow much would you sell this movie for? " +
                                      " The number you enter must contain a decimal value to the nearest tenth." +
                                      " For example, a valid price entry would be '19.99': ");
                        string newPriceCast = Console.ReadLine();
                        decimal newPrice = decimal.Parse(newPriceCast); //New price

                    SqlCommand cmd = scon.CreateCommand(); //Create a command shortcut that will use connection and query to form a command that insert the data into the table
                    cmd.CommandText = "insert into Movies(MovieName, ISBNNumber, ReleaseYear, Location, Genre, Rating, Duration, Price)" +
                        "values(@newMovieName,@newISBNNumber, @newReleaseYear, @newLocation, @newGenre, @newRating, @newDuration, @newPrice)";
                    cmd.Parameters.AddWithValue("@newMovieName", newMovieName);
                    cmd.Parameters.AddWithValue("@newISBNNumber", newisbnNo);
                    cmd.Parameters.AddWithValue("@newReleaseYear", newReleaseYear);
                    cmd.Parameters.AddWithValue("@newLocation", newLocation);
                    cmd.Parameters.AddWithValue("@newGenre", newGenre);
                    cmd.Parameters.AddWithValue("@newRating", newRating);
                    cmd.Parameters.AddWithValue("@newDuration", newDuration);
                    cmd.Parameters.AddWithValue("@newPrice", newPrice);

                    scon.Open();    
                    int success = cmd.ExecuteNonQuery(); //Return a statement to the user to confirm the insert was a success
                    if (success >= 1) {
                        Console.WriteLine("\nCongratulations! The entry has successfully been added.");
                    }
                    else {
                        Console.WriteLine("\nUh oh, it looks like something went wrong. The entry was not added successfully.");
                    }

                    scon.Close();
                    
                }   //End of connection

                Console.WriteLine("\n\nAre you ready to go back to the main menu? Press y for yes, or any other key" +
                              " to exit the program.");
                string choice2 = Console.ReadLine();
                if (choice2 == "y") {
                    System.Diagnostics.Process.Start("Assignment_2");
                }
                else {
                    Environment.Exit(0);
                }

            } //End of if
            else {
                System.Diagnostics.Process.Start("Assignment_2");
            } //End of else
         
        } //End of InsertMovie()

        /*
         * This method will allow the user to update any movie entry in the database. The movie entry for updating
         * is determined via user input, where the typed entry must match the movie name stored in the database. The
         * update method works just like the insert function in which all the fields (minus the name of the designated movie)
         * will be updated via user input
         */
        static void UpdateMovie() {

            string cs = GetConnectionString("Assignment2DB");   //Initialize connection string

            Console.WriteLine("\n\nIn this option, you can search the name of a movie to update the information corresponding" +
                                " to the stored movie entry.");
            Console.WriteLine("\nMake sure the movie is typed in all upper case with spacing as appropriate.");
            Console.WriteLine("\n\nWhen you update an entry, you are changing the information for every field, so it will " +
                              "work just like inserting a new entry into the database.");
            Console.WriteLine("\nThis can be a lengthy process, so we want your confirmation before we continue. " +
                               "Press y to proceed, or press any other button to return back to the main menu.");
            string choice = Console.ReadLine();

            if (choice  == "y") {

                using (SqlConnection scon = new SqlConnection(cs)) {

                    Console.WriteLine("\nEnter the name of the movie of which information you want to edit: ");
                    string updateMovieName = Console.ReadLine();

                    Console.WriteLine("\nEnter an ISBN number: ");
                    string upisbnNoCast = Console.ReadLine(); 
                    decimal upisbnNo = decimal.Parse(upisbnNoCast); //Updated ISBN number
                    Console.WriteLine("\nEnter the year the movie was released: ");
                    string upReleaseYearCast = Console.ReadLine();
                    decimal upReleaseYear = decimal.Parse(upReleaseYearCast); //Updated year of release
                    Console.WriteLine("\nEnter the country where the movie was filmed. " +
                        "Make sure the country entry is typed in all uppercase: ");
                    string upLocation = Console.ReadLine(); //Updated location of filming
                    Console.WriteLine("\nEnter the genre of the movie. Make sure the genre entry is typed in all lowercase: ");
                    string upGenre = Console.ReadLine(); //Updated genre
                    Console.WriteLine("\nWhat would you rate this movie out of five stars?" +
                                      " Enter a number from 1 through 5: ");
                    string upRatingCast = Console.ReadLine();
                    decimal upRating = decimal.Parse(upRatingCast); //Updated rating
                    Console.WriteLine("\nEnter the amount of minutes the movie lasts: ");
                    string upDurationCast = Console.ReadLine();
                    decimal upDuration = decimal.Parse(upDurationCast); //Updated duration
                    Console.WriteLine("\nHow much would you sell this movie for? " +
                                      " The number you enter must contain a decimal value to the nearest tenth." +
                                      " For example, a valid price entry would be '19.99': ");
                    string upPriceCast = Console.ReadLine();
                    decimal upPrice = decimal.Parse(upPriceCast); //Updated price

                    //Create a command shortcut that will use connection and query to form a command that inserts updated data into existing table entry
                    SqlCommand cmd = scon.CreateCommand();
                    cmd.CommandText = ("update Movies set ISBNNumber=@upisbnNo, " +
                                        "ReleaseYear=@upReleaseYear, Location=@upLocation, " +
                                        "Genre=@upGenre, Rating=@upRating, " +
                                        "Duration=@upDuration, Price=@upPrice " +
                                         "where MovieName = '"+updateMovieName+"'");

                    cmd.Parameters.AddWithValue("@upisbnNo", upisbnNo);
                    cmd.Parameters.AddWithValue("@upReleaseYear", upReleaseYear);
                    cmd.Parameters.AddWithValue("@upLocation", upLocation);
                    cmd.Parameters.AddWithValue("@upGenre", upGenre);
                    cmd.Parameters.AddWithValue("@upRating", upRating);
                    cmd.Parameters.AddWithValue("@upDuration", upDuration);
                    cmd.Parameters.AddWithValue("@upPrice", upPrice);
                    scon.Open();

                    int success = cmd.ExecuteNonQuery(); //Return a statement to the user to confirm the update was a success
                    if (success >= 1) {
                        Console.WriteLine("\n\nThe entry has been successfully updated!");
                    } 
                    else {
                        Console.WriteLine("\n\nUh oh, it looks like something went wrong. The entry was not added successfully.");
                    }

                    scon.Close();

                } //End of connection

                Console.WriteLine("\n\nAre you ready to go back to the main menu? Press y for yes, or any other key" +
                              " to exit the program.");
                string choice2 = Console.ReadLine();
                if (choice2 == "y") {
                    System.Diagnostics.Process.Start("Assignment_2");
                }
                else {
                    Environment.Exit(0);
                }
            } //End of if

            else {
                System.Diagnostics.Process.Start("Assignment_2");
            } //End of else

        }   //End of UpdateMovie()

        /*
         * This method allows the user to delete a movie entry by typing a movie name into the search engine.
         * The program will match the movie name to an existing entry and perform an automated query to remove it. 
         */
        static void DeleteMovie() { 

            string cs = GetConnectionString("Assignment2DB");   //Initialize connection string

            using (SqlConnection scon = new SqlConnection(cs)) {

                Console.WriteLine("\n\nIn this option, you can delete a movie by typing in the name " +
                             "of the movie you wish to delete.");
                Console.WriteLine("\nMake sure you type all movie search queries in all uppercase with " +
                                  "spacing where appropriate.");
                Console.WriteLine("\nEnter the name of the movie you wish to delete: ");
                string deleteMovieName = Console.ReadLine();

                //Create a command shortcut that will use connection and query to form a command that will delete an entry from the database
                SqlCommand cmd = scon.CreateCommand();
                string delete_cmd = "delete Movies where MovieName like '"+deleteMovieName+"'";
                cmd.CommandText = delete_cmd;
                scon.Open();

                //Return a statement to the user to confirm the delete was a success
                int success = cmd.ExecuteNonQuery();
                if (success >= 1) {
                    Console.WriteLine("\n\nThe entry has been successfully deleted!");
                }
                else {
                    Console.WriteLine("\n\nUh oh, it looks like something went wrong. The entry was not deleted successfully.");
                }

                scon.Close();

            } //End of connection

            Console.WriteLine("\n\nAre you ready to go back to the main menu? Press y for yes, or any other key" +
                              " to exit the program.");
            string choice2 = Console.ReadLine();
            if (choice2 == "y") {
                System.Diagnostics.Process.Start("Assignment_2");
            }
            else {
                Environment.Exit(0);
            }

        } //End of DeleteMovie()

    } 
}
