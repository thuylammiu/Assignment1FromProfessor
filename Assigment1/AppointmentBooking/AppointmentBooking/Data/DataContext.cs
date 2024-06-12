using AppointmentBooking.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Dentist> Dentists { get; set; }

        public DbSet<Patient> Patients { get; set; }

    }
}
