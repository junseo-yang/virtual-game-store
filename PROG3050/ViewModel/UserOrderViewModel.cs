using PROG3050.Models;

namespace PROG3050.ViewModel
{
    public class UserOrderViewModel
    {
        public Order? Order { get; set; }
        public List<CartGameViewModel>? Games { get; set; }
    }
}
