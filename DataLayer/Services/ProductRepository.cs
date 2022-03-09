using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Services
{
    public class ProductRepository : IProductRepository
    {
        private KimiaCharmContext _db;
        public ProductRepository(KimiaCharmContext db)
        {
            _db = db;
        }
        public bool Add(Product product)
        {
            try
            {
                _db.Product.Add(product);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Delete(Product product)
        {
            try
            {
                _db.Product.Remove(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
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

        public bool Edit(Product product)
        {
            try
            {
                _db.Entry(product).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public Product Find(int id)
        {
            return _db.Product.Include("Category").Single(a => a.ProductID == id);
        }

        public IQueryable<Product> Get(Expression<Func<Product, bool>> where = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderby = null, string includes = "")
        {
            IQueryable<Product> query = _db.Product;
            if (where != null)
            {
                query = query.Where(where);
            }
            if (orderby != null)
            {
                query = orderby(query);
            }
            if (includes != "")
            {
                foreach (var item in includes.Split(','))
                {
                    query = query.Include(includes);
                }
            }

            return query;
        }


        public IEnumerable<Product> GetByCategoryID(int categoryID)
        {
            var data = _db.Product.Include(a => a.Category).Where(a => a.CategoryID == categoryID);
            return data;

        }

        public IEnumerable<Product> Take(int count)
        {
            return _db.Product.Take(count).Include("Category");
        }
        public IEnumerable<Product> GetRelatedProducts(int productID, int count)
        {
            Product product = Find(productID);
            return _db.Product.Where(a => a.CategoryID == product.CategoryID).Take(count).ToList();
        }
    }
}
