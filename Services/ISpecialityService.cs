using Your_Health.server.DTO;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public interface ISpecialityService
    {
        IEnumerable<SpecialityDto> GetAllSpecialities();
        SpecialityDto GetSpecialityById(int id);
        void CreateSpeciality(string SpecialityName);
        void UpdateSpeciality(Speciality speciality);
        void DeleteSpeciality(int id);
    }
}
