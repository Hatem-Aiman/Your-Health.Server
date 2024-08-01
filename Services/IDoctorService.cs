using Your_Health.server.DTO;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorDto>> GetAllDoctors();
        Task<DoctorDto> GetDoctorById(int id);
        void CreateDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        void DeleteDoctor(int id);
    }
}
