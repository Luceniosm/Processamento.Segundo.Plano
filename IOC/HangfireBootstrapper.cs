using Application.Processo.Interface;
using Application.Processo.Service;
using Data.Context;
using Data.UnitOfWork;
using SimpleInjector;

namespace IOC
{
    public class HangfireBootstrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register(typeof(IUnitOfWork<>), typeof(UnitOfWork<>), Lifestyle.Singleton);

            container.Register<IProcessamentoSegundoPlanoAppService, ProcessamentoSegundoPlanoAppService>(Lifestyle.Singleton);

            container.Register<DbsContext>(Lifestyle.Singleton);
        }
    }
}