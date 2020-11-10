using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QlCoffe.ViewsModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string PassWord { set; get; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("PassWord",ErrorMessage ="Confirm Password Not Match")]
        public string CofimPassWord { set; get; }
    }
}
