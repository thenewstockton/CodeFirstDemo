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

        public VidzyContext()
            : base("name=DefaultConnection")
        {
        }
    }
}
