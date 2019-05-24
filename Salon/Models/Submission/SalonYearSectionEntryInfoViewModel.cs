using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SalonYearSectionEntryInfoViewModel
    {
        public int EntryId { get; set; }
        public List<SalonYearSectionEntryImageInfoViewModel> Images { get; set; }
    }
}
