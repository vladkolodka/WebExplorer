using WebExplorer.Entities;

namespace WebExplorer.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
        }

        public virtual DbSet<Test> Tests { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}