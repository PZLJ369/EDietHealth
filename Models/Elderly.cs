using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDietHealth.Models
{
    public class Elderly
    {
        public string Id { get; set; }
        public string NRIC { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mobile { get; set; }
        public int Point { get; set; }
        public string Email { get; set; }
    }
}


