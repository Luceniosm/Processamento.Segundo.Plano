using Domain.Cadastro.Entities;
using System;

namespace Domain.Cadastro.Interface.Service
{
    public interface IPessoaService : IDisposable
    {
        void Insert(Pessoa pessoa);
    }
}