namespace WebExplorer.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext()
            : base("name=AppDatabaseContext")
        {
        }

        public virtual DbSet<Alias> Aliases { get; set; }
        public virtual DbSet<Folder> Folders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Folder>()
                .HasOptional(e => e.Alias)
                .WithRequired(e => e.Folder);

            modelBuilder.Entity<Folder>()
                .HasMany(e => e.Children)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.ParentId);
        }
    }
}
