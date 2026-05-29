# Game Backlog Tracker

A simple ASP.NET Core MVC web application for tracking your gaming backlog!

This project was created as an educational introduction to web development with ASP.NET Core MVC.

---

## What is MVC?

**MVC** stands for **Model-View-Controller**. It is a design pattern that helps organize web applications into three main parts:

### Model (The Data)
- **What it is:** Models are classes that represent your data
- **Example:** The `Game.cs` class represents a single game with properties like Title, Platform, Genre, etc.
- **Think of it as:** The thing you are working with (like a game, a user, a product, etc.)
- **Location:** `Models/Game.cs`

### Controller (The Traffic Director)
- **What it is:** Controllers handle requests from users and decide what to do
- **Example:** The `GameController.cs` has methods like `Index()`, `Create()`, `Edit()`, `Delete()`
- **Think of it as:** The brain that decides what happens when you click a button or visit a page
- **Location:** `Controllers/GameController.cs`

### View (The Display)
- **What it is:** Views are the HTML pages that users see and interact with
- **Example:** `Index.cshtml` shows the list of games, `Create.cshtml` shows the form to add a game
- **Think of it as:** The face of your application that users interact with
- **Location:** `Views/Game/Index.cshtml`, `Views/Game/Create.cshtml`, etc.

---

## How Data Flows in This App

Here is what happens when you add a new game:

1. **User visits** `/Game/Create` - Browser sends a GET request
2. **Controller** (`GameController.Create()` GET method) - Returns the empty form
3. **View** (`Create.cshtml`) - Displays the form to the user
4. **User fills in** the form and clicks Save - Browser sends a POST request with the form data
5. **Controller** (`GameController.Create()` POST method) - Receives the data
6. **Service** (`GameService.AddGame()`) - Saves the game to the in-memory list
7. **Controller** redirects to `/Game/Index`
8. **Controller** (`GameController.Index()`) - Gets all games from the service
9. **View** (`Index.cshtml`) - Displays the updated list including the new game

---

## How to Run the Application

### Option 1: Using Visual Studio
1. Open `GameTracker.sln` in Visual Studio
2. Press **F5** or click the **Run** button
3. Your browser will open automatically showing the app

### Option 2: Using the Command Line
1. Open a terminal/command prompt
2. Navigate to the `GameTracker` folder
3. Run: `dotnet run`
4. Open your browser and go to: `https://localhost:5001` (or the URL shown in the terminal)

---

## Project Structure

```
GameTracker/
??? Controllers/
?   ??? GameController.cs       <- Handles all game-related requests
?   ??? HomeController.cs       <- Handles home page
??? Models/
?   ??? Game.cs                 <- Represents a single game
?   ??? ErrorViewModel.cs       <- For error pages
??? Services/
?   ??? GameService.cs          <- Manages game data (in-memory storage)
??? Views/
?   ??? Game/
?   ?   ??? Index.cshtml        <- Shows list of all games
?   ?   ??? Create.cshtml       <- Form to add a new game
?   ?   ??? Edit.cshtml         <- Form to edit a game
?   ?   ??? Delete.cshtml       <- Confirmation before deleting
?   ??? Home/
?   ?   ??? Index.cshtml        <- Home page
?   ?   ??? Privacy.cshtml      <- Privacy page
?   ??? Shared/
?       ??? _Layout.cshtml      <- Main layout template (header, footer, navigation)
?       ??? Error.cshtml        <- Error page
??? Program.cs                  <- Application startup and configuration
```

---

## Features You Can Try

- **View all games** - See your complete backlog
- **Add a game** - Add new games you want to play
- **Edit a game** - Update game details
- **Delete a game** - Remove games from your backlog
- **Mark as completed** - Track which games you have finished
- **View statistics** - See total, completed, and remaining games

---

## Beginner-Friendly Tasks to Try

Here are some ideas for features you could add to practice your skills:

### Easy Tasks (Great for starting!)

1. **Add a Rating System**
   - Add a `Rating` property to the `Game` model (1-5 stars)
   - Update the views to show and edit ratings
   - Display ratings with star icons

