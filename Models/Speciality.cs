using System.ComponentModel.DataAnnotations;

namespace Your_Health.Server.Models
{
    public class Speciality
    {
        [Key]
        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; } = string.Empty;

        public ICollection<Doctor> Doctors { get; set; }
    }
}
