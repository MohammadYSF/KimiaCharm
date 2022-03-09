using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [Display(Name = "نقش کاربر")]
        public int RoleID { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "ایمیل")]
        [MaxLength(300)]
        public string Email { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام")]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام خانوادگی")]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شماره تلفن همراه")]
        [MinLength(11)]
        [MaxLength(11)]
        //like this : 09372898644
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [DataType(DataType.Password)]
        //[MinLength(6)] I will write the min and max lenght of the hashed password according to the way we have hash password
        public string HashedPassword { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت نام در سایت")]
        [DataType(DataType.Date)]
        public DateTime DateOfRegisteration { get; set; }
        public Role Role { get; set; }
        public User()
        {

        }
    }
}
