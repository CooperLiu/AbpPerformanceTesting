using Microsoft.AspNetCore.Mvc;

namespace TestingDotnetCoreWeb.Controllers
{
    public class TextOutputController : Controller
    {
        private const string OutputString = "hello world";

        // GET
        [HttpGet]
        [Route("api/output/text")]
        public IActionResult Index()
        {
            return Ok(OutputString);
        }

        [HttpGet]
        [Route("api/output/json")]
        public object GetJsonAsync()
        {
            return new { OutputString };
        }
    }
}