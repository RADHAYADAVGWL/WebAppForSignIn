using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebAppForSignIn.Attributes;

namespace WebAppForSignIn.Areas.User.Models
{
    public class Registration
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password contain  1 capital latter,1 Number,1 Special char and One LowerCase")]
        
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression("^[6789]\\d{9}$",ErrorMessage ="Enter Correct Contact")]
        public string Contact { get; set; }

        [Required]
        public GenderType Gender { get; set; }
       
        [ValidationCheckBox(ErrorMessage = "Please Accept Term")]
        public bool AcceptTerm { get; set; }



    }
}
