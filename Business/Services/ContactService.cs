using Business.Model;
using DataAccess.Contexts;

namespace Business.Services
{
    public interface IContactService
    {
        IQueryable<ContactModel> Query();
    }
    public class ContactService : IContactService
    {
        private readonly Db _db;

        public ContactService(Db db)
        {
            _db = db;
        }
        public IQueryable<ContactModel> Query()
        {
            return _db.Contacts.Select(contactEntity => new ContactModel()
            {
                Guid = contactEntity.Guid,
                Id = contactEntity.Id,
                Address = contactEntity.Address,
                TelephoneNumber = contactEntity.TelephoneNumber,
            });
        }
    }
}
