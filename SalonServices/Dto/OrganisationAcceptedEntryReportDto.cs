using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto
{
    public class OrganisationAcceptedEntryReportDto
    {
        public string SalonName { get; set; }
        public string SalonNumber { get; set; }
        public string SalonYear { get; set; }
        public string ImageName { get; set; }
        public string AwardName { get; set; }
        public string SalonCountry { get; set; }
        public bool IsPrint { get; set; }
    }
}
