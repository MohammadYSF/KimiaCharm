using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نقش کاربر")]
        public string RoleName { get; set; }
        public IEnumerable<User> Users { get; set; }
        public Role()
        {

        }
    }
}
