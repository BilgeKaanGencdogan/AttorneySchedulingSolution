using Business.Model;
using Core.Repositories.EntityFramework.Bases;
using Core.Results;
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
            if (_lawyerTypeRepository.Query().Any(lawyertypes => lawyertypes.Name.ToLower() == model.Name.ToLower().Trim()))
            {
                return new ErrorResult("Lawyer type with the same name exists!");
            }

            LawyerType lawyerType = new LawyerType()
            {
                Name = model.Name.Trim(),
                Guid = Guid.NewGuid().ToString(),
            };
            _lawyerTypeRepository.Add(lawyerType);
            return new SuccessResult("Lawyer type created successfully");
        }

        public Result Delete(int id)
        {
            LawyerType lawyerType = _lawyerTypeRepository.Query().SingleOrDefault(lawyertypes => lawyertypes.Id == id);
            if (lawyerType is null)
            {
                return new ErrorResult("Lawyer type not found!");
            }
            _lawyerTypeRepository.Delete(lawyertype => lawyertype.Id == id);
            return new SuccessResult("Lawyer type deleted successfully");
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
            if (_lawyerTypeRepository.Query().Any(lawyertypes => lawyertypes.Id != model.Id && lawyertypes.Name.ToLower() == model.Name.ToLower().Trim()))
            {
                return new ErrorResult("Lawyer type with the same name exists!");
            }

            LawyerType lawyerType = _lawyerTypeRepository.Query().SingleOrDefault(lawyertypes => lawyertypes.Id == model.Id);

            if (lawyerType is null)
            {
                return new ErrorResult("Lawyer type not found!");
            }
            lawyerType.Name = model.Name.Trim();
            _lawyerTypeRepository.Update(lawyerType);
            return new SuccessResult("Lawyer type updated successfully.");
        }
    }
}
