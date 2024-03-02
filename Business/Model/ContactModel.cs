#nullable disable
using Core.Records.Bases;
using FluentValidation;

namespace Business.Model
{
    public class ContactModel : Record
    {

        public string TelephoneNumber { get; set; }


        public string Address { get; set; }
    }

    public class ContactModelValidator : AbstractValidator<ContactModel>
    {
        public ContactModelValidator()
        {
            RuleFor(ContactModel => ContactModel.Id).NotNull();
            RuleFor(ContactModel => ContactModel.TelephoneNumber).NotNull();
            RuleFor(ContactModel => ContactModel.Address).NotNull();

        }
    }
}
