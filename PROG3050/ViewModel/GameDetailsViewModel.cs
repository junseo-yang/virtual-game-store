using PROG3050.Models;

namespace PROG3050.ViewModel
{
    public class GameDetailsViewModel
    {
        public Game? Game { get; set; }
        public List<Game> RecommendedGames { get; set; }
        public bool SameCategory { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
