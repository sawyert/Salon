using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class SubmissionSaveDto : CreateBaseDto
    {
        public bool SubmissionCreated { get; set; }
        public int? SalonYearId { get; set; }
        public int? CircuitId { get; set; }
        public int PersonId { get; set; }

        public DateTime EntryDate { get; set; }
        public decimal Cost { get; set; }

        public string Notes { get; set; }


        public List<SubmissionSaveSectionDto> Sections { get; set; }

    }
}
