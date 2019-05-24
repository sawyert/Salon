using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class CreateSalonDto : CreateBaseDto
    {
        public int? SalonId { get; set; }
        public string SalonName { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public string Website { get; set; }
    }
}
