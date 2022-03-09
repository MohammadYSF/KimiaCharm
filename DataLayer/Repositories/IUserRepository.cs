using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataLayer.Models;
namespace DataLayer.Repositories
{
    public interface IUserRepository
    {
        bool Addd(User user);
        bool Edit(User user);
        bool Delete(User user);
        bool Delete(int id);
        User Find(int id);
        IQueryable<User> Get(Expression<Func<User, bool>> where = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderby = null, string includes = "");
        IEnumerable<User> FindUsersByRoleID(int roleID);
    }
}
