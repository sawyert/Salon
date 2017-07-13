using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SalonYearSectionInfoViewModel
    {
        public int SectionTypeId { get; set; }

        public List<SalonYearSectionEntryInfoViewModel> Entries { get; set; }
    }
}
