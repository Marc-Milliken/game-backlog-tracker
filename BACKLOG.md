# ?? Feature Backlog - Game Tracker

Here are some feature ideas you can implement to practice your skills! Each task includes acceptance criteria to help you know when you're done.

---

## ?? Easy Tasks (Perfect for Day 1-2)

### Ticket #1: Add Star Rating to Games
**Difficulty:** ? Easy  
**Time Estimate:** 30-45 minutes

**Description:**  
Add a rating system so users can rate games from 1 to 5 stars.

**Acceptance Criteria:**
- [ ] Add `Rating` property (int, 0-5) to the `Game` model
- [ ] Add a rating input field to Create and Edit forms (number input, min=0, max=5)
- [ ] Display the rating in the Index view using star emojis (?)
- [ ] Show "Not Rated" if rating is 0

**Hints:**
- Use a loop in the view to display stars: `@for (int i = 0; i < game.Rating; i++)`
- Use `<input type="number" min="0" max="5">` for the form

---

### Ticket #2: Add Different Platform Icons
**Difficulty:** ? Easy  
**Time Estimate:** 20-30 minutes

**Description:**  
Show different emojis/icons for different gaming platforms.

**Acceptance Criteria:**
- [ ] PC games show ???
- [ ] PlayStation games show ??
- [ ] Xbox games show ?
- [ ] Nintendo games show ??
- [ ] Mobile games show ??
- [ ] Other platforms show ???

**Hints:**
- Use `@if` statements or a `@switch` statement in the view
- Example: `@if (game.Platform.Contains("PC")) { <span>???</span> }`

---

### Ticket #3: Improve the Statistics Dashboard
**Difficulty:** ? Easy  
**Time Estimate:** 30 minutes

**Description:**  
Add more interesting statistics to the Index page.

**Acceptance Criteria:**
- [ ] Show percentage of games completed (e.g., "60% Complete")
- [ ] Show the most recent game added
- [ ] Add visual progress bar showing completion percentage

**Hints:**
- Calculate percentage: `(completedCount * 100) / totalCount`
- Use Bootstrap's progress bar component
- Use `.OrderByDescending(g => g.DateAdded).First()` for most recent

---

### Ticket #4: Add Color Coding by Genre
**Difficulty:** ? Easy  
**Time Estimate:** 20 minutes

**Description:**  
Make genre badges different colors based on the type of game.

**Acceptance Criteria:**
- [ ] RPG games have blue badges
- [ ] Action games have red badges
- [ ] Puzzle games have green badges
- [ ] Simulation games have yellow badges
- [ ] Other genres have gray badges

**Hints:**
- Use Bootstrap badge classes: `bg-primary`, `bg-danger`, `bg-success`, `bg-warning`, `bg-secondary`
- Use conditional logic in the view

---

## ?? Intermediate Tasks (Perfect for Day 2-3)

### Ticket #5: Add Search Functionality
**Difficulty:** ?? Medium  
**Time Estimate:** 1-2 hours

**Description:**  
Let users search for games by title.

**Acceptance Criteria:**
- [ ] Add a search box above the game list
- [ ] Search filters games whose titles contain the search text (case-insensitive)
- [ ] Show "No games found" message when search returns no results
- [ ] Clear button to reset the search

**Hints:**
- Add a parameter to the `Index` action: `public IActionResult Index(string searchTerm)`
- Filter games: `games.Where(g => g.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))`
- Use a form with GET method so the search term appears in the URL

---

### Ticket #6: Filter by Completion Status
**Difficulty:** ?? Medium  
**Time Estimate:** 1 hour

**Description:**  
Add filter buttons to show all games, only completed, or only not started.

**Acceptance Criteria:**
- [ ] Three filter buttons: "All Games", "Completed", "Not Started"
- [ ] Clicking a filter updates the list
- [ ] Active filter button is highlighted differently

**Hints:**
- Add a `filter` parameter to the Index action
- Use Bootstrap button groups for styling
- Pass the current filter to the view using ViewData or ViewBag

---

### Ticket #7: Add Input Validation
**Difficulty:** ?? Medium  
**Time Estimate:** 45 minutes

**Description:**  
Prevent users from submitting invalid game data.

**Acceptance Criteria:**
- [ ] Title is required and max 100 characters
- [ ] Platform is required and max 50 characters
- [ ] Genre is required and max 30 characters
- [ ] Show clear error messages when validation fails
- [ ] Client-side validation prevents form submission before server check

**Hints:**
- Use data annotations on the Game model: `[Required]`, `[MaxLength(100)]`
- Use `[Display(Name = "...")]` for friendly field names
- Validation scripts are already included via `_ValidationScriptsPartial`

---

### Ticket #8: Sort Game List
**Difficulty:** ?? Medium  
**Time Estimate:** 1 hour

**Description:**  
Let users sort the game list by different columns.

**Acceptance Criteria:**
- [ ] Sort by Title (A-Z and Z-A)
- [ ] Sort by Platform
- [ ] Sort by Date Added (newest first / oldest first)
- [ ] Sort by Completion Status
- [ ] Active sort option is highlighted

**Hints:**
- Add a `sortBy` parameter to the Index action
- Use LINQ methods: `.OrderBy()`, `.OrderByDescending()`
- Make table headers clickable links that pass the sort parameter

---

### Ticket #9: Count Games by Platform
**Difficulty:** ?? Medium  
**Time Estimate:** 1 hour

**Description:**  
Show a breakdown of how many games you have per platform.

**Acceptance Criteria:**
- [ ] Display a list showing each platform and count
- [ ] Sort platforms by count (most to least)
- [ ] Show this on the Index page or a separate Statistics page

**Hints:**
- Use `.GroupBy(g => g.Platform)`
- Use `.Select(group => new { Platform = group.Key, Count = group.Count() })`
- Display in a table or as Bootstrap badges

---

## ?? Advanced Tasks (Perfect for Day 3-4)

### Ticket #10: Add Purchase Date and Price
**Difficulty:** ??? Hard  
**Time Estimate:** 2 hours

**Description:**  
Track when games were purchased and how much they cost.

**Acceptance Criteria:**
- [ ] Add `PurchaseDate` (nullable DateTime) to Game model
- [ ] Add `Price` (nullable decimal) to Game model
- [ ] Update Create/Edit forms with optional date picker and price input
- [ ] Display purchase info in the Index view
- [ ] Show total money spent in statistics

**Hints:**
- Use `<input type="date">` for date picker
- Use `<input type="number" step="0.01">` for price
- Make properties nullable: `public DateTime? PurchaseDate { get; set; }`
- Calculate sum: `games.Where(g => g.Price.HasValue).Sum(g => g.Price.Value)`

---

### Ticket #11: Add Game Notes/Description
**Difficulty:** ??? Hard  
**Time Estimate:** 1.5 hours

