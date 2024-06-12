using AppointmentBooking.Data;
using AppointmentBooking.Entities;
using AppointmentBooking.Interfaces;

namespace AppointmentBooking.Repositoties
{
    public class DentistRepository : Repositoty<Dentist>, IDentisRepository
    {
        public DentistRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
