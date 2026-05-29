# ????? Mentor Guide - Game Backlog Tracker

This guide is for teachers, mentors, or senior developers who are supporting a student learning ASP.NET Core MVC with this project.

---

## ?? Project Overview

**Purpose:** Introduce ASP.NET Core MVC fundamentals to a 17-year-old student during a 4-day work experience.

**Key Philosophy:** Clarity over complexity. This project intentionally avoids enterprise patterns to focus on core MVC concepts.

---

## ?? Learning Objectives

By the end of the work experience, the student should understand:

1. **The MVC Pattern**
   - What Models, Views, and Controllers are
   - How they work together
   - Why separation of concerns matters

2. **HTTP Basics**
   - Difference between GET and POST requests
   - How forms submit data
   - URL routing and parameters

3. **C# Fundamentals in Context**
   - Classes and properties
   - Lists and LINQ basics
   - Nullable types
   - DateTime handling

4. **Razor Syntax**
   - Mixing HTML and C# with `@` symbol
   - Loops and conditionals in views
   - Tag helpers for forms
   - Layouts and partials

5. **Bootstrap Basics**
   - Grid system (rows and columns)
   - Common components (cards, badges, buttons, tables)
   - Basic responsive design

---

## ?? Suggested 4-Day Schedule

### Day 1: Understanding & Exploration (Monday)
**Morning:**
- Clone/download the project
- Run the application together
- Walkthrough of the app features (add, edit, delete games)
- Explain the MVC pattern using this app as example
- Code walkthrough: Follow the flow of one action (e.g., Create)

**Afternoon:**
- Make small changes together:
  - Change some text on the home page
  - Add a new sample game to GameService
  - Change badge colors in Index view
- Student makes small changes independently:
  - Change emoji icons
  - Modify table column headers
  - Update footer text

**Homework:** Read README.md, explore BACKLOG.md tasks

---

### Day 2: First Features (Tuesday)
**Morning:**
- Review: What is a Model, Controller, View?
- Pick an easy task from BACKLOG.md (e.g., Add Rating System)
- Work through it together step-by-step:
  1. Add property to Model
  2. Update Create/Edit views with input
  3. Update Index view to display it
  4. Test thoroughly

**Afternoon:**
- Student picks another easy task (e.g., Platform Icons)
- Student works independently with mentor available for questions
- Code review and testing together

**Homework:** Try one more easy task at home (optional)

---

### Day 3: Building Confidence (Wednesday)
**Morning:**
- Review previous day's work
- Introduce intermediate tasks (e.g., Search or Filtering)
- Discuss GET parameters and how they work
- Work together on initial implementation

**Afternoon:**
- Student continues the feature independently
- Introduce LINQ methods (Where, OrderBy) as needed
- Help debug any issues

**Homework:** Think about what feature they'd like to add on Day 4

---

### Day 4: Independence & Wrap-up (Thursday)
**Morning:**
- Student selects a feature they want to build
- Student plans the implementation (what needs to change?)
- Mentor reviews the plan
- Student implements with minimal help

**Afternoon:**
- Finish and polish the feature
- Retrospective discussion:
  - What did you learn?
  - What was challenging?
  - What would you like to learn next?
- Optional: Deploy to Azure/local showcase

---

## ?? Teaching Tips

### Do's ?
- **Let them struggle a bit** - It's okay if they get stuck for 10-15 minutes
- **Encourage experimentation** - "What do you think will happen if we change this?"
- **Use analogies** - "The controller is like a receptionist, the model is like a form you fill out..."
- **Celebrate small wins** - "Great! You just modified a view successfully!"
- **Show the error messages** - Teach them to read and understand errors
- **Use Visual Studio features** - Intellisense, Go to Definition, debugging breakpoints

### Don'ts ?
- **Don't solve problems immediately** - Ask guiding questions first
- **Don't introduce advanced concepts** - No async/await, DI patterns, repositories yet
- **Don't expect perfection** - Messy code that works is fine at this stage
- **Don't overwhelm with theory** - Learn by doing, explain concepts in context
- **Don't compare to other students** - Everyone learns at their own pace

---

## ?? Common Student Mistakes & How to Help

### 1. Forgetting to Save Files
**Symptom:** "I changed the code but nothing happened!"  
**Solution:** Check if the file has a dot (unsaved). Save all (Ctrl+Shift+S) and restart the app.

### 2. Mismatched Model/View
**Symptom:** Error about model type mismatch  
**Solution:** Show them the `@model` directive and explain it must match what the controller sends.

