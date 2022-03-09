using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
namespace ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<CartItem> CartItems { get; set; }
        public decimal PostPrice { get; set; }
        public decimal ProductsTotalPrice { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
