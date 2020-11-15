using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Application.ViewModels
{
    public class GetListSubmissionsViewModel
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Surname")]
        public string SurName { get; set; }
        [DisplayName("Email address")]
        public string Email { get; set; }
        [DisplayName("Age")]
        public int Age { get; set; }
        [DisplayName("Serial number")]
        public int SerialNumber { get; set; }
    }
}
