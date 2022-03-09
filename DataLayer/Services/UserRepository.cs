using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using System.Linq;
using System.Linq.Expressions;

namespace DataLayer.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly KimiaCharmContext _db;
        public UserRepository(KimiaCharmContext db)
        {
            _db = db;
        }
        public bool Addd(User user)
        {
            try
            {
                _db.User.Add(user);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Delete(User user)
        {
            try
            {
                _db.User.Remove(user);
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

        public bool Edit(User user)
        {
            try
            {
                _db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public User Find(int id)
        {
            return _db.User.Include(a=> a.Role).Single(a => a.RoleID == id);

        }

        public IEnumerable<User> FindUsersByRoleID(int roleID)
        {
            return _db.User.Include(a => a.RoleID).Where(a => a.RoleID == roleID);
           
        }

        public IQueryable<User> Get(Expression<Func<User, bool>> where = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderby = null, string includes = "")
        {
            IQueryable<User> query = _db.User;
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
    }
}
