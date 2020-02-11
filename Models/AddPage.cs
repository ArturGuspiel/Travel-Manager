using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Travel_Manager.Models
{
    public class AddPage
    {
        [Key]
        // Title, date, comment
        public string Username { get; set; }
        public int UserId { get; set; }


        [Required(ErrorMessage = "Please enter Title of your post")]
        [Display(Name = "Title")]

        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter date")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Please enter the comment")]
        [Display(Name = "Comment")]
        public string comment { get; set; }


    }
}
