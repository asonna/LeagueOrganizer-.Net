using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeagueOrganizer.Models
{
    public class LeagueOrgDbContext: DbContext
    {
        public LeagueOrgDbContext()
        {
        }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=LeagueOrganizer;integrated security=True");
        }

        public LeagueOrgDbContext(DbContextOptions<LeagueOrgDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
