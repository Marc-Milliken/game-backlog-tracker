# ?? Quick Reference Card - MVC Cheat Sheet

Print this out or keep it handy while coding!

---

## ??? MVC Quick Definitions

| Component | What It Is | Example in This App |
|-----------|------------|-------------------|
| **Model** | A class that represents data | `Game.cs` - represents a game with Title, Platform, etc. |
| **View** | HTML template that displays data | `Index.cshtml` - shows the list of games |
| **Controller** | Handles requests and coordinates | `GameController.cs` - decides what to show |

---

## ?? Common MVC Flow

```
User clicks button
    ?
Browser sends request to URL
    ?
Controller receives request
    ?
Controller gets/modifies data (using Service/Model)
    ?
Controller passes data to View
    ?
View generates HTML
    ?
Browser displays HTML to user
```

---

## ?? File Locations

| What | Where to Find It |
|------|-----------------|
| Models | `Models/Game.cs` |
| Controllers | `Controllers/GameController.cs` |
| Views | `Views/Game/Index.cshtml`, `Create.cshtml`, etc. |
| Layout | `Views/Shared/_Layout.cshtml` |
| Services | `Services/GameService.cs` |
| Startup | `Program.cs` |

---

## ?? Razor Syntax Cheatsheet

| Syntax | What It Does | Example |
|--------|-------------|---------|
| `@` | Write C# code | `@DateTime.Now` |
| `@{ }` | Code block | `@{ var name = "Test"; }` |
| `@if` | Conditional | `@if (game.IsCompleted) { }` |
| `@foreach` | Loop | `@foreach (var game in Model) { }` |
| `@model` | Declare view model type | `@model List<Game>` |
| `@Model` | Access the model data | `@Model.Count` |
| `asp-action` | Link to controller action | `asp-action="Create"` |
| `asp-controller` | Specify controller | `asp-controller="Game"` |
| `asp-route-id` | Pass parameter | `asp-route-id="@game.Id"` |
| `asp-for` | Bind to model property | `asp-for="Title"` |

---

## ?? URL Routing Pattern

```
/{Controller}/{Action}/{id?}
```

| URL | Controller | Action | ID |
|-----|-----------|--------|-----|
| `/Game/Index` | GameController | Index() | - |
| `/Game/Create` | GameController | Create() | - |
| `/Game/Edit/5` | GameController | Edit() | 5 |
| `/Game/Delete/3` | GameController | Delete() | 3 |

---

## ?? Common C# LINQ Methods

| Method | What It Does | Example |
|--------|-------------|---------|
| `.Count()` | Count items | `games.Count()` |
| `.Where()` | Filter items | `games.Where(g => g.IsCompleted)` |
| `.OrderBy()` | Sort ascending | `games.OrderBy(g => g.Title)` |
| `.OrderByDescending()` | Sort descending | `games.OrderByDescending(g => g.DateAdded)` |
| `.FirstOrDefault()` | Get first or null | `games.FirstOrDefault(g => g.Id == 5)` |
| `.Take()` | Get first N items | `games.Take(3)` |
| `.GroupBy()` | Group by property | `games.GroupBy(g => g.Platform)` |

---

## ?? Bootstrap Quick Reference

### Grid System
```html
<div class="container">
    <div class="row">
        <div class="col-md-6">Half width</div>
        <div class="col-md-6">Half width</div>
    </div>
</div>
```

### Common Components
| Component | Class | Example |
|-----------|-------|---------|
| Button | `btn btn-primary` | `<a class="btn btn-primary">Click</a>` |
| Card | `card` | `<div class="card"><div class="card-body">...</div></div>` |
| Badge | `badge bg-success` | `<span class="badge bg-success">New</span>` |
| Alert | `alert alert-info` | `<div class="alert alert-info">Message</div>` |
| Table | `table table-striped` | `<table class="table">...</table>` |

### Color Classes
- `btn-primary` / `bg-primary` - Blue
- `btn-success` / `bg-success` - Green
- `btn-danger` / `bg-danger` - Red
- `btn-warning` / `bg-warning` - Yellow
- `btn-secondary` / `bg-secondary` - Gray
- `btn-info` / `bg-info` - Light blue

---

## ?? Debugging Tips

| Problem | What to Check |
|---------|--------------|
| Page not found (404) | Check URL matches controller/action name |
| Null reference error | Check if data exists before using it (`if (game != null)`) |
| Form not submitting | Check form has `method="post"` and `asp-action` |
| Changes not showing | Save all files (Ctrl+Shift+S) and restart app |
| Model error | Check `@model` in view matches controller's data type |

---

## ?? Useful Keyboard Shortcuts

| Shortcut | What It Does |
|----------|-------------|
| `F5` | Run/Debug the app |
| `Shift+F5` | Stop the app |
| `Ctrl+S` | Save current file |
| `Ctrl+Shift+S` | Save all files |
| `Ctrl+K, Ctrl+C` | Comment code |
| `Ctrl+K, Ctrl+U` | Uncomment code |
| `F12` | Go to definition |
| `Ctrl+.` | Quick actions (add using, etc.) |
| `Ctrl+F` | Find in current file |
| `Ctrl+Shift+F` | Find in all files |

---

## ?? Common Data Annotations

Add these to Model properties for validation:

```csharp
[Required]  // Field must have a value
public string Title { get; set; }

[MaxLength(100)]  // Maximum 100 characters
public string Title { get; set; }

[Range(1, 5)]  // Value must be between 1 and 5
public int Rating { get; set; }

[Display(Name = "Game Title")]  // Friendly name in forms
public string Title { get; set; }

[DataType(DataType.Date)]  // Show as date picker
public DateTime DateAdded { get; set; }
```

---

## ?? How to Add a New Property

**Example: Adding a "Publisher" field**

1. **Update Model** (`Models/Game.cs`)
```csharp
public string Publisher { get; set; } = string.Empty;
```

2. **Update Create View** (`Views/Game/Create.cshtml`)
```html
<div class="mb-3">
    <label asp-for="Publisher" class="form-label">Publisher</label>
    <input asp-for="Publisher" class="form-control" />
</div>
```

3. **Update Edit View** (`Views/Game/Edit.cshtml`)
```html
<div class="mb-3">
    <label asp-for="Publisher" class="form-label">Publisher</label>
    <input asp-for="Publisher" class="form-control" />
</div>
```

4. **Update Index View** (`Views/Game/Index.cshtml`)
```html
<!-- Add to table header -->
<th>Publisher</th>

<!-- Add to table body loop -->
<td>@game.Publisher</td>
```

5. **Update Sample Data** (`Services/GameService.cs`)
```csharp
Publisher = "Nintendo",
```

6. **Test!** Run the app and try adding/editing games

---

## ?? When You're Stuck

1. **Read the error message carefully** - it usually tells you what's wrong!
2. **Check if you saved all files**
3. **Restart the application**
4. **Use breakpoints** (click left margin in code) to see what's happening
5. **Google the error** - someone has probably had the same issue
6. **Ask your mentor** - that's what they're there for!

---

## ?? Remember

- **Mistakes are how we learn** - don't be afraid to break things!
- **Google is your friend** - all developers use it constantly
- **Take breaks** - sometimes walking away helps you see the solution
- **Have fun!** - You're building something real!

---

**Keep this reference handy and happy coding! ??**