2. **Sort the Game List**
   - Add buttons to sort by Title, Platform, or Date Added
   - Hint: Use LINQ's `.OrderBy()` method in the controller

3. **Change the Colors**
   - Edit the status badges (completed/not started) to different colors
   - Try different Bootstrap color classes: `bg-primary`, `bg-success`, `bg-info`, etc.

4. **Add More Sample Games**
   - Edit `GameService.cs` constructor to add more games you like

### Intermediate Tasks (More challenging!)

5. **Add a Search Feature**
   - Add a search box above the game list
   - Filter games by title
   - Hint: Use `Where()` to filter the list

6. **Filter by Status**
   - Add buttons: Show All, Show Completed, Show Not Started
   - Filter the games based on the `IsCompleted` property

7. **Add Platform Icons**
   - Show different emojis/icons for different platforms

8. **Add Input Validation**
   - Make Title, Platform, and Genre required fields
   - Add `[Required]` attribute to the Game model properties
   - Try adding `[MaxLength(100)]` to limit title length

9. **Count Games by Platform**
   - Add a new statistics card showing how many games per platform
   - Hint: Use `.GroupBy(g => g.Platform)`

### Advanced Tasks (Challenge yourself!)

10. **Add a Recently Added Section**
    - Show the 3 most recently added games on the home page
    - Use `.OrderByDescending(g => g.DateAdded).Take(3)`

11. **Add Multiple Screenshots URLs**
    - Add a `Screenshots` property (List<string>) to store image URLs
    - Display thumbnail images on the detail page

12. **Create a Genre Filter Dropdown**
    - Get unique genres from all games
    - Create a dropdown to filter by genre

13. **Add Hours to Complete**
    - Add `HoursToComplete` property
    - Show total hours across all games
    - Calculate average completion time

14. **Export to Text File**
    - Add a button to export the game list to a `.txt` file
    - Research `System.IO.File.WriteAllText()`

---

## Learning Tips

1. **Make small changes** - Change one thing at a time and test it
2. **Read the comments** - The code is heavily commented to help you understand
3. **Break things!** - Do not be afraid to experiment. You can always undo changes
4. **Use the error messages** - They usually tell you exactly what is wrong
5. **Google is your friend** - Search for "ASP.NET Core MVC" plus what you want to do

---

## Common Issues and Solutions

### The app shows old data after I restart
- **Why?** Data is stored in memory, so it resets when the app stops
- **Solution:** This is normal! Later you can learn to use a database to persist data

### I changed the code but nothing happened
- **Solution:** Stop the app (Shift+F5) and run it again (F5)

### I get an error about Model
- **Solution:** Make sure your view has the correct `@model` directive at the top

### Changes to CSS are not showing
- **Solution:** Try hard-refreshing the browser (Ctrl+F5 or Cmd+Shift+R)

---

## What to Learn Next

After mastering this project, you could explore:

1. **Database Integration** - Use Entity Framework Core to save data permanently
2. **User Authentication** - Add login/registration (ASP.NET Core Identity)
3. **API Development** - Create a REST API instead of MVC views
4. **JavaScript/AJAX** - Make the page update without full page reloads
5. **Deployment** - Host your app on Azure or another cloud platform

---

## Resources for Learning More

- [Microsoft ASP.NET Core Tutorial](https://learn.microsoft.com/aspnet/core/tutorials/first-mvc-app/start-mvc)
- [W3Schools C# Tutorial](https://www.w3schools.com/cs/)
- [Bootstrap Documentation](https://getbootstrap.com/docs/)
- [Stack Overflow](https://stackoverflow.com/)

---

## Congratulations!

You now have a working web application! Feel free to customize it, break it, fix it, and make it your own. 

The best way to learn programming is by **doing** - so pick a task from the list above and give it a try!

**Happy Coding!**

---

## Notes for Teachers/Mentors

This project intentionally avoids:
- Repository pattern
- Dependency injection complexity
- Unit of Work pattern
- AutoMapper
- Complex validation frameworks
- Database integration (initially)

The goal is to teach the **fundamentals of MVC** in the clearest way possible. Advanced patterns can be introduced later once the student has confidence with the basics.
