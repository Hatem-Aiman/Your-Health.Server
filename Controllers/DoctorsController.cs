using Microsoft.AspNetCore.Mvc;
using Your_Health.Server.Models;
using Your_Health.server.Services;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Immutable;

public class DoctorsController : Controller
{
    private readonly IDoctorService _doctorService;
    private readonly ISpecialityService _specialityService;

    public DoctorsController(IDoctorService doctorService, ISpecialityService specialityService)
    {
        _doctorService = doctorService;
        _specialityService = specialityService;
    }


    public IActionResult Index()
    {
        return Ok("App Works");
    }

    [HttpGet]
    public async Task<IActionResult> GetDoctors()
    {
        var doctors =await _doctorService.GetAllDoctors();
        return Ok(doctors);
    }
    public async Task<IActionResult> GetDoctor(int id)
    {
        var doctor =await _doctorService.GetDoctorById(id);
        if (doctor == null)
        {
            return NotFound();
        }
        return Ok(doctor);
    }


    [HttpPost]
    public IActionResult CreateDoctor(string DocFirstName, string DocLastName , string  email, int phone, string speciality)
    {
        var specId = _specialityService.GetAllSpecialities().Where(c => c.SpecialityName == speciality).Select(c => c.SpecialityId);
        var newdoc = new Doctor
        {
            DocFirstName = DocFirstName,
            DocLastName = DocLastName,
            email = email,
            phone = phone,
            SpecialityId = specId.First()
        };
             Console.WriteLine(newdoc);
            _doctorService.CreateDoctor(newdoc);
            return Ok(newdoc);
    }


    [HttpPost]
    public IActionResult UpdateDoctor(int id, Doctor doctor)
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
    public IActionResult DeleteDoctor(int id)
    {
        _doctorService.DeleteDoctor(id);
        return Ok("Deleted");
    }
}
