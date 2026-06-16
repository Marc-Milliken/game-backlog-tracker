using System.Diagnostics.Eventing.Reader;

namespace GameTracker.Models
{
    // This is a MODEL - it represents a single game in our backlog
    // Models are simple classes that hold data
    // Think of a model as a blueprint for what data we want to track
    public class Game
    {
        // Unique identifier for each game (like a serial number)
        public int Id { get; set; }

        // The name of the game (e.g., "The Legend of Zelda")
        public string Title { get; set; } = string.Empty;

        // What platform the game is on (e.g., "Nintendo Switch", "PC", "PlayStation 5")
        public string Platform { get; set; } = string.Empty;

        // What type of game it is (e.g., "RPG", "Action", "Puzzle")
        public string Genre { get; set; } = string.Empty;

        // What is the rating of the game? (1-5 stars)
        public string Rating { get; set; } = string.Empty;

        // Has the game been completed? true = yes, false = no
        public bool IsCompleted { get; set; }

        // When was this game added to our backlog?
        public DateTime DateAdded { get; set; }
    }
}