### 3. Missing Required Attributes
**Symptom:** Null reference exceptions  
**Solution:** Explain nullable types and the `?` operator. Add null checks or required validation.

### 4. Wrong HTTP Method
**Symptom:** "POST action not found" or form not submitting  
**Solution:** Explain GET vs POST. Show them the `[HttpGet]` and `[HttpPost]` attributes.

### 5. Forgetting to Register Services
**Symptom:** DI error about GameService  
**Solution:** Show them Program.cs and explain service registration (even if briefly).

---

## ?? Key Concepts to Reinforce

### Throughout the Week, Emphasize:

1. **Data Flow**
   - User ? Browser ? Controller ? Service/Model ? Controller ? View ? Browser ? User

2. **Separation of Concerns**
   - Models = data structure only
   - Controllers = logic and decisions
   - Views = display only
   - Services = data management

3. **RESTful Conventions**
   - Index = list all
   - Create = add new (GET shows form, POST saves)
   - Edit = modify existing
   - Delete = remove

4. **HTML Forms**
   - Action attribute ? where to send data
   - Method attribute ? GET or POST
   - Input names ? must match model properties

---

## ?? Code Review Checklist

When reviewing the student's code, check for:

- [ ] Code compiles and runs without errors
- [ ] Feature works as expected (test happy path)
- [ ] Edge cases handled (e.g., empty list, null values)
- [ ] UI looks reasonable (doesn't have to be perfect)
- [ ] Code is reasonably formatted (not perfect, but readable)
- [ ] No obviously dangerous code (like SQL injection - shouldn't be possible in this project)

---

## ?? Extension Ideas (If They Finish Early)

If the student blazes through tasks:

1. **Add JavaScript Interactivity**
   - Confirm delete with `confirm()` dialog
   - Client-side search filtering
   - Dynamic tag adding

2. **Improve UX**
   - Add loading states
   - Toast notifications for actions
   - Keyboard shortcuts

3. **Connect to a Real API**
   - Fetch game data from RAWG API or IGDB
   - Auto-populate game details

4. **Begin Database Integration**
   - Install Entity Framework Core
   - Create a simple SQLite database
   - Migrate from in-memory to database

---

## ?? Assessment Suggestions

### Informal Checks Throughout the Week:
- Can they explain what a Model, View, and Controller does?
- Can they trace the flow of a request through the app?
- Can they read and understand error messages?
- Can they modify existing code confidently?
- Can they create new features with decreasing amounts of help?

### End of Week Demonstration:
Ask the student to:
1. Walk you through the app they built
2. Explain one feature they added (how it works)
3. Show you the code for that feature
4. Explain what was challenging
5. Share what they'd like to add next

**This is not a formal exam** - just a conversation to gauge understanding and confidence.

---

## ?? What to Provide the Student at End

- Access to the complete source code
- This README and BACKLOG
- Links to learning resources
- Encouragement to continue learning!
- Optional: Certificate of completion or reference letter

---

## ?? Recommended Next Steps After This Project

Suggest the student explore:

1. **Entity Framework Core** - Persistent data storage
2. **ASP.NET Core Identity** - User authentication
3. **Web APIs** - Building RESTful services
4. **Blazor** - C# for frontend development
5. **Deployment** - Hosting on Azure or another platform
6. **Unit Testing** - Writing tests for their code

---

## ?? When to Get Additional Support

If the student:
- Seems completely lost after Day 2 ? Slow down, do more pair programming
- Isn't asking questions ? Encourage questions, create a safe environment
- Is bored/not challenged ? Jump to harder tasks, add stretch goals
- Has strong opinions about architecture ? Great! Discuss why we kept it simple here, when patterns make sense

---

## ?? Support Resources

If you (the mentor) need help:
- [ASP.NET Core Documentation](https://learn.microsoft.com/aspnet/core/)
- [Stack Overflow - ASP.NET Core](https://stackoverflow.com/questions/tagged/asp.net-core)
- [r/dotnet Subreddit](https://reddit.com/r/dotnet)
- [ASP.NET Core Community Standup](https://dotnet.microsoft.com/live/aspnet-community-standup)

---

## ?? Final Notes

**Remember:** The goal is to build confidence and spark interest in web development. A student who finishes the week excited about coding and wanting to learn more is a huge success - even if they only completed a few features.

Be patient, be encouraging, and have fun! ??

---

**Good luck, and thank you for mentoring the next generation of developers!**
