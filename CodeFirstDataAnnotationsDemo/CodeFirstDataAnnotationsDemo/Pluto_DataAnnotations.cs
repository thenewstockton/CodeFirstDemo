namespace CodeFirstDataAnnotationsDemo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Pluto_DataAnnotations : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        // Your context has been configured to use a 'Pluto_DataAnnotations' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstDataAnnotationsDemo.Pluto_DataAnnotations' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Pluto_DataAnnotations' 
        // connection string in the application configuration file.
        public Pluto_DataAnnotations()
            : base("name=Pluto_DataAnnotations")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}