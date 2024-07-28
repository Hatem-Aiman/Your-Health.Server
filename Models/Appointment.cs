using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Your_Health.Server.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public bool IsConfirmed { get; set; }

        public int DocId { get; set; }
        public int PatientId { get; set; }
        public Doctor doctor { get; set; }
        public Patient patient { get; set; }
    }
}
