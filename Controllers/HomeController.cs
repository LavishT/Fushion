using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fushion.Models;

namespace Fushion.Controllers
{
    // This is the home controller for the page to give different views to differnet pages.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // index view
        public IActionResult Index()
        {
            return View();
        }
        // privacy view
        public IActionResult Privacy()
        {
            return View();
        }
        //about view
        public IActionResult About()
        {
            return View();
        }
        //category view
        public IActionResult Category()
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
