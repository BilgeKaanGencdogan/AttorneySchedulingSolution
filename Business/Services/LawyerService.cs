using Business.Model;
using Core.Repositories.EntityFramework.Bases;
using Core.Results.Bases;
using Core.Services.Bases;
using DataAccess.Entities;

namespace Business.Services
{
    public interface ILawyerService : IService<LawyerModel>
    {
        IQueryable<LawyerModel> Query();
    }
    public class LawyerService : ILawyerService
    {
        private readonly RepositoryBase<Lawyer> _lawyerRepository;

        public LawyerService(RepositoryBase<Lawyer> lawyerRepository)
        {
            _lawyerRepository = lawyerRepository;
        }

        public Result Add(LawyerModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _lawyerRepository.Dispose();
        }

        public IQueryable<LawyerModel> Query()
        {
            return _lawyerRepository.Query().Select(lawyerEntity => new LawyerModel()
            {
                Guid = lawyerEntity.Guid,
                Id = lawyerEntity.Id,
                Name = lawyerEntity.Name,
                Price = lawyerEntity.Price,
                IsAvailable = lawyerEntity.IsAvailable,
                LawyerTypeId = lawyerEntity.LawyerTypeId

            });
        }

        public Result Update(LawyerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
