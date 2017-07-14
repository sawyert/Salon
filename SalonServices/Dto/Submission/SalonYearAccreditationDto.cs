using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class SalonYearAccreditationDto
    {
        public int Id { get; set; }
        public string SalonNumber { get; set; }
        public int PhotoOrganisationId { get; set; }
    }
}
