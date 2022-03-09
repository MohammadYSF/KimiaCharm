using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
namespace DataLayer.Repositories
{
    public interface ICartRepository
    {
        Cart Find(int id);
        bool Delete(Cart cart);
        bool Delete(int id);
        bool Edit(Cart cart);
        bool Add(Cart cart);
    }
}
