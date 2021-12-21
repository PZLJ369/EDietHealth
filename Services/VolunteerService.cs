using EDietHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDietHealth.Services
{
    public class VolunteerService
    {
        // Read from database
        private EDietHealthDbContext _context;
        public VolunteerService(EDietHealthDbContext context)
        {
            _context = context;
        }
        public List<Volunteer> GetAllVolunteers()
        {
            List<Volunteer> AllVolunteers = new List<Volunteer>();
            AllVolunteers = _context.Volunteers.ToList();
            return AllVolunteers;
        }



        public Volunteer GetVolunteerById(String id)
        {
            Volunteer volunteer = null;
            return volunteer;
        }

        public bool AddVolunteer(Volunteer newvolunteer)
        {
            // if volunteer exist (return false)
            if (VolunteerExists(newvolunteer.Id))
            {
                return false;
            }
            // else not exist add (return true)
            _context.Add(newvolunteer);
            _context.SaveChanges();
            return true;
        }
        private bool VolunteerExists(string id)
        {
            return _context.Volunteers.Any(e => e.Id == id);
        }
    }
}
