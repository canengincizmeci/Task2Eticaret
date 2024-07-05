using AdminPaneli.Models;
using Db.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminPaneli.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Task2EticaretContext _context;

        public HomeController(ILogger<HomeController> logger, Task2EticaretContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ActionResult Login()
        {


            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
