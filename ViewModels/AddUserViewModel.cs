using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required (ErrorMessage = "Passwords do not match")]

        [Display(Name = "Verify Password")]
        [Compare("Password")]
        public string Verify { get; set; }

    }
}
