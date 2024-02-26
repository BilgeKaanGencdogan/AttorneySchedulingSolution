using Business.Model;
using Core.Repositories.EntityFramework.Bases;
using Core.Results.Bases;
using Core.Services.Bases;
using DataAccess.Entities;

namespace Business.Services
{
    public interface ILawyerTypeService : IService<LawyerTypeModel>
    {
        IQueryable<LawyerTypeModel> Query();
    }
    public class LawyerTypeService : ILawyerTypeService
    {
        private readonly RepositoryBase<LawyerType> _lawyerTypeRepository;

        public LawyerTypeService(RepositoryBase<LawyerType> lawyerTypeRepository)
        {
            _lawyerTypeRepository = lawyerTypeRepository;
        }

        public Result Add(LawyerTypeModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _lawyerTypeRepository.Dispose();
        }

        public IQueryable<LawyerTypeModel> Query()
        {
            return _lawyerTypeRepository.Query().Select(lawyerTypeEntity => new LawyerTypeModel()
            {
                Guid = lawyerTypeEntity.Guid,
                Id = lawyerTypeEntity.Id,
                Name = lawyerTypeEntity.Name,
            });
        }

        public Result Update(LawyerTypeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
