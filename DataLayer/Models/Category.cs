using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Models
{
  public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام دسته بندی")]
        public string Name { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public Category()
        {

        }
    }
}
