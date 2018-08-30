using Hangfire;
using Hangfire.Dashboard;
using Hangfire.SimpleInjector;
using Hangfire.SqlServer;
using NLog;
using Owin;
using SimpleInjector;
using System;
using System.Configuration;
using IOC;

namespace hangfire
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var _logger = LogManager.GetCurrentClassLogger();

            var container = new Container();
            HangfireBootstrapper.RegisterServices(container);

            GlobalConfiguration
                .Configuration
                .UseSqlServerStorage(
                        ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString,
                        new SqlServerStorageOptions { QueuePollInterval = TimeSpan.FromSeconds(1) }
                    )
                .UseActivator(new SimpleInjectorJobActivator(container));

            var options = new DashboardOptions
            {
                AuthorizationFilters = new[]
                {
                    new LocalRequestsOnlyAuthorizationFilter()
                }
            };
            try
            {
                app.UseHangfireDashboard("/hangfire", options);
                app.UseHangfireServer();
                _logger.Info("hangfire inciado");
            }
            catch (Exception ex)
            {
                _logger.Error("erro ao inicializar o  hangfire:" + ex);
            }
        }
    }
}