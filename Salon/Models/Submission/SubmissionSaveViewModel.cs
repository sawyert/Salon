using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionSaveViewModel : CreateBaseViewModel
    {
        public bool SubmissionCreated { get; set; }
        public int? SalonYearId { get; set; }
        public int? CircuitId { get; set; }

        public DateTime EntryDate { get; set; }
        public decimal Cost { get; set; }

        public List<SubmissionSaveSectionViewModel> Sections { get; set; }

    }
}
