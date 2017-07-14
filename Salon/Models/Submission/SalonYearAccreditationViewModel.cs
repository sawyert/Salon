using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SalonYearAccreditationViewModel
    {
        public int Id { get; set; }
        public string SalonNumber { get; set; }
        public int PhotoOrganisationId { get; set; }
    }
}
