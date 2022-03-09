using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;

namespace KimiaCharm.Controllers
{
    public class ProductController : Controller
    {
        private readonly UnitOfWork _db;
        public ProductController(UnitOfWork db)
        {
            _db = db;
        }
        public IActionResult Single(int id)
        {
            Product product = _db.ProductRepository.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult ShowProductsByCategoryID(int categoryID)
        {
            IEnumerable<Product> products = _db.ProductRepository.GetByCategoryID(categoryID);

            return View(products);
        }
       
    }
}
