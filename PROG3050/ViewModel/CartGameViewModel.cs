namespace PROG3050.ViewModel
{
    public class CartGameViewModel
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalCost => Math.Round(Quantity * Price, 2);
    }
}
