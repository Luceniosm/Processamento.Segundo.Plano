using Application.Processo.Interface;
using Hangfire;
using System.Web.Http;

namespace hangfire.Controllers
{
    public class ProcessamentoSegundoPlanoController : ApiController
    {
        protected readonly IProcessamentoSegundoPlanoAppService _processamentoSegundoPlano;

        public ProcessamentoSegundoPlanoController(IProcessamentoSegundoPlanoAppService processamentoSegundoPlano)
        {
            _processamentoSegundoPlano = processamentoSegundoPlano;
        }

        public void Processar()
        {
            BackgroundJob.Enqueue(() => _processamentoSegundoPlano.Processar());
        }
    }
}