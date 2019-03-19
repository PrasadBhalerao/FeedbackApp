using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackApp.Controllers
{
    [Route("api/hello")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello Angular4 and ASP.NET Core from Windows 10");
        }
    }
}
