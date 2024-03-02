#nullable disable
using Core.Records.Bases;
using FluentValidation;

namespace Business.Model
{
    public class DocumentModel : Record
    {

        public string Name { get; set; }

        public int AppointmentId { get; set; }

        public string DocumentPath { get; set; }
    }

    public class DocumentModelValidator : AbstractValidator<DocumentModel>
    {
        public DocumentModelValidator()
        {
            RuleFor(DocumentModel => DocumentModel.Id).NotNull();
            RuleFor(DocumentModel => DocumentModel.Name).NotNull();
        }
    }
}
