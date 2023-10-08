using FactorialCalc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FactorialCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(string factnumber)
        {
            int number = Convert.ToInt32(factnumber);
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            ViewBag.result = "Factorial of " + factnumber + " is " + factorial.ToString();
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