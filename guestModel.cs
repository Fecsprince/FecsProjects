using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BirthdayParty.Models
{
    public class guestModel
    {
        [Required(ErrorMessage ="Enter your first Name!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last Name!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your phone!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter your email address!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Enter a valid email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Select if you are coming or not!")]
        public bool? AreYouComing { get; set; }

    }
}