using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        public HelloWorldController()
        {}

        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Content("Response from the Test() method in the HelloWorldController");
        }
        
        public IActionResult Index()
        {
            return Content("Response from the Index() method in the HelloWorldController");
        }

    }
}
