using Your_Health.Server.Models;

namespace Your_Health.server.DTO
{
    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public bool IsConfirmed { get; set; }

        public DoctorDto doctor { get; set; }
        public PatientDto patient { get; set; }
    }
}
