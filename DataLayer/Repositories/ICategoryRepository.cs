using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
namespace DataLayer.Repositories
{
    public interface ICategoryRepository
    {
        bool Add(Category category);
        bool Delete(Category category);
        bool Edit(Category category);
        bool Delete(object id);
        IEnumerable<Category> Get();
        Category Find(object id);

    }
}
