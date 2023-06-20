using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketBookingApplication.Models;

namespace TicketBookingApplication.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}