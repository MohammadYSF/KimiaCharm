using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        [Display(Name = "مبلغ پرداختی نهایی")]
        [DataType(DataType.Currency)]
        public decimal PostingPrice { get; set; }
        public decimal ProductsTotalPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual IEnumerable<CartItem> CartItems { get; set; }
        public Cart()
        {

        }


    }
}
