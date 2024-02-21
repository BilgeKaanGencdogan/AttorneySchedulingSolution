using Business.Model;
using DataAccess.Contexts;

namespace Business.Services
{

    public interface IAppointmentService
    {
        IQueryable<AppointmentModel> Query();
    }
    public class AppointmentService : IAppointmentService
    {
        private readonly Db _db;

        public AppointmentService(Db db)
        {
            _db = db;
        }
        public IQueryable<AppointmentModel> Query()
        {
            return _db.Appointments.Select(appointmentEntity => new AppointmentModel()
            {
                Guid = appointmentEntity.Guid,
                Id = appointmentEntity.Id,
                Description = appointmentEntity.Description,
                ClientId = appointmentEntity.ClientId,
                LawyerId = appointmentEntity.LawyerId,
                StartDateOfAppointment = appointmentEntity.StartDateOfAppointment,
                EndDateOfAppointment = appointmentEntity.EndDateOfAppointment,
                Status = appointmentEntity.Status
            });
        }
    }
}
