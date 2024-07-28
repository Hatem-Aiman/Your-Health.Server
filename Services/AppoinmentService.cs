using Microsoft.EntityFrameworkCore;
using Your_Health.server.DTO;
using Your_Health.Server.Data;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public class AppoinmentService : IAppointmentService
    {
        private readonly AppDbContext _context;
        public AppoinmentService(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<AppointmentDto> GetAllAppointments()
        {
            var appointments = _context.appointments.Include(d => d.doctor).Include(p => p.patient).Select(a => new AppointmentDto
            {
                AppointmentId = a.AppointmentId,
                Date = a.Date,
                Description = a.Description,
                doctor = new DoctorDto
                {
                    DocId = a.doctor.DocId,
                    DocFirstName = a.doctor.DocFirstName,
                    DocLastName = a.doctor.DocLastName,
                    Phone = a.doctor.phone,
                    Email = a.doctor.email,
                    SpecialityName = a.doctor.speciality.SpecialityName
                },
                patient = new PatientDto
                {
                    PatientId = a.patient.PatientId,
                    PatientName = a.patient.PatientName,
                    phone = a.patient.phone,
                    IsDiagnosed = a.patient.IsDiagnosed,
                }

            }).ToList();
            return appointments;
        }

        public AppointmentDto GetAppointmentById(int id)
        {
            var appointment = _context.appointments.Include(d => d.doctor).Include(p => p.patient).Select(a => new AppointmentDto
            {
                AppointmentId = a.AppointmentId,
                Date = a.Date,
                Description = a.Description,
                doctor = new DoctorDto
                {
                    DocId = a.doctor.DocId,
                    DocFirstName = a.doctor.DocFirstName,
                    DocLastName = a.doctor.DocLastName,
                    Phone = a.doctor.phone,
                    Email = a.doctor.email,
                    SpecialityName = a.doctor.speciality.SpecialityName
                },
                patient = new PatientDto
                {
                    PatientId = a.patient.PatientId,
                    PatientName = a.patient.PatientName,
                    phone = a.patient.phone,
                    IsDiagnosed = a.patient.IsDiagnosed,
                }
                
            }).FirstOrDefault(a => a.AppointmentId == id);
            return appointment;
        }

        public void CreateAppointment(Appointment appointment)
        {
            _context.appointments.Add(appointment);
            _context.SaveChanges();
        }

        public void UpdateAppointment(Appointment appointment)
        {
            var existingAppointment = _context.appointments.Find(appointment.AppointmentId);
            if (existingAppointment != null)
            {
                existingAppointment.Date = appointment.Date;
                existingAppointment.Description = appointment.Description;
                existingAppointment.doctor = appointment.doctor;
                existingAppointment.patient = appointment.patient;
                _context.appointments.Update(existingAppointment);
                _context.SaveChanges();
            }
        }


        public void DeleteAppointment(int id)
        {
            var appointment = _context.appointments.Find(id);
            if (appointment != null)
            {
                _context.appointments.Remove(appointment);
                _context.SaveChanges();
            }
        }



 




    }
}
