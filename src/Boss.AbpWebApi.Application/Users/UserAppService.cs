using System;
using System.Linq;
using System.Threading.Tasks;
using Boss.AbpWebApi.Application.Contracts;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Boss.AbpWebApi.Application.Users
{
    public class UserAppService : ApplicationService, IUserAppService
    {
        public Task<UserDto> GetAsync(long id)
        {
            var user = UserDto.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                throw new UserFriendlyException($"cann't find id: {id} user.","app:404");
            }

            return Task.FromResult(user);
        }

        public async Task<UserDto> CreateAsync(UserDto input)
        {
            var user = input;
            user.Id = DateTime.Now.Ticks;

            return await Task.FromResult(user);
        }
    }
}