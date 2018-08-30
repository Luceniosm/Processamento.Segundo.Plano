using Data.Context;
using Data.UnitOfWork;

namespace Application
{
    public class DbsApplicationService
    {
        private readonly IUnitOfWork<DbsContext> _uow;

        public DbsApplicationService(IUnitOfWork<DbsContext> uow)
        {
            _uow = uow;
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.Commit();
        }

        public void CommitAsync()
        {
            _uow.CommitAsync();
        }
    }
}