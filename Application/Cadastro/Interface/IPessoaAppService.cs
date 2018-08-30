using System;
using Domain.Cadastro.Entities;
using Dto.Cadastro;

namespace Application.Cadastro.Interface
{
    public interface IPessoaAppService : IDisposable
    {
        void Insert(DtoPessoa result);
    }
}