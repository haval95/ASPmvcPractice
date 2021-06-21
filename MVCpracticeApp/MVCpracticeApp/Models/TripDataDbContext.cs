using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace MVCpracticeApp.Models
{
    public class TripDataDbContext: DbContext
    {

        public TripDataDbContext(DbContextOptions<TripDataDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Trip> Trips { get; set; }

       
    }
}
