using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Travel_Manager.Models
{
    public class UserClass
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please enter Username")]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Please enter the Password")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please confirm your Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd", ErrorMessage = "Password doesn't match.")]
        public string Confirmedpwd { get; set; }

        
        [Required(ErrorMessage = "Please enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Uemail { get; set; }

       
        [Required(ErrorMessage = "Select your Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }


    }
}
