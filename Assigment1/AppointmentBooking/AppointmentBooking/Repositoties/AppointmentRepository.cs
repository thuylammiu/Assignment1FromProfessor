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

        public async Task<IList<Appointment>> GetAllAsync()
        {
            var list = await base.GetAll();
            return null;//list.Where(x => x.AppointmentDate > DateOnly.FromDateTime(DateTime.Now));

        }
    }
}
