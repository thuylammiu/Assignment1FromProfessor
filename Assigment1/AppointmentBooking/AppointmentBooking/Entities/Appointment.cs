using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentBooking.Entities
{
    public class Appointment: BaseEntity
    {

        [Required]
        public DateOnly AppointmentDate { get; set; }

        [Required]
        public TimeOnly AppointmentTime { get; set; }

        public string surgeryLocation { get; set; }

        [ForeignKey(nameof(Dentist))]
        public int DentistId { get; set; }

        [ForeignKey(nameof(PatientId))]
        public int PatientId { get; set; }


        public Dentist Dentist { get; set; }
        public Patient Patient { get; set; }
    }
}


