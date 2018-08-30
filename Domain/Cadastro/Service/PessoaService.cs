using System;
using Domain.Cadastro.Entities;
using Domain.Cadastro.Interface.Repository;
using Domain.Cadastro.Interface.Service;

namespace Domain.Cadastro.Service
{
    public class PessoaService : IPessoaService
    {
        protected readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void Insert(Pessoa pessoa)
        {
            _pessoaRepository.Insert(pessoa);
        }

        public void Dispose()
        {
            _pessoaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}