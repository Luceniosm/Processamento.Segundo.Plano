using Application.Cadastro.Interface;
using Application.Cadastro.Service;
using Application.Processo.Interface;
using Application.Processo.Service;
using Data.Context;
using Data.Database.Repository;
using Domain.Cadastro.Interface.Repository;
using Domain.Cadastro.Interface.Service;
using Domain.Cadastro.Service;
using SimpleInjector;

namespace IOC
{
    public class DbBootstrapper
    {
        public static void RegisterServices(Container container)
        {
            #region Application

            container.Register<IPessoaAppService, PessoaAppService>(Lifestyle.Scoped);
            container.Register<IProcessamentoSegundoPlanoAppService, ProcessamentoSegundoPlanoAppService>(Lifestyle.Scoped);

            #endregion Application

            #region Domain

            container.Register<IPessoaService, PessoaService>(Lifestyle.Scoped);

            #endregion Domain

            #region Infra

            container.Register<IPessoaRepository, PessoaRepository>(Lifestyle.Scoped);

            #endregion Infra

            container.Register<DbsContext>(Lifestyle.Scoped);
        }
    }
}