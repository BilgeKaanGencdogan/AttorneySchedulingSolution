using Business.Model;
using DataAccess.Contexts;

namespace Business.Services
{
    public interface IDocumentService
    {
        IQueryable<DocumentModel> Query();
    }
    public class DocumentService : IDocumentService
    {
        private readonly Db _db;

        public DocumentService(Db db)
        {
            _db = db;
        }
        public IQueryable<DocumentModel> Query()
        {
            return _db.Documents.Select(documentEntity => new DocumentModel()
            {
                Guid = documentEntity.Guid,
                Id = documentEntity.Id,
                Name = documentEntity.Name,
                AppointmentId = documentEntity.AppointmentId,
                DocumentPath = documentEntity.DocumentPath,
            });
        }
    }
}
