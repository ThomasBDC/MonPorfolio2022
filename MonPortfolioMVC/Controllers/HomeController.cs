using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonPortfolioMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MonPortfolioMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //monsite.fr/Home/Methode
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //monsite.fr/Home/Index
        //monsite.fr/Home
        //monsite.fr
        public IActionResult Index()
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
