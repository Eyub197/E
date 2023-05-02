using Microsoft.EntityFrameworkCore;
using SkateboardsProject.Data.Model;
using SkateboardsProject.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Model
{
   public class SkateboardsContext:DbContext
    {
        
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
        public DbSet<Bearing> Bearings { get; set; }
        public DbSet<Skateboard> Skateboards { get; set;  }

        public SkateboardsContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SkateBoardss;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
