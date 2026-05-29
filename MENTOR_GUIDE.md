# Mentor Guide - Game Backlog Tracker

This guide is for teachers and mentors supporting a student learning ASP.NET Core MVC.

## Project Overview

**Purpose:** Introduce ASP.NET Core MVC fundamentals during a 4-day work experience.

**Key Philosophy:** Clarity over complexity. No enterprise patterns - just core MVC concepts.

## Learning Objectives

By the end, the student should understand:

1. **The MVC Pattern** - What Models, Views, and Controllers are and how they work together
2. **HTTP Basics** - GET vs POST, how forms work, URL routing
3. **C# in Context** - Classes, Lists, LINQ, DateTime
4. **Razor Syntax** - Mixing HTML and C#, loops, conditionals
5. **Bootstrap Basics** - Grid system, components, responsive design

## Suggested 4-Day Schedule

### Day 1: Understanding
- Run the application together
- Walk through features
- Explain MVC using this app
- Code walkthrough: Follow one complete action
- Make small changes together

### Day 2: First Features
- Review MVC concepts
- Pick an easy task from BACKLOG.md
- Work through it step-by-step together
- Student tries another easy task independently

### Day 3: Building Confidence
- Review previous work
- Introduce intermediate task (Search or Filtering)
- Work together initially
- Student continues independently

### Day 4: Independence
- Student selects and plans a feature
- Student implements with minimal help
- Finish and polish
- Retrospective discussion

## Teaching Tips

### Do
- Let them struggle a bit (10-15 minutes)
- Encourage experimentation
- Use analogies
- Celebrate small wins
- Show how to read error messages
- Use Visual Studio features (Intellisense, debugging)

### Don't
- Solve problems immediately - ask guiding questions
- Introduce advanced concepts (async/await, DI patterns, repositories)
- Expect perfection
- Overwhelm with theory
- Compare to other students

## Common Student Mistakes

1. **Forgetting to save files** - Check for unsaved dot, save all
2. **Mismatched Model/View** - Show @model directive
3. **Missing required attributes** - Explain nullable types
4. **Wrong HTTP method** - Explain GET vs POST
5. **Forgetting service registration** - Show Program.cs

## Code Review Checklist

- Compiles and runs
- Feature works as expected
- Edge cases handled
- UI looks reasonable
- Code is readable
- No dangerous code

## Assessment

Not a formal exam - just conversation:
- Can they explain MVC?
- Can they trace a request through the app?
- Can they read error messages?
- Can they modify code confidently?
- Are they becoming more independent?

## Next Steps After This Project

Suggest exploring:
- Entity Framework Core
- ASP.NET Core Identity
- Web APIs
- Blazor
- Deployment to Azure
- Unit Testing

**Remember:** Success is a student who finishes excited about coding and wanting to learn more!
