using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModels
{
    public class NewPasswordViewModel
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "پسورد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تکرار پسورد")]
        [DataType(DataType.Password)]
        [Compare("Passowrd", ErrorMessage = "پسورد های وارد شده یکسان نیستند")]
        public string RepeatedPassword { get; set; }
    }
}
