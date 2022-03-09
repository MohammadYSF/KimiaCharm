using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using Microsoft.Extensions.Logging;
using ViewModels;

namespace KimiaCharm.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private readonly UnitOfWork _db;
        public CartController(ILogger<CartController> logger, UnitOfWork db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index(int id)
        {
            Cart cart = _db.CartRepository.Find(id);
            if (cart == null)
            {
                return NotFound();
            }
            //CartViewModel cartViewModel = new CartViewModel()
            //{
            //    PostPrice = 30000,
            //    ProductsTotalPrice = cart.ProductsTotalPrice,
            //    TotalPrice = cart.TotalPrice
            //};
            return View(cart);
        }
    }
}
