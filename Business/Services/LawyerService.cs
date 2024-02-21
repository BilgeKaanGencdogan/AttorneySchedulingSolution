using Business.Model;
using DataAccess.Contexts;

namespace Business.Services
{
    public interface ILawyerService
    {
        IQueryable<LawyerModel> Query();
    }
    public class LawyerService : ILawyerService
    {
        private readonly Db _db;

        public LawyerService(Db db)
        {
            _db = db;
        }
        public IQueryable<LawyerModel> Query()
        {
            return _db.Lawyers.Select(lawyerEntity => new LawyerModel()
            {
                Guid = lawyerEntity.Guid,
                Id = lawyerEntity.Id,
                Name = lawyerEntity.Name,
                ContactId = lawyerEntity.ContactId,
                Price = lawyerEntity.Price,
                IsAvailable = lawyerEntity.IsAvailable,
                LawyerTypeId = lawyerEntity.LawyerTypeId

            });
        }
    }
}
