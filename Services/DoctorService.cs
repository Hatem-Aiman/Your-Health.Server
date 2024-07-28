using Microsoft.EntityFrameworkCore;
using Your_Health.server.DTO;
using Your_Health.Server.Data;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly AppDbContext _context;

        public DoctorService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DoctorDto> GetAllDoctors()
        {
            var doctors = _context.doctors.Include(d => d.speciality).Select(d => new DoctorDto
            {
                DocId = d.DocId,
                DocFirstName = d.DocFirstName,
                DocLastName = d.DocLastName,
                Email = d.email,
                Phone = d.phone,
                SpecialityName = d.speciality.SpecialityName
            }).ToList();

            return doctors;
        }

        public DoctorDto GetDoctorById(int id)
        {
            var doctor =_context.doctors.Include(d => d.speciality).Select(d => new DoctorDto
            {
               DocId = d.DocId,
               DocFirstName = d.DocFirstName,
               DocLastName = d.DocLastName,
               Email = d.email,
               Phone = d.phone,
               SpecialityName = d.speciality.SpecialityName


            }).FirstOrDefault(d => d.DocId == id);

            if (doctor == null)
            {
                return null;
            }

            return doctor;
        }

        public void CreateDoctor(Doctor doctor)
        {
            _context.doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            var existingDoctor = _context.doctors.Find(doctor.DocId);
            if (existingDoctor != null)
            {
                existingDoctor.DocFirstName = doctor.DocFirstName;
                existingDoctor.DocLastName = doctor.DocLastName;
                existingDoctor.email = doctor.email;
                existingDoctor.phone = doctor.phone;
                existingDoctor.SpecialityId = doctor.SpecialityId;
                _context.SaveChanges();
            }
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _context.doctors.Find(id);
            if (doctor != null)
            {
                _context.doctors.Remove(doctor);
                _context.SaveChanges();
            }
        }
    }

}
