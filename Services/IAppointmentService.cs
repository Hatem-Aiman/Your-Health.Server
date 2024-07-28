using Your_Health.server.DTO;
using Your_Health.Server.Models;

namespace Your_Health.server.Services
{
    public interface IAppointmentService
    {
        IEnumerable<AppointmentDto> GetAllAppointments();
        AppointmentDto GetAppointmentById(int id);
        void CreateAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);
        void DeleteAppointment(int id);
    }
}
