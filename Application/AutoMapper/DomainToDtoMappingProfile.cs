using AutoMapper;
using Domain.Cadastro.Entities;
using Dto.Cadastro;

namespace Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Pessoa, DtoPessoa>();
        }
    }
}