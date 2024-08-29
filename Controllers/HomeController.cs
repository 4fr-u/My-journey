using fproject.Data;
using fproject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace fproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Student()
        { 
               return View();
        }
        [HttpGet]
        public IActionResult ResForm()
        { 
               return View();
        }
        [HttpPost]
        public IActionResult ResForm(Guest guest)
        { 
               var gentity =_context.Add(guest);
            _context.SaveChanges();
               return View("Thanks",gentity.Entity);
        }
        public IActionResult ListGuest()
        {
            var response=_context.guests.ToList();
            return View(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
