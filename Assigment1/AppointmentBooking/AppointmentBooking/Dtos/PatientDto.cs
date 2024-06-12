using System.ComponentModel.DataAnnotations;

namespace AppointmentBooking.Dtos
{
    public class PatientDto
    {
        public int Id { get; set; }
        public string PatientNumber { get; set; }
     
        public string FirstName { get; set; }
      
        public string LastName { get; set; }

      

        public DateOnly DateOfBirth { get; set; }
    }
}
