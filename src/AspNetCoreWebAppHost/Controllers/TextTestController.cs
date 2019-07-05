using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebAppHost.Controllers
{
    [Route("api/Test")]
    [ApiController]
    public class TextTestController : ControllerBase, ITestCaseAppService
    {
        [HttpGet]
        [Route("Text")]
        public async Task<string> TextOutput() => await Task.FromResult("this is text output");

        [HttpGet]
        [Route("Json")]
        public async Task<TextDto> GetTextDtoOutput() => await Task.FromResult(new TextDto() { Id = 1, Name = "alice" });
    }

    public interface ITestCaseAppService
    {
        Task<string> TextOutput();

        Task<TextDto> GetTextDtoOutput();
    }

    [Serializable]
    public class TextDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
