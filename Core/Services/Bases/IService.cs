using Core.Records.Bases;
using Core.Results.Bases;

namespace Core.Services.Bases
{
    public interface IService<TModel> : IDisposable where TModel : Record, new()
    {
        IQueryable<TModel> Query();

        Result Add(TModel model);

        Result Update(TModel model);

        Result Delete(int id);

    }
}
