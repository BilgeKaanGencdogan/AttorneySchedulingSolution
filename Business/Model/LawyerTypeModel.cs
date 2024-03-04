#nullable disable
using Core.Records.Bases;
using FluentValidation;

namespace Business.Model
{
    public class LawyerTypeModel : Record
    {
        public string Name { get; set; }
    }

    public class LawyerTypeModelValidator : AbstractValidator<LawyerTypeModel>
    {
        public LawyerTypeModelValidator()
        {
            RuleFor(LawyerTypeModel => LawyerTypeModel.Id).NotNull();
            RuleFor(LawyerTypeModel => LawyerTypeModel.Name).NotNull().WithName("Lawyer type name");

        }
    }
}
