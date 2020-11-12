using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Submission
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string SerialNumberId { get; set; }
        public SerialNumber SerialNumber { get; set; }
        
    }
}
