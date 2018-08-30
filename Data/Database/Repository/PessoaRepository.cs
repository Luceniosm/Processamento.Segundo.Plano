using Data.Context;
using Data.Repositories;
using Domain.Cadastro.Entities;
using Domain.Cadastro.Interface.Repository;

namespace Data.Database.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        private readonly DbsContext _context;

        public PessoaRepository(DbsContext context)
            : base(context)
        {
            _context = (_context ?? context);
        }
    }
}