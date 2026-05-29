# Feature Backlog - Game Tracker

Here are some feature ideas you can implement to practice your skills!

## Easy Tasks

### Task 1: Add Star Rating to Games
**Difficulty:** Easy  
**Time:** 30-45 minutes

Add a rating system so users can rate games from 1 to 5 stars.

**What to do:**
- Add `Rating` property (int, 0-5) to the Game model
- Add rating input to Create and Edit forms
- Display ratings in the Index view
- Show "Not Rated" if rating is 0

### Task 2: Add Platform Icons
**Difficulty:** Easy  
**Time:** 20-30 minutes

Show different icons for different gaming platforms.

**What to do:**
- Use if statements in the view to show different icons based on platform
- PC: Desktop icon, PlayStation: Controller, Xbox: X, etc.

### Task 3: Improve Statistics Dashboard
**Difficulty:** Easy  
**Time:** 30 minutes

Add more interesting statistics.

**What to do:**
- Show percentage of games completed
- Show the most recent game added
- Add a progress bar

## Intermediate Tasks

### Task 4: Add Search Functionality
**Difficulty:** Medium  
**Time:** 1-2 hours

Let users search for games by title.

**What to do:**
- Add a search box above the game list
- Add search parameter to Index action
- Filter games using Where() and Contains()
- Show "No games found" when search returns nothing

### Task 5: Filter by Completion Status
**Difficulty:** Medium  
**Time:** 1 hour

Add filter buttons.

**What to do:**
- Three buttons: All Games, Completed, Not Started
- Filter parameter in Index action
- Highlight the active filter button

### Task 6: Sort Game List
**Difficulty:** Medium  
**Time:** 1 hour

Let users sort the list.

**What to do:**
- Add sort links to table headers
- Use OrderBy() and OrderByDescending()
- Pass sort parameter through URL

## Advanced Tasks

### Task 7: Add Purchase Date and Price
**Difficulty:** Hard  
**Time:** 2 hours

Track when games were purchased and their cost.

**What to do:**
- Add PurchaseDate and Price properties (nullable)
- Update forms with date picker and price input
- Show total money spent in statistics

### Task 8: Add Game Notes
**Difficulty:** Hard  
**Time:** 1.5 hours

Let users add notes about each game.

**What to do:**
- Add Notes property (string)
- Add textarea in Create/Edit forms
- Show truncated notes in Index view
- Create a Details view for full notes

### Task 9: Export to Text File
**Difficulty:** Hard  
**Time:** 2 hours

Let users download their game list.

**What to do:**
- Add Export button
- Create Export action in controller
- Build string with game information
- Return file download

## Tips

- Start with easier tasks
- Test each feature thoroughly
- Google for help when stuck
- Have fun and experiment!
