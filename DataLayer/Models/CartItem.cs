using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class CartItem
    {
        [Key]
        public int CartItemID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int CartID { get; set; }
        [Display(Name = "تعداد کالا")]
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
        public CartItem()
        {

        }
    }
}
