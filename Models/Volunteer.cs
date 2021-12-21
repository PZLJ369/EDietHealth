using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Id, NRIC, Name, Password, Gender, BirthDate, Mobile, Job, Hospital

namespace EDietHealth.Models
{
    public class Volunteer
    {
        public string Id { get; set; }
        public string NRIC { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mobile { get; set; }
        public string Job { get; set; }
        public string Hospital { get; set; }
        public string Email { get; set; }
    }
}
