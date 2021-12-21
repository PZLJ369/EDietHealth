using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDietHealth.Models
{
    public class EDietHealthDbContext: DbContext
    {

        // inject Iconfiguration to access appsettings.json
        private readonly IConfiguration _config;
        public EDietHealthDbContext(IConfiguration configuration)
        {
            _config = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connect from "MyConn" in appsettings. Configure & Connect to sql server db.
            string connectionString = _config.GetConnectionString("MyConn");
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Map Volunteer entity to Volunteers table in database
        public DbSet<Elderly> Elderlys { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}
