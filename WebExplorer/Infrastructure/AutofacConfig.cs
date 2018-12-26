using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace WebExplorer.Infrastructure
{
    public static class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }

        private static void ConfigureDependencies(ContainerBuilder builder)
        {
            // TODO register services
            builder.RegisterType<AppDbContext>().AsSelf().InstancePerLifetimeScope();
        }
    }
}