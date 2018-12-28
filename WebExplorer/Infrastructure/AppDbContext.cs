using System.Data.Entity;
using WebExplorer.Entities;

//namespace WebExplorer.Infrastructure
//{
//    public class AppDbContext : DbContext
//    {
//        public AppDbContext() : base("name=AppDbContext")
//        {
//            Database.SetInitializer(new TempInitializer());
//
//            if (!Database.Exists()) Database.Initialize(true);
//        }
//
//        public virtual DbSet<Alias> Aliases { get; set; }
//
//
//        public virtual DbSet<Folder> Folders { get; set; }
//
//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            // self-reference
//            modelBuilder.Entity<Folder>().HasOptional(f => f.Parent).WithMany(f => f.Children)
//                .HasForeignKey(f => f.ParentId);
//        }
//    }
//
//    internal class TempInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
//    {
//        protected override void Seed(AppDbContext context)
//        {
//            var root = new Folder
//            {
//                Name = "Creating Digital Images", Alias = new Alias
//                {
//                    Path = "Creating Digital Images"
//                }
//            };
//
//            var resourcesFolder = new Folder
//            {
//                Name = "Resources", Alias = new Alias
//                {
//                    Path = "Creating Digital Images/Resources",
//                }
//            };
//
//            var evidenceFolder = new Folder
//            {
//                Name = "Evidence", Alias = new Alias
//                {
//                    Path = "Creating Digital Images/Evidence",
//                }
//            };
//
//            var graphicProducts = new Folder
//            {
//                Name = "Graphic Products", Alias = new Alias
//                {
//                    Path = "Creating Digital Images/Graphic Products",
//                }
//            };
//
//            root.Children.Add(resourcesFolder);
//            root.Children.Add(evidenceFolder);
//            root.Children.Add(graphicProducts);
//
//            var primarySourcesFolder = new Folder
//            {
//                Name = "Primary Sources", Alias = new Alias
//                {
//                    Path = "Creating Digital Images/Resources/Primary Sources"
//                }
//            };
//
//            var secondarySourcesFolder = new Folder
//            {
//                Name = "Secondary Sources", Alias = new Alias
//                {
//                    Path = "Creating Digital Images/Resources/Secondary Sources",
//                }
//            };
//
//            resourcesFolder.Children.Add(primarySourcesFolder);
//            resourcesFolder.Children.Add(secondarySourcesFolder);
//
//            var processFolder = new Folder
//            {
//                Name = "Process", Alias = new Alias
//                {
//                    Path = "Creating Digital Images/Graphic Products/Process",
//                }
//            };
//            var finalProductFolder = new Folder
//            {
//                Name = "Final Product", Alias = new Alias
//                {
//                    Path = "Creating Digital Images/Graphic Products/Final Product",
//                }
//            };
//
//            graphicProducts.Children.Add(processFolder);
//            graphicProducts.Children.Add(finalProductFolder);
//
//            context.Folders.Add(root);
//
////            context.Aliases.AddRange(new[]
////            {
////                new Alias
////                {
////                    Path = "Creating Digital Images",
////                    Folder = root
////                },
////
////                new Alias
////                {
////                    Path = "Creating Digital Images/Resources",
////                    Folder = resourcesFolder
////                },
////                new Alias
////                {
////                    Path = "Creating Digital Images/Evidence",
////                    Folder = evidenceFolder
////                },
////                new Alias
////                {
////                    Path = "Creating Digital Images/Graphic Products",
////                    Folder = graphicProducts
////                },
////
////                new Alias
////                {
////                    Path = "Creating Digital Images/Primary Sources",
////                    Folder = primarySourcesFolder
////                },
////                new Alias
////                {
////                    Path = "Creating Digital Images/Secondary Sources",
////                    Folder = secondarySourcesFolder
////                },
////
////                new Alias
////                {
////                    Path = "Creating Digital Images/Process",
////                    Folder = processFolder
////                },
////                new Alias
////                {
////                    Path = "Creating Digital Images/Final Product",
////                    Folder = finalProductFolder
////                }
////            });
//
//            base.Seed(context);
//        }
//    }
//}