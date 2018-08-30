using System;

namespace Application.Processo.Interface
{
    public interface IProcessamentoSegundoPlanoAppService : IDisposable
    {
        void Processar();
    }
}