using CodeFirstExercises.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExercises
{
    public class VidzyContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Video> Videos { get; set; }

        public VidzyContext() : base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>().Property(v => v.Name).IsRequired().HasMaxLength(255);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
