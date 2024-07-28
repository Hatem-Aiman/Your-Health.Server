using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Your_Health.server.DTO;
using Your_Health.Server.Data;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public class SpecialityService : ISpecialityService
    {
        private readonly AppDbContext _context;

        public SpecialityService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SpecialityDto> GetAllSpecialities() {


                var specialities = _context.Specialities
                    .Include(s => s.Doctors) // Include the Doctors navigation property
                    .Select(s => new SpecialityDto
                    {
                        SpecialityId = s.SpecialityId,
                        SpecialityName = s.SpecialityName,
                        doctors = s.Doctors.Select(e => new DoctorDto
                        {
                            DocId = e.DocId,
                            DocFirstName = e.DocFirstName,
                            DocLastName = e.DocLastName,
                            Email = e.email,
                            Phone = e.phone
                        }).ToList()
                    })
                    .ToList();

                return specialities;
            }
        

        public SpecialityDto GetSpecialityById(int id)
        {
            var speciality = _context.Specialities
                .Include(s => s.Doctors) 
                .Where(s => s.SpecialityId == id) 
                .Select(s => new SpecialityDto
                {
                    SpecialityId = s.SpecialityId,
                    SpecialityName = s.SpecialityName,
                    doctors = s.Doctors.Select(e => new DoctorDto
                    {
                        DocId = e.DocId,
                        DocFirstName = e.DocFirstName,
                        DocLastName = e.DocLastName,
                        Email = e.email,
                        Phone = e.phone
                    }).ToList()
                })
                .FirstOrDefault();

            return speciality;

        }

        public void CreateSpeciality(Speciality speciality)
        {
            _context.Specialities.Add(speciality);
            _context.SaveChanges();
        }

        public void UpdateSpeciality(Speciality speciality)
        {
            var existingSpeciality = _context.Specialities.Find(speciality.SpecialityId);
            if (existingSpeciality != null)
            {
                existingSpeciality.SpecialityName = speciality.SpecialityName;
                _context.Specialities.Update(existingSpeciality);
                _context.SaveChanges();
            }
        }
        public void DeleteSpeciality(int id)
        {
            var speciality = _context.Specialities.Find(id);
            if (speciality == null)
            {
                return;
            }
            _context.Specialities.Remove(speciality);
            _context.SaveChanges();
        }
    }
}
