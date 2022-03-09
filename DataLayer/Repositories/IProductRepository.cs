using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
namespace DataLayer.Repositories
{
    public interface IProductRepository
    {
        bool Add(Product product);
        bool Edit(Product product);
        bool Delete(Product product);
        bool Delete(int id);
        Product Find(int id);
        IEnumerable<Product> Take(int count);
        //seprate your includes using , character
        
        IQueryable<Product> Get(Expression<Func<Product, bool>> where = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderby = null, string includes = "");
        IEnumerable<Product> GetByCategoryID(int categoryID);
        public IEnumerable<Product> GetRelatedProducts(int productID, int count);


    }
}
