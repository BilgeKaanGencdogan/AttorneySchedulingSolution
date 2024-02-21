using Business.Model;
using DataAccess.Contexts;

namespace Business.Services
{
    public interface ILawyerTypeService
    {
        IQueryable<LawyerTypeModel> Query();
    }
    public class LawyerTypeService : ILawyerTypeService
    {
        private readonly Db _db;

        public LawyerTypeService(Db db)
        {
            _db = db;
        }
        public IQueryable<LawyerTypeModel> Query()
        {
            return _db.LawyerTypes.Select(lawyerTypeEntity => new LawyerTypeModel()
            {
                Guid = lawyerTypeEntity.Guid,
                Id = lawyerTypeEntity.Id,
                Name = lawyerTypeEntity.Name,
            });
        }
    }
}
