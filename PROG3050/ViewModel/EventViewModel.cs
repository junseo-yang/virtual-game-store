using PROG3050.Models;

namespace PROG3050.ViewModel
{
    public class EventViewModel
    {
        public List<Event>? Events { get; set; }
        public List<User>? Users { get; set; }
        public string? CurrentUserId { get; set; }

        public Event? SelectedEvent { get; set; }
    }
}
