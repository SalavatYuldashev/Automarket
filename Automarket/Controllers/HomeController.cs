using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Automarket.Domain.Entity;
using Automarket.Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Automarket.Models;

namespace Automarket.Controllers
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
            Car car = new Car
            {
                Name = "ToyotaCorolla",
                MaxSpeed = 256
            };
            return View(car);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}