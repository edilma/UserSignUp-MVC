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
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [StringLength(10, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        public string Password { get; set; }
        [Required (ErrorMessage = "Passwords do not match")]

        [Display(Name = "Verify Password")]
        [Compare("Password")]
        public string Verify { get; set; }

    }
}
