using AppointmentBooking.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentBooking.Dtos
{
    public class AppointmentDto
    {
       
        public int Id { get; set; }
        public DateOnly AppointmentDate { get; set; }

        
        public TimeOnly AppointmentTime { get; set; }

        public string surgeryLocation { get; set; }

        public Person Dentist { get; set; }
        public Person Patient { get; set; }

        public int DentistId { get; set; }
       
        public int PatientId { get; set; }
    }
}
