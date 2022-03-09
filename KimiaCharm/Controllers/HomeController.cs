using KimiaCharm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;

namespace KimiaCharm.Controllers
{
    public class HomeController : Controller    

    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork _db;
        public HomeController(ILogger<HomeController> logger , UnitOfWork db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int count = 8)
            {
     
                var data = _db.ProductRepository.Take(count);
                return View(data);
           
           
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
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
