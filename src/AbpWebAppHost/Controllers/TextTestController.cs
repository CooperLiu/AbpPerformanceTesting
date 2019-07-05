using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpWebAppHost.Controllers
{
    [RemoteService()]
    [Area("AbpWebApi")]
    [Route("api/Test/Text")]
    public class TextTestController : AbpController, ITestCaseAppService
    {
        [HttpGet]
        [Route("Text")]
        public async Task<string> TextOutput() => await Task.FromResult("this is text output");


        [HttpGet]
        [Route("Json")]
        public async Task<TextDto> GetTextDtoOutput() => await Task.FromResult(new TextDto() { Id = 1, Name = "alice" });

    }

    public interface ITestCaseAppService : IApplicationService
    {
        Task<string> TextOutput();
    }

    [Serializable]
    public class TextDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
