using System.ComponentModel.DataAnnotations;

namespace AppointmentBooking.Entities
{
    public class Person: BaseEntity
    {
        [Required]
        public string PatientNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]

        public DateOnly DateOfBirth { get; set; }
    }
}


