using Core.Records.Bases;
using Core.Repositories.EntityFramework.Bases;
using DataAccess.Contexts;

namespace DataAccess.Repositories
{
    public class Repository<TEntity> : RepositoryBase<TEntity> where TEntity : Record, new()
    {
        public Repository(Db dbContext) : base(dbContext)
        {
        }
    }
}
