using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisementApp.Dtos;
using AdvertisementApp.UI.Models;

namespace AdvertisementApp.UI.Mappings.AutoMapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>();
        }
    }
}
