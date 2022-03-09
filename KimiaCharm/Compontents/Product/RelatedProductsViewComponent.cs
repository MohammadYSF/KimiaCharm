using DataLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace KimiaCharm.Compontents.Product
{

    public class RelatedProductsViewComponent : ViewComponent
    {
        private readonly UnitOfWork _db;
        public RelatedProductsViewComponent(UnitOfWork db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id , int count)
        {
            return View("/Views/Components/RelatedProductsViewComponent.cshtml", ShowRelatedProducts(id , count));

        }
        public IEnumerable<DataLayer.Models.Product> ShowRelatedProducts(int id , int count)
        {

           return _db.ProductRepository.GetRelatedProducts(id, count);
        }
    }

}
