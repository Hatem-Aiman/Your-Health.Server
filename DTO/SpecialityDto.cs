using Your_Health.Server.Models;

namespace Your_Health.server.DTO
{
    public class SpecialityDto
    {
        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; }
        public List<DoctorDto> doctors { get; set; }
    }
}
