using System.ComponentModel.DataAnnotations;

namespace Your_Health.Server.Models
{
    public class Doctor
    {
        [Key]
        public int DocId { get; set; }
        public string DocFirstName { get; set; }
        public string DocLastName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public int? SpecialityId { get; set; }

        public Speciality speciality { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
