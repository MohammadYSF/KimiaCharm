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
    public class RoleRepository : IRoleRepository
    {
        private readonly KimiaCharmContext _db;
        public RoleRepository(KimiaCharmContext db)
        {
            _db = db;
        }
        public bool Add(Role role)
        {
            try
            {
                _db.Role.Add(role);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Delete(Role role)
        {
            try
            {
                _db.Role.Remove(role);
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

        public bool Edit(Role role)
        {
            try
            {
                _db.Entry(role).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public Role Find(object id)
        {
            return _db.Role.Find(id);
        }

        public IEnumerable<Role> Get()
        {
            return _db.Role;
        }
    }
}
