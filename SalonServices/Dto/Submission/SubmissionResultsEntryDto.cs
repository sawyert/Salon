using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto.Submission
{
    public class SubmissionResultsEntryDto
    {
        public int Id { get; set; }
        public string ImageName { get; set; }

        public bool? IsAwarded { get; set; }
        public string AwardDetails { get; set; }
        public bool? IsAccepted { get; set; }
        public int? Score { get; set; }
    }
}
