using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ALR_02.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "EmailId  is required")]
        [Display(Name = "EmailId * ")]
        public string EmailId { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [Display(Name = "Password * ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}