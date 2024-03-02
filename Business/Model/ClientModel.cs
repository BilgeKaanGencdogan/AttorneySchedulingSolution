#nullable disable
using Core.Records.Bases;
using FluentValidation;

namespace Business.Model
{
    public class ClientModel : Record
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int? ContactId { get; set; }
    }

    public class ClientModelValidator : AbstractValidator<ClientModel>
    {
        public ClientModelValidator()
        {
            RuleFor(ClientModel => ClientModel.Id).NotNull();
            RuleFor(ClientModel => ClientModel.Name).NotNull();
            RuleFor(ClientModel => ClientModel.Name).Length(100);

        }
    }
}
