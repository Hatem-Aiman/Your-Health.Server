using Your_Health.server.DTO;
using Your_Health.Server.Models;
using Microsoft.EntityFrameworkCore;
using Your_Health.Server.Data;

namespace Your_Health.server.Services
{
    public class PatientService : IPatientService
    {
        private readonly AppDbContext _context;

        public PatientService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PatientDto> GetAllPatients()
        {
            var patients = _context.patients.Include(p => p.doctor).Select(p => new PatientDto
            {
                PatientId = p.PatientId,
                PatientName = p.PatientName,
                phone = p.phone,
                IsDiagnosed = p.IsDiagnosed,
                doctor = p.doctor
            }).ToList();

            return patients;
        }

        public PatientDto GetPatientById(int id)
        {
            var patient = _context.patients.Select(p => new PatientDto
            {
                PatientId = p.PatientId,
                PatientName = p.PatientName,
                phone = p.phone,
                IsDiagnosed = p.IsDiagnosed,
                doctor = p.doctor
            }).FirstOrDefault(p => p.PatientId == id);

            if (patient == null)
            {
                return null;
            }

            return patient;
        }

        public void CreatePatient(Patient patient)
        {
            _context.patients.Add(patient);
            _context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            var existingPatient = _context.patients.Find(patient.PatientId);
            if (existingPatient != null)
            {
                existingPatient.PatientName = patient.PatientName;
                existingPatient.phone = patient.phone;
                existingPatient.IsDiagnosed = patient.IsDiagnosed;
                existingPatient.DocId = patient.DocId;
                existingPatient.AppointmentId = patient.AppointmentId;

                _context.patients.Update(existingPatient);
                _context.SaveChanges();
            }
        }

        public void DeletePatient(int id) {
            var Patient = _context.patients.Find(id);
            if (Patient == null)
            {
                return;
            }
            _context.patients.Remove(Patient);
            _context.SaveChanges();
        }
    }
}
