using Business.Model;
using DataAccess.Contexts;

namespace Business.Services
{
    public interface IClientService
    {
        IQueryable<ClientModel> Query();
    }
    public class ClientService : IClientService
    {
        private readonly Db _db;

        public ClientService(Db db)
        {
            _db = db;
        }
        public IQueryable<ClientModel> Query()
        {
            return _db.Clients.Select(clientEntity => new ClientModel()
            {
                Guid = clientEntity.Guid,
                Id = clientEntity.Id,
                Name = clientEntity.Name,
                ContactId = clientEntity.ContactId,
                DateOfBirth = clientEntity.DateOfBirth,
            });
        }
    }
}
