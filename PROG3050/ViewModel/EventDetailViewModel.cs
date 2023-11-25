using Microsoft.AspNetCore.Mvc;
using PROG3050.Models;

namespace PROG3050.ViewModel
{
    public class EventDetailViewModel
    {
        public List<User>? Users { get; set; }
        public Event? SelectedEvent { get; set; }
        public User? User { get; set; }
    }
}
