using Business.Model;
using Core.Repositories.EntityFramework.Bases;
using Core.Results.Bases;
using Core.Services.Bases;
using DataAccess.Entities;

namespace Business.Services
{
    public interface IContactService : IService<ContactModel>
    {
        IQueryable<ContactModel> Query();
    }
    public class ContactService : IContactService
    {
        private readonly RepositoryBase<Contact> _contactRepository;

        public ContactService(RepositoryBase<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Result Add(ContactModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _contactRepository.Dispose();
        }

        public IQueryable<ContactModel> Query()
        {
            return _contactRepository.Query().Select(contactEntity => new ContactModel()
            {
                Guid = contactEntity.Guid,
                Id = contactEntity.Id,
                Address = contactEntity.Address,
                TelephoneNumber = contactEntity.TelephoneNumber,
            });
        }

        public Result Update(ContactModel model)
        {
            throw new NotImplementedException();
        }
    }
}
