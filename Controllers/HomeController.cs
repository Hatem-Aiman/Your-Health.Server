using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Your_Health.server.Models;

namespace Your_Health.server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("App Works");
        }
    }
}
