using AppointmentBooking.Entities;

namespace AppointmentBooking.Interfaces
{
    public interface IAppointmentRepository: IRepository<Appointment>
    {
        Task<IList<Appointment>> GetAllAsync();
    }
}
