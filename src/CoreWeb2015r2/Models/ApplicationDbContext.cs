using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb2015r2.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Conference> Conferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./demo.db");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
