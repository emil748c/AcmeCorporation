using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.ViewModels
{
    public class CreateSubmissionViewModel
    {
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "First name must be alphabetic letters a-z")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Surname must be alphabetic letters a-z")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Serial number is required")]
        [RegularExpression(@"^\d{6}$", ErrorMessage ="Serial number must be 6 digits")]
        public int SerialNumber { get; set; }
    }
}