**Description:**  
Let users add notes about each game (thoughts, tips, where they're stuck, etc.).

**Acceptance Criteria:**
- [ ] Add `Notes` (string) to Game model
- [ ] Add a large text area in Create/Edit forms
- [ ] Show notes in Index view (truncated if too long)
- [ ] Create a Details view that shows full notes

**Hints:**
- Use `<textarea>` for multi-line input
- Use `@game.Notes?.Substring(0, Math.Min(100, game.Notes.Length ?? 0))` to truncate
- Add a "View Details" button that goes to a new Details action/view

---

### Ticket #12: Recently Added Section on Home Page
**Difficulty:** ??? Hard  
**Time Estimate:** 1-2 hours

**Description:**  
Show the 3 most recently added games on the home page.

**Acceptance Criteria:**
- [ ] Home page shows "Recently Added Games" section
- [ ] Displays 3 most recent games with title, platform, and "View" link
- [ ] Shows "No games yet" if backlog is empty
- [ ] Clicking a game takes you to the Edit page

**Hints:**
- Inject `GameService` into `HomeController`
- Get recent games: `.OrderByDescending(g => g.DateAdded).Take(3)`
- Pass the list to the view using a view model or ViewBag

---

### Ticket #13: Export Game List to Text File
**Difficulty:** ??? Hard  
**Time Estimate:** 2 hours

**Description:**  
Let users download their game list as a text file.

**Acceptance Criteria:**
- [ ] Add "Export" button on Index page
- [ ] Clicking Export downloads a `my-games.txt` file
- [ ] File contains all games formatted nicely
- [ ] Include title, platform, genre, and completion status for each game

**Hints:**
- Create an `Export` action in GameController
- Build a string with game information
- Return `File(bytes, "text/plain", "my-games.txt")`
- Use `Encoding.UTF8.GetBytes(content)` to convert string to bytes

---

### Ticket #14: Add Completion Date
**Difficulty:** ??? Hard  
**Time Estimate:** 2 hours

**Description:**  
Track when games were completed and show statistics.

**Acceptance Criteria:**
- [ ] Add `CompletionDate` (nullable DateTime) to Game model
- [ ] When marking a game as completed, set CompletionDate to today
- [ ] When unmarking a game, clear the CompletionDate
- [ ] Show completion date in the Index view for completed games
- [ ] Add stat: "Games completed this month"

**Hints:**
- Set date in the controller's Edit POST action
- Check if `IsCompleted` changed from false to true
- Count this month: `games.Count(g => g.CompletionDate?.Month == DateTime.Now.Month)`

---

### Ticket #15: Add Tags/Categories
**Difficulty:** ???? Very Hard  
**Time Estimate:** 3-4 hours

**Description:**  
Let users add multiple tags to games (like "Multiplayer", "Story-Rich", "Short", etc.).

**Acceptance Criteria:**
- [ ] Add `Tags` property (List<string>) to Game model
- [ ] Create a way to add/remove tags in Create/Edit forms
- [ ] Display tags as badges in Index view
- [ ] Filter games by tag

**Hints:**
- You might need to use JavaScript for a better tag input experience
- Or use comma-separated string and split: `game.Tags = tags.Split(',').ToList()`
- Filtering: `games.Where(g => g.Tags.Contains(selectedTag))`

---

## ?? Styling & Polish Tasks

### Ticket #16: Improve Visual Design
**Difficulty:** ?? Medium  
**Time Estimate:** 1-2 hours

**Description:**  
Make the app look more professional and appealing.

**Acceptance Criteria:**
- [ ] Add a custom color scheme (change Bootstrap variables or add custom CSS)
- [ ] Add hover effects on table rows
- [ ] Improve button styles
- [ ] Add icons to buttons (using emoji or Bootstrap icons)
- [ ] Make the app responsive on mobile

---

### Ticket #17: Add Confirmation Before Delete
**Difficulty:** ? Easy  
**Time Estimate:** 30 minutes

**Description:**  
Improve the delete confirmation with a modal popup.

**Acceptance Criteria:**
- [ ] Use a Bootstrap modal for delete confirmation instead of separate page
- [ ] Modal shows game title
- [ ] Delete happens without page navigation

**Hints:**
- Use Bootstrap's modal component
- May require some JavaScript for the modal trigger

---

## ?? Technical Improvement Tasks

### Ticket #18: Add Logging
**Difficulty:** ??? Hard  
**Time Estimate:** 1 hour

**Description:**  
Add logging to track what's happening in the application.

**Acceptance Criteria:**
- [ ] Log when games are created
- [ ] Log when games are deleted
- [ ] Log when errors occur
- [ ] View logs in the console/output window

**Hints:**
- Inject `ILogger<GameController>` into the controller
- Use `_logger.LogInformation("Game created: {Title}", game.Title)`

---

### Ticket #19: Add Database Integration
**Difficulty:** ???? Very Hard  
**Time Estimate:** 4-6 hours

**Description:**  
Replace the in-memory list with a real database so data persists.

**Acceptance Criteria:**
- [ ] Install Entity Framework Core packages
- [ ] Create a DbContext
- [ ] Replace GameService with database access
- [ ] Data survives app restarts

**Hints:**
- Use SQLite for simplicity
- Research "Entity Framework Core with SQLite"
- This is a big change - make a backup first!

---

## ?? Notes

- Start with easier tasks and work your way up
- Don't be afraid to Google for help
- Test each feature thoroughly before moving to the next
- Have fun and experiment!

**Remember:** The goal is to learn, not to rush. Take your time with each feature and make sure you understand what you're doing!
