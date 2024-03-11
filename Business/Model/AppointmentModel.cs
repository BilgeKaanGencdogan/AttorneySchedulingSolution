#nullable disable
using Core.Records.Bases;
using DataAccess.Enums;
using FluentValidation;

namespace Business.Model
{
    public class AppointmentModel : Record
    {

        public string Description { get; set; }

        public int LawyerId { get; set; }

        public int ClientId { get; set; }

        public DateTime StartDateOfAppointment { get; set; }

        public DateTime? EndDateOfAppointment { get; set; }

        public Statuses Status { get; set; }
    }

    public class AppointmentModelValidator : AbstractValidator<AppointmentModel>
    {
        public AppointmentModelValidator()
        {
            RuleFor(AppointmentModel => AppointmentModel.Id).NotNull();
            RuleFor(AppointmentModel => AppointmentModel.Description).NotNull();
        }
    }
}
