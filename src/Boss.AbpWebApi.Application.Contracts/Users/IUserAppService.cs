using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Boss.AbpWebApi.Application.Contracts
{
    public interface IUserAppService : IApplicationService
    {
        Task<UserDto> GetAsync(long id);

        Task<UserDto> CreateAsync(UserDto input);
    }

    public class UserDto
    {
        public long? Id { get; set; }

        public string Name { get; set; }


        public static IEnumerable<UserDto> Users => new List<UserDto>()
        {
            new UserDto(){Id = 1,Name = "alice"},
            new UserDto(){Id = 2,Name = "bob"},
            new UserDto(){Id = 3,Name = "chris"},
        };
    }
}