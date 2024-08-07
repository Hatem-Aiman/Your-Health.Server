using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Your_Health.server.Services;
using Your_Health.Server.Models;

namespace Your_Health.server.Controllers
{
    public class SpecialitiesController : Controller
    {
        private readonly ISpecialityService _specialityService;
        public SpecialitiesController(ISpecialityService specialityService)
        {
            _specialityService = specialityService;
        }

        public ActionResult Index()
        {
            return Ok("Works");
        }

        public ActionResult GetSpecialities()
        {
            var result = _specialityService.GetAllSpecialities();
            return Ok(result);
        }

        public ActionResult GetSpeciality(int id)
        {
            var result = _specialityService.GetSpecialityById(id);
            return Ok(result);
        }


        [HttpPost]
        public ActionResult CreateSpeciality(string SpecialityName)
        {
            if (SpecialityName == null)
            {
                return BadRequest("Provide a Name");
            }
                _specialityService.CreateSpeciality(SpecialityName);
                return Ok(SpecialityName);
        }
 
        public ActionResult Update(int id, Speciality speciality)
        {
            if (id != speciality.SpecialityId)
            {
                return BadRequest();
            }
            return Ok("Updated");
        }

        public ActionResult Delete(int id, Speciality speciality)
        {
            if (id != speciality.SpecialityId)
            {
                return BadRequest();
            }
            return Ok("Deleted");
        }
    }
}
