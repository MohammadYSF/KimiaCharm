using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Repositories;
using DataLayer.Services;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        private KimiaCharmContext _db;
        private CategoryRepository _categoryRepository;
        public UnitOfWork(KimiaCharmContext db)
        {
            _db = db;
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_db);
                }
                return _categoryRepository;
            }
        }
        private ProductRepository _productRepository;

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_db);
                }
                return _productRepository;
            }
        }
        private CartRepository _cartRepository ;

        public ICartRepository CartRepository
        {
            get
            {
                if (_cartRepository == null)
                {
                    _cartRepository = new CartRepository(_db);
                }
                return _cartRepository;
            }
        }
        private RoleRepository _roleRepository;

        public IRoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new RoleRepository(_db);
                }
                return _roleRepository;
            }
        }
        private UserRepository _userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_db);
                }
                return _userRepository;
            }
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
