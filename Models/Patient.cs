using System.ComponentModel.DataAnnotations;

namespace Your_Health.Server.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int phone { get; set; }
        public Boolean IsDiagnosed { get; set; }
        public int DocId { get; set; }
        public int AppointmentId { get; set; }

        public Doctor doctor { get; set; }
        public Appointment Appointment { get; set; }
    }
}
