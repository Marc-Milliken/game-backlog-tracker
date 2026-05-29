# Quick Reference - MVC Cheat Sheet

## MVC Components

| Component | What It Is | Example |
|-----------|------------|---------|
| **Model** | Data class | Game.cs - represents a game |
| **View** | HTML template | Index.cshtml - shows games |
| **Controller** | Request handler | GameController.cs - coordinates |

## Common MVC Flow

```
User clicks button
? Browser sends request
? Controller receives request
? Controller gets/modifies data
? Controller passes data to View
? View generates HTML
? Browser displays to user
```

## File Locations

| What | Where |
|------|-------|
| Models | Models/Game.cs |
| Controllers | Controllers/GameController.cs |
| Views | Views/Game/Index.cshtml |
| Layout | Views/Shared/_Layout.cshtml |
| Services | Services/GameService.cs |
| Startup | Program.cs |

## Razor Syntax

| Syntax | Purpose | Example |
|--------|---------|---------|
| `@` | Write C# | `@DateTime.Now` |
| `@{ }` | Code block | `@{ var x = 5; }` |
| `@if` | Conditional | `@if (game.IsCompleted) { }` |
| `@foreach` | Loop | `@foreach (var g in Model) { }` |
| `@model` | Declare type | `@model List<Game>` |
| `@Model` | Access data | `@Model.Count` |
| `asp-action` | Link to action | `asp-action="Create"` |
| `asp-for` | Bind property | `asp-for="Title"` |

## URL Routing

Pattern: `/{Controller}/{Action}/{id?}`

| URL | Controller | Action | ID |
|-----|-----------|--------|-----|
| /Game/Index | GameController | Index() | - |
| /Game/Create | GameController | Create() | - |
| /Game/Edit/5 | GameController | Edit() | 5 |

## Common LINQ Methods

| Method | Purpose | Example |
|--------|---------|---------|
| `.Count()` | Count items | `games.Count()` |
| `.Where()` | Filter | `games.Where(g => g.IsCompleted)` |
| `.OrderBy()` | Sort up | `games.OrderBy(g => g.Title)` |
| `.OrderByDescending()` | Sort down | `games.OrderByDescending(g => g.DateAdded)` |
| `.FirstOrDefault()` | Get first or null | `games.FirstOrDefault(g => g.Id == 5)` |
| `.Take()` | Get first N | `games.Take(3)` |

## Bootstrap Quick Reference

### Grid
```html
<div class="container">
    <div class="row">
        <div class="col-md-6">Half</div>
        <div class="col-md-6">Half</div>
    </div>
</div>
```

### Common Classes
- Button: `btn btn-primary`
- Card: `card` + `card-body`
- Badge: `badge bg-success`
- Table: `table table-striped`
- Alert: `alert alert-info`

### Colors
- Blue: `btn-primary` / `bg-primary`
- Green: `btn-success` / `bg-success`
- Red: `btn-danger` / `bg-danger`
- Yellow: `btn-warning` / `bg-warning`

## Debugging Tips

| Problem | Check |
|---------|-------|
| Page not found | URL matches controller/action name |
| Null reference | Data exists before using |
| Form not submitting | Form has method="post" and asp-action |
| Changes not showing | Saved all files and restarted app |
| Model error | @model matches controller data type |

## Visual Studio Shortcuts

| Shortcut | Action |
|----------|--------|
| F5 | Run/Debug |
| Shift+F5 | Stop |
| Ctrl+S | Save file |
| Ctrl+Shift+S | Save all |
| F12 | Go to definition |
| Ctrl+. | Quick actions |
| Ctrl+F | Find |

## Data Annotations

```csharp
[Required]  // Must have value
public string Title { get; set; }

[MaxLength(100)]  // Max 100 characters
public string Title { get; set; }

[Range(1, 5)]  // Between 1 and 5
public int Rating { get; set; }

[Display(Name = "Game Title")]  // Friendly name
public string Title { get; set; }
```

## Adding a New Property

1. Update Model (Models/Game.cs)
```csharp
public string Publisher { get; set; } = string.Empty;
```

2. Update Create View (Views/Game/Create.cshtml)
```html
<div class="mb-3">
    <label asp-for="Publisher">Publisher</label>
    <input asp-for="Publisher" class="form-control" />
</div>
```

3. Update Edit View (Views/Game/Edit.cshtml) - same as above

4. Update Index View (Views/Game/Index.cshtml)
```html
<th>Publisher</th>  <!-- in header -->
<td>@game.Publisher</td>  <!-- in body -->
```

5. Update Sample Data (Services/GameService.cs)
```csharp
Publisher = "Nintendo",
```

## When Stuck

1. Read error message carefully
2. Check if files are saved
3. Restart the app
4. Use breakpoints
5. Google the error
6. Ask your mentor

## Remember

- Mistakes help you learn
- Google is your friend
- Take breaks
- Have fun!
