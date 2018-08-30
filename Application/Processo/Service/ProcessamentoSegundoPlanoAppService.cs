using System;
using System.Threading;
using Application.Processo.Interface;
using Data.Context;
using Data.UnitOfWork;

namespace Application.Processo.Service
{
    public class ProcessamentoSegundoPlanoAppService : DbsApplicationService, IProcessamentoSegundoPlanoAppService
    {
        public ProcessamentoSegundoPlanoAppService(IUnitOfWork<DbsContext> uow)
            : base(uow)
        {
        }

        public void Processar()
        {
            Thread.Sleep(1000);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}