using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDietHealth.Models;

namespace EDietHealth.Services
{
    public class ElderlyService
    {

        // Read from database
        private EDietHealthDbContext _context;
        public ElderlyService(EDietHealthDbContext context)
        {
            _context = context;
        }
        public List<Elderly> GetAllElderlys()
        {
            List<Elderly> AllElderlys = new List<Elderly>();
            AllElderlys = _context.Elderlys.ToList();
            return AllElderlys;
        }



        public Elderly GetElderlyById(String id)
        {
            Elderly elderly = null;
            List<Elderly> AllElderlys = new List<Elderly>();
            AllElderlys = _context.Elderlys.ToList();
            foreach (Elderly item in AllElderlys)
            {
                if (item.Id == id)
                {
                    elderly = item;
                }
            }

            return elderly;
        }

        public bool AddElderly(Elderly newelderly)
        {
            // if elderly exist (return false)
            if (ElderlyExists(newelderly.Id))
            {
                return false;
            }
            // else not exist add (return true)
            _context.Add(newelderly);
            _context.SaveChanges();
            return true;
        }
        private bool ElderlyExists(string id)
        {
            return _context.Elderlys.Any(e => e.Id == id);
        }
    }
}
