using GameTracker.Models;
using GameTracker.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq; // add if not already present

namespace GameTracker.Controllers
{
    // This is a CONTROLLER - it handles all requests related to games
    // Controllers are like traffic directors - they decide what to do when someone visits a page
    // Every public method in here is called an "Action" and can be accessed via a URL
    public class GameController : Controller
    {
        // This is our game service that manages the game data
        private readonly GameService _gameService;

        // CONSTRUCTOR - runs when the controller is created
        // It receives the GameService so we can use it in our actions
        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        // ACTION: Show the list of all games
        // URL: /Game/Index or just /Game
        // This is what happens when someone visits the games page
        public IActionResult Index()
        {
            // Step 1: Get all games from the service
            var games = _gameService.GetAllGames();

            // Step 2: Send the games to the View (the HTML page)
            // The View will display the games to the user
            return View(games);
        }

        public IActionResult SortByTitle(string direction = "asc")
        { 
            var games = _gameService.GetAllGames();

           
            var ordered = direction?.ToLower() == "desc"
                ? games.OrderByDescending(g => g.Title)
                : games.OrderBy(g => g.Title);

            return View("Index", ordered.ToList());
        }

        public IActionResult SortByPlatform(string direction = "asc")
        {
            var games = _gameService.GetAllGames();


            var ordered = direction?.ToLower() == "desc"
                ? games.OrderByDescending(g => g.Platform)
                : games.OrderBy(g => g.Platform);

            return View("Index", ordered.ToList());
        }

        public IActionResult SortByDate(string direction = "asc")
        {
            var games = _gameService.GetAllGames();


            var ordered = direction?.ToLower() == "desc"
                ? games.OrderByDescending(g => g.DateAdded)
                : games.OrderBy(g => g.DateAdded);

            return View("Index", ordered.ToList());
        }

        public IActionResult AllGames()
        {
            var games = _gameService.GetAllGames();

            return View("Index", games.ToList());
        }

        public IActionResult CompletedGames()
        {
            var games = _gameService.GetAllGames();
            IEnumerable<Game> query = games.Where(g => g.IsCompleted);
            return View("Index", query.ToList());
        }




        // ACTION: Show the form to create a new game
        // URL: /Game/Create
        // This is a GET request - it just shows the empty form
        [HttpGet]
        public IActionResult Create()
        {
            // Just show the create form (no data needed)
            return View();
        }

        // ACTION: Save the new game
        // URL: /Game/Create (but this time it's a POST request with form data)
        // This runs when the user clicks "Save" on the create form
        [HttpPost]
        public IActionResult Create(Game game)
        {
            // Step 1: Check if the data is valid (e.g., required fields filled in)
            if (ModelState.IsValid)
            {
                // Step 2: Add the game using our service
                _gameService.AddGame(game);

                // Step 3: Redirect back to the list page
                // This prevents the form from being submitted twice if user refreshes
                return RedirectToAction("Index");
            }

            // If something was wrong, show the form again with error messages
            return View(game);
        }

        // ACTION: Show the form to edit an existing game
        // URL: /Game/Edit/5 (where 5 is the game ID)
        // This is a GET request - it shows the form filled with existing data
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Step 1: Find the game by its ID
            var game = _gameService.GetGameById(id);

            // Step 2: If game doesn't exist, show error page
            if (game == null)
            {
                return NotFound();
            }

            // Step 3: Show the edit form with the game data
            return View(game);
        }

        // ACTION: Save the edited game
        // URL: /Game/Edit/5 (but this time it's a POST request with form data)
        // This runs when the user clicks "Save" on the edit form
        [HttpPost]
        public IActionResult Edit(Game game)
        {
            // Step 1: Check if the data is valid
            if (ModelState.IsValid)
            {
                // Step 2: Update the game using our service
                _gameService.UpdateGame(game);

                // Step 3: Redirect back to the list page
                return RedirectToAction("Index");
            }

            // If something was wrong, show the form again with error messages
            return View(game);
        }

        // ACTION: Show the confirmation page for deleting a game
        // URL: /Game/Delete/5 (where 5 is the game ID)
        // We show a confirmation page so users don't accidentally delete games
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Step 1: Find the game by its ID
            var game = _gameService.GetGameById(id);

            // Step 2: If game doesn't exist, show error page
            if (game == null)
            {
                return NotFound();
            }

            // Step 3: Show the delete confirmation page
            return View(game);
        }

        // ACTION: Actually delete the game
        // URL: /Game/DeleteConfirmed (POST request)
        // This runs when the user clicks "Delete" on the confirmation page
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            // Step 1: Delete the game using our service
            _gameService.DeleteGame(id);

            // Step 2: Redirect back to the list page
            return RedirectToAction("Index");
        }
    }
}
