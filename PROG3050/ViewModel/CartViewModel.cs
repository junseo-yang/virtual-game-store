using PROG3050.Models;

namespace PROG3050.ViewModel
{
    public class CartViewModel
    {
        public string UserId { get; set; }

        public List<CartGameViewModel> CartGames { get; set; }
    }
}
