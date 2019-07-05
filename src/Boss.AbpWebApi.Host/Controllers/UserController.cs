using System.Threading.Tasks;
using Boss.AbpWebApi.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Boss.AbpWebApi.Host.Controllers
{
    [RemoteService()]
    [Area("AbpWebApi")]
    [Route("api/Test")]
    public class UserController : AbpController,IUserAppService
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        [Route("GetUserById")]
        public async Task<UserDto> GetAsync(long id)
        {
           return await _userAppService.GetAsync(id);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<UserDto> CreateAsync(UserDto input)
        {
            return await _userAppService.CreateAsync(input);

        }
    }
}
