// TODO: add reference to Models
using COMP003B._2024SP.Lecture4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B._2024SP.Lecture4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // TODO: add the appropriate action methods
        // GET: Home/Contact
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        // POST: Home/Contact
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Confirmation(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact", model);
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
