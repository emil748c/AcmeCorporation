using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Submission
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int SerialNumber { get; set; }


    }
}
