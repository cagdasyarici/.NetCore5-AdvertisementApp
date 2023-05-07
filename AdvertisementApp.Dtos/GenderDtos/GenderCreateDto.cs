using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvertisementApp.Dtos.Interfaces;

namespace AdvertisementApp.Dtos
{
    public class GenderCreateDto : IDto
    {
        public string Definition { get; set; }
    }
}
