using PROG3050.Models;

namespace PROG3050.ViewModel
{
    public class GameViewModel
    {
        public IEnumerable<Game> Games { get; set; }

        public Game? CurrentGame { get; set; }

        public string? Title { get; set; }

        public string ErrorMessage { get; set; } = string.Empty;
    }
}
