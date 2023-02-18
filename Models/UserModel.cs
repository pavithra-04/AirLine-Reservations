using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ALR_02.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

       

        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is Required.")]
        [Display(Name = "Username * ")]
        public string Username { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "EmailId is Required.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email * ")]
        public string EmailId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password * ")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is Required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password * ")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password should be same.")]
        public string ConfirmPassword { get; set; }


     //   public DateTime CreatedOn { get; set; }

     //   public string SuccessMessage { get; set; }
    }
}