using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using WebExplorer.Services;
using WebExplorer.Services.Implementation;

namespace WebExplorer.Infrastructure
{
    public static class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            ConfigureDependencies(builder);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }

        private static void ConfigureDependencies(ContainerBuilder builder)
        {
            // TODO register services
            builder.RegisterType<AppDbContext>().AsSelf().InstancePerLifetimeScope();
 
            builder.RegisterType<FolderService>().As<IFolderService>();
        }
    }
}