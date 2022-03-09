using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace DataLayer.Services
{
    public class CartRepository : ICartRepository
    {
        private readonly KimiaCharmContext _db;
        public CartRepository(KimiaCharmContext db)
        {
            _db = db;
        }
        public bool Add(Cart cart)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Cart cart)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Cart cart)
        {
            throw new NotImplementedException();
        }

        public virtual Cart Find(int id)
        {
            return _db.Cart.Include("CartItems").Include("CartItems.Product").Include("CartItems.Product.Category").SingleOrDefault(a => a.CartID == id);
        }
    }
}
