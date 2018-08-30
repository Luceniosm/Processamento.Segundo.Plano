using System;
using Application.Cadastro.Interface;
using AutoMapper;
using Data.Context;
using Data.UnitOfWork;
using Domain.Cadastro.Entities;
using Domain.Cadastro.Interface.Service;
using Dto.Cadastro;

namespace Application.Cadastro.Service
{
    public class PessoaAppService : DbsApplicationService, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaAppService(
             IPessoaService pessoaService,
             IUnitOfWork<DbsContext> uow
            )
            : base(uow)
        {
            _pessoaService = pessoaService;
        }

        public void Insert(DtoPessoa result)
        {
            var map = Mapper.Map<Pessoa>(result);
            BeginTransaction();
            _pessoaService.Insert(map);
            Commit();
        }

        public void Dispose()
        {
            _pessoaService.Dispose();
            GC.SuppressFinalize(true);
        }
    }
}