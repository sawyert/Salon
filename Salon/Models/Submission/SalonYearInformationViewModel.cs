using Salon.Models.Submission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class SalonYearInformationViewModel
    {
        public SalonYearInformationViewModel()
        {
            Accreditations = new List<SalonYearAccreditationViewModel>();
        }

        public int SalonId { get; set; }
        public int SalonYearId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime CataloguesPostedDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime JudgeDate { get; set; }
        public DateTime NotificationDate { get; set; }

        public List<SalonYearAccreditationViewModel> Accreditations { get; set; }
    }
}
