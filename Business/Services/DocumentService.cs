using Business.Model;
using Core.Repositories.EntityFramework.Bases;
using Core.Results.Bases;
using Core.Services.Bases;
using DataAccess.Entities;

namespace Business.Services
{
    public interface IDocumentService : IService<DocumentModel>
    {
        IQueryable<DocumentModel> Query();
    }
    public class DocumentService : IDocumentService
    {
        private readonly RepositoryBase<Document> _documentRepository;

        public DocumentService(RepositoryBase<Document> documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public Result Add(DocumentModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _documentRepository.Dispose();
        }

        public IQueryable<DocumentModel> Query()
        {
            return _documentRepository.Query().Select(documentEntity => new DocumentModel()
            {
                Guid = documentEntity.Guid,
                Id = documentEntity.Id,
                Name = documentEntity.Name,
                AppointmentId = documentEntity.AppointmentId,
                DocumentPath = documentEntity.DocumentPath,
            });
        }

        public Result Update(DocumentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
