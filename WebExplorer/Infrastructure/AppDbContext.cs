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
            Database.SetInitializer(new TempInitializer());
        }


        public virtual DbSet<Folder> Folders { get; set; }
        public virtual DbSet<Alias> Aliases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // self-reference
            modelBuilder.Entity<Folder>().HasOptional(f => f.Parent).WithMany(f => f.Children).HasForeignKey(f => f.ParentId);
        }
    }

    internal class TempInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
    }
}