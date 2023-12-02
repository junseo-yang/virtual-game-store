namespace PROG3050.Models
{
    public class Cart
    {
        public string? UserId { get; set; }
        public User? User { get; set; }

        public int? GameId { get; set; }
        public Game? Game { get; set; }

        public int Quantity { get; set; }
    }
}
