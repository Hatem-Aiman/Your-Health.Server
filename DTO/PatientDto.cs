using Your_Health.Server.Models;

namespace Your_Health.server.DTO
{
    public class PatientDto
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int phone { get; set; }
        public Boolean IsDiagnosed { get; set; }
        public Doctor? doctor { get; set; }
        public Appointment? appointment { get; set; }

    }
}
