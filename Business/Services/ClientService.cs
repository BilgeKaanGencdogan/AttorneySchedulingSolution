using Business.Model;
using Core.Repositories.EntityFramework.Bases;
using Core.Results.Bases;
using Core.Services.Bases;
using DataAccess.Entities;

namespace Business.Services
{
    public interface IClientService : IService<ClientModel>
    {
        IQueryable<ClientModel> Query();
    }
    public class ClientService : IClientService
    {
        private readonly RepositoryBase<Client> _clientRepository;

        public ClientService(RepositoryBase<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Result Add(ClientModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _clientRepository.Dispose();
        }

        public IQueryable<ClientModel> Query()
        {
            return _clientRepository.Query().Select(clientEntity => new ClientModel()
            {
                Guid = clientEntity.Guid,
                Id = clientEntity.Id,
                Name = clientEntity.Name,
                DateOfBirth = clientEntity.DateOfBirth,
            });
        }

        public Result Update(ClientModel model)
        {
            throw new NotImplementedException();
        }
    }
}
