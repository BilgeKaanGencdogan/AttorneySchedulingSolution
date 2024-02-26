using Business.Model;
using Core.Repositories.EntityFramework.Bases;
using Core.Results.Bases;
using Core.Services.Bases;
using DataAccess.Entities;

namespace Business.Services
{

    public interface IAppointmentService : IService<AppointmentModel>
    {

    }
    public class AppointmentService : IAppointmentService
    {
        private readonly RepositoryBase<Appointment> _AppointmentRepository;

        public AppointmentService(RepositoryBase<Appointment> AppointmentRepository)
        {
            _AppointmentRepository = AppointmentRepository;
        }

        public Result Add(AppointmentModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _AppointmentRepository.Dispose();
        }

        public IQueryable<AppointmentModel> Query()
        {
            return _AppointmentRepository.Query().Select(appointmentEntity => new AppointmentModel()
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

        public Result Update(AppointmentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
