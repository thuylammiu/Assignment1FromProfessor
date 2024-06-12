using AppointmentBooking.Data;
using AppointmentBooking.Entities;
using AppointmentBooking.Interfaces;

namespace AppointmentBooking.Repositoties
{
    public class PatientRepository : Repositoty<Patient>, IPatientRepository
    {
        public PatientRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
