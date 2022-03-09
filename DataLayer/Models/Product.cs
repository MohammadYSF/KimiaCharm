using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Display(Name = "دسته بندی کالا")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CategoryID { get; set; }
        [Display(Name = "نام کالا")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }
        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ShortDescription { get; set; }
        [Display(Name = "شرح کامل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string FullDescription { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime Date { get; set; }
        [Display(Name = "کلمات کلیدی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Keywords { get; set; }
        [Display(Name = "تصویر افقی کالا")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string HorizontalImageName { get; set; }
        [Display(Name = "تصویر عمودی کالا")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string VerticalImageName { get; set; }
     
        [Display(Name = "قیمت کالا")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "وضع موجودی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public bool IsAvailable { get; set; }
        public virtual Category Category { get; set; }
        public Product()
        {

        }
        public virtual CartItem CartItem { get; set; }
        
    }
}
