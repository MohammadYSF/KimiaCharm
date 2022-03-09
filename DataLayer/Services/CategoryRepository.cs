using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
using DataLayer.Context;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataLayer.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private KimiaCharmContext _db;
        public CategoryRepository(KimiaCharmContext db)
        {
            _db = db;
        }
        public bool Add(Category category)
        {
            try
            {
                _db.Category.Add(category);
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public bool Delete(Category category)
        {
            try
            {
                _db.Category.Remove(category);
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public bool Delete(object id)
        {
            try
            {
            Delete(Find(id));
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public bool Edit(Category category)
        {
            try
            {
                _db.Entry(category).State = EntityState.Modified;
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public Category Find(object id)
        {
            return _db.Category.Find(id);
        }

        public IEnumerable<Category> Get()
        {
            return _db.Category.ToList();
        }
    }
}
