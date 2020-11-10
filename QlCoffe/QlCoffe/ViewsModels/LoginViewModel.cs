using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QlCoffe.ViewsModels
{
    public class LoginViewModel
    {
        [Required]
       
        public string Username { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { set; get; }
        [Display(Name ="Remember me")]
        public bool Remember { set; get; }
    }
}
