using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace TestingAbpWeb.Controllers
{
    public class TextOutputController : AbpController
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