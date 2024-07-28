using Microsoft.AspNetCore.Mvc;
using Your_Health.Server.Models;
using Your_Health.server.Services;

public class DoctorsController : Controller
{
    private readonly IDoctorService _doctorService;

    public DoctorsController(IDoctorService doctorService)
    {
        _doctorService = doctorService;
    }


    public IActionResult Index()
    {
        return Ok("App Works");
    }

    public IActionResult GetDoctors()
    {
        var doctors = _doctorService.GetAllDoctors();
        return Ok(doctors);
    }
    public IActionResult GetDoctor(int id)
    {
        var doctor = _doctorService.GetDoctorById(id);
        if (doctor == null)
        {
            return NotFound();
        }
        return Ok(doctor);
    }

    
    [HttpPost]
    public IActionResult Create(Doctor doctor)
    {
        if (ModelState.IsValid)
        {
            _doctorService.CreateDoctor(doctor);
            return Ok(doctor);
        }
        return Ok("Model Not Valid");
    }


    [HttpPost]
    public IActionResult Edit(int id, Doctor doctor)
    {
        if (id != doctor.DocId)
        {
            return BadRequest();
        }

        if (ModelState.IsValid)
        {
            _doctorService.UpdateDoctor(doctor);
            return Json("Updated" , doctor);
        }
        return BadRequest(doctor);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _doctorService.DeleteDoctor(id);
        return Ok("Deleted");
    }
}
