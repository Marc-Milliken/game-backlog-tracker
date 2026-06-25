using GameTracker.Data;
using GameTracker.Models;
using GameTracker.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq; // add if not already present
using System.Text;

namespace GameTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameService _gameService;
        private readonly GameContext context;

        // CONSTRUCTOR - runs when the controller is created
        // It receives the GameService so we can use it in our actions
        public HomeController(GameService gameService, GameContext context)
        {
            _gameService = gameService;
            this.context = context;
        }
        public IActionResult Index(string direction = "desc")
        {
            var games = context.Games.ToList();
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
