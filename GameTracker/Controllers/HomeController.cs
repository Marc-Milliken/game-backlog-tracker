using GameTracker.Models;
using GameTracker.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq; // add if not already present
using System.IO;
using System.Text;

namespace GameTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameService _gameService;

        // CONSTRUCTOR - runs when the controller is created
        // It receives the GameService so we can use it in our actions
        public HomeController(GameService gameService)
        {
            _gameService = gameService;
        }
        public IActionResult Index(string direction = "desc")
        {
            var games = _gameService.GetAllGames();
            var ordered = games.OrderByDescending(g => g.DateAdded).Take(3);
            
            return View("Index", ordered.ToList());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
