using SalonServices.Dto.Submission.Submission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class SalonYearInformationDto
    {
        public SalonYearInformationDto()
        {
            Accreditations = new List<SalonYearAccreditationDto>();
        }

        public int SalonId { get; set; }
        public int SalonYearId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime CataloguesPostedDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime JudgeDate { get; set; }
        public DateTime NotificationDate { get; set; }

        public List<SalonYearAccreditationDto> Accreditations { get; set; }
    }
}
