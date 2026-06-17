using GameTracker.Models;

namespace GameTracker.Services
{
    // This is a SERVICE - it manages our game data
    // Since we're not using a database, this stores everything in memory
    // When you stop the app, all data is lost (that's okay for learning!)
    public class GameService
    {
        // This is our "fake database" - just a list that stores all games
        private static List<Game> _games = new List<Game>();
        
        // This keeps track of the next ID number to use
        private static int _nextId = 1;

        // CONSTRUCTOR - this runs once when the service is created
        // It adds some sample games so we have data to work with
        public GameService()
        {
            // Only add sample data if the list is empty
            if (_games.Count == 0)
            {
                _games.Add(new Game
                {
                    Id = _nextId++,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Platform = "Nintendo Switch",
                    Genre = "Action-Adventure",
                    HoursToComplete=93,
                    Rating = "5",
                    IsCompleted = true,
                    DateAdded = DateTime.Now.AddDays(-30)
                });

                _games.Add(new Game
                {
                    Id = _nextId++,
                    Title = "Elden Ring",
                    Platform = "PC",
                    HoursToComplete = 105,
                    Genre = "Action RPG",
                    Rating = "3",
                    IsCompleted = false,
                    DateAdded = DateTime.Now.AddDays(-15)
                });

                _games.Add(new Game
                {
                    Id = _nextId++,
                    Title = "Stardew Valley",
                    Platform = "PC",
                    HoursToComplete = 100,
                    Genre = "Simulation",
                    Rating = "2",
                    IsCompleted = false,
                    DateAdded = DateTime.Now.AddDays(-7)
                });

                _games.Add(new Game
                {
                    Id = _nextId++,
                    Title = "Hades",
                    Platform = "PlayStation 5",
                    HoursToComplete = 44,
                    Genre = "Roguelike",
                    Rating = "4",
                    IsCompleted = true,
                    DateAdded = DateTime.Now.AddDays(-45)
                });

                _games.Add(new Game
                {
                    Id = _nextId++,
                    Title = "Minecraft",
                    Platform = "Multi-platform",
                    HoursToComplete = 66,
                    Genre = "Sandbox",
                    Rating = "1",
                    IsCompleted = false,
                    DateAdded = DateTime.Now.AddDays(-60)
                });
                
                _games.Add(new Game
                {
                    Id = _nextId++,
                    Title = "Fortnite",
                    Platform = "Multi-platform",
                    HoursToComplete = 131,
                    Genre = "Battle Royale",
                    Rating = "4",
                    IsCompleted = false,
                    DateAdded = DateTime.Now.AddDays(-60)
                });

                _games.Add(new Game
                {
                    Id = _nextId++,
                    Title = "Counter Strike 2",
                    Platform = "PC",
                    HoursToComplete = 738,
                    Genre = "Shooter",
                    Rating = "2",
                    IsCompleted = false,
                    DateAdded = DateTime.Now.AddDays(-60)
                });
            }
        }

        // Get all games from our list
        public List<Game> GetAllGames()
        {
            return _games;
        }

        // Get just one game by its ID
        public Game? GetGameById(int id)
        {
            // Look through the list and find the game with matching ID
            return _games.FirstOrDefault(g => g.Id == id);
        }

        // Add a new game to our list
        public void AddGame(Game game)
        {
            game.Id = _nextId++;  // Give it a new ID
            game.DateAdded = DateTime.Now;  // Set when it was added
            _games.Add(game);  // Add it to the list
        }

        // Update an existing game
        public void UpdateGame(Game updatedGame)
        {
            // Find the old game in the list
            var existingGame = _games.FirstOrDefault(g => g.Id == updatedGame.Id);
            
            if (existingGame != null)
            {
                // Update all the properties
                existingGame.Title = updatedGame.Title;
                existingGame.Platform = updatedGame.Platform;
                existingGame.HoursToComplete = updatedGame.HoursToComplete;
                existingGame.Genre = updatedGame.Genre;
                existingGame.Rating = updatedGame.Rating;
                existingGame.IsCompleted = updatedGame.IsCompleted;
                // Note: We keep the original DateAdded
            }
        }

        // Delete a game from our list
        public void DeleteGame(int id)
        {
            // Find the game
            var game = _games.FirstOrDefault(g => g.Id == id);
            
            if (game != null)
            {
                // Remove it from the list
                _games.Remove(game);
            }
        }
    }
}
