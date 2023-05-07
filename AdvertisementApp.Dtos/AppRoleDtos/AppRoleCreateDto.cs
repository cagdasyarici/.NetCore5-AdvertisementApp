using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvertisementApp.Dtos.Interfaces;

namespace AdvertisementApp.Dtos.AppRoleDtos
{
    public class AppRoleCreateDto : IDto
    {
        public string Definition { get; set; }
    }
}
