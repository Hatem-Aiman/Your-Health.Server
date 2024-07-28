using Your_Health.server.DTO;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public interface IPatientService
    {
        PatientDto GetPatientById(int id);
        IEnumerable<PatientDto> GetAllPatients();
        void CreatePatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(int id);
    }
}
