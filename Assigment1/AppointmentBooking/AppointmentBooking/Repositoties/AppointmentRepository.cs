using AppointmentBooking.Data;
using AppointmentBooking.Entities;
using AppointmentBooking.Interfaces;

namespace AppointmentBooking.Repositoties
{
    public class AppointmentRepository : Repositoty<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(DataContext dataContext) : base(dataContext)
        {
        }

        
    }
}
