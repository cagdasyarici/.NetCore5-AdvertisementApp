using System.Collections.Generic;
using System.Threading.Tasks;
using AdvertisementApp.Common;
using AdvertisementApp.Dtos;
using AdvertisementApp.Entities;

namespace AdvertisementApp.Business.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>
    {
        Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
        Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLoginDto dto);

        Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId);
    }
}
