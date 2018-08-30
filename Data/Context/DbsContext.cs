using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Context
{
    public class DbsContext : DbContext
    {
        public static DbConnection GetConnection()
        {
            var sqlConnFactory = new SqlConnectionFactory();
            var sqlConn = sqlConnFactory.CreateConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            return sqlConn;
        }

        public DbsContext()
            : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {
            System.Data.Entity.Database.SetInitializer<DbsContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}