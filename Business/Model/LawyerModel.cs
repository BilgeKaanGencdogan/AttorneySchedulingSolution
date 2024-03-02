#nullable disable
using Core.Records.Bases;
using FluentValidation;

namespace Business.Model
{
    public class LawyerModel : Record
    {

        public string Name { get; set; }

        public int? ContactId { get; set; }

        public int LawyerTypeId { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }

    public class LawyerModelValidator : AbstractValidator<LawyerModel>
    {
        public LawyerModelValidator()
        {
            RuleFor(LawyerModel => LawyerModel.Id).NotNull();
            RuleFor(LawyerModel => LawyerModel.Name).NotNull();
            RuleFor(LawyerModel => LawyerModel.Name).Length(100);

        }
    }
}
