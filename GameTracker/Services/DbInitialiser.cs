using GameTracker.Data;
using GameTracker.Models;
using System.Linq;

namespace GameTracker.Services
{
    public static class DbInitializer
    {
        public static void Initialize(GameContext context, GameService gameService)
        {
            // If the DB already has games, do nothing
            if (context.Games.Any())
            {
                return;
            }

            // Get games from the in-memory service
            var existingGames = gameService.GetAllGames();

            // Reset Id values so SQL Server generates new identity values
            foreach (var game in existingGames)
            {
                game.Id = 0;
            }

            // Add them to the database
            context.Games.AddRange(existingGames);
            context.SaveChanges();
        }
    }
}