[assembly: WebActivator.PostApplicationStartMethod(typeof(hangfire.SimpleInjectorWebApiInitializer), "Initialize")]

namespace hangfire
{
    using System.Web.Http;
    using IOC;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;

    public static class SimpleInjectorWebApiInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
            DbBootstrapper.RegisterServices(container);
        }
    }
}