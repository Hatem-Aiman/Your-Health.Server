using Your_Health.server.DTO;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public interface IPatientService
    {
        Task<PatientDto> GetPatientById(int id);
        Task<IEnumerable<PatientDto>> GetAllPatients();
        void CreatePatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(int id);
    }
}
