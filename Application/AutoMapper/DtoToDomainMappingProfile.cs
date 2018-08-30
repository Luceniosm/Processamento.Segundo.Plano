using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Cadastro.Entities;
using Dto.Cadastro;

namespace Application.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<DtoPessoa, Pessoa>();
        }
    }
}