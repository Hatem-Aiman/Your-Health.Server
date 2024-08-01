using Microsoft.AspNetCore.Mvc;
using Your_Health.server.Services;
using Your_Health.server.DTO;
using Your_Health.Server.Models;
using System.Numerics;

namespace Your_Health.server.Controllers
{
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PatientDto>> GetPatients()
        {
            var patients = _patientService.GetAllPatients();
            return Ok(patients);
        }

        [HttpGet]
        public ActionResult<PatientDto> GetPatient(int id)
        {
            var patient = _patientService.GetPatientById(id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        public ActionResult CreatePatient(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                _patientService.CreatePatient(patient);
                return Ok();
            }
            return Ok("Model Not Valid");
        }
        public ActionResult UpdatePatient(int id ,Patient patient)
        {
            if (id != patient.PatientId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _patientService.UpdatePatient(patient);
                return Ok(patient);
            }
            return BadRequest(patient);
        }
        public ActionResult DeletePatient(int id) { 
            _patientService.DeletePatient(id);
            return Ok();
        }

    }
}
