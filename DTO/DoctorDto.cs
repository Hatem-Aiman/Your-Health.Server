using Your_Health.Server.Models;

namespace Your_Health.server.DTO
{
    public class DoctorDto
    {
        public int DocId { get; set; }
        public string? DocFirstName { get; set; }
        public string? DocLastName { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public string? SpecialityName { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
