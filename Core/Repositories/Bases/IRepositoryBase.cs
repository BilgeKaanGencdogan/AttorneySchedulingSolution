using Core.Records.Bases;
using System.Linq.Expressions;

namespace Core.Repositories.Bases
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : Record, new()
    {
        IQueryable<TEntity> Query();


        void Add(TEntity entity, bool save = true);

        void Update(TEntity entity, bool save = true);

        void Delete(Expression<Func<TEntity, bool>> predicate, bool save = true);

        int Save();
    }
}
