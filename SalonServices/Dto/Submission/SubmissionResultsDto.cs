using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class SubmissionResultsDto
    {
        public SubmissionResultsDto()
        {
            Entries = new List<SubmissionResultsEntryDto>();
        }

        public string DisplayName { get; set; }
        public int SubmissionId { get; set; }
        public IEnumerable<SubmissionResultsEntryDto> Entries { get; set; }
    }
}
