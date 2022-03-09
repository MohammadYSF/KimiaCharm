using System;
using System.Collections.Generic;
using DataLayer.Models;
namespace DataLayer.Repositories
{
    public interface IRoleRepository
    {
        bool Add(Role role);
        bool Edit(Role role);
        bool Delete(Role role);
        bool Delete(object id);
        Role Find(object id);
        IEnumerable<Role> Get();
    }
}
