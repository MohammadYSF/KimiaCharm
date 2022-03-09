using DataLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace KimiaCharm.Compontents.Category
{
    public class ShowCategoriesViewComponent : ViewComponent
    {
        private readonly UnitOfWork _db;
        public ShowCategoriesViewComponent(UnitOfWork db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View("/Views/Components/ShowCategoriesViewComponent.cshtml", ShowCategories());

        }
        public IEnumerable<DataLayer.Models.Category> ShowCategories()
        {
            var data = _db.CategoryRepository.Get();
            return data;
        }
    }
}
