using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class SubmissionListItemDto
    {
        public int SubmissionId { get; set; }
        public string DisplayName { get; set; }
        public string CountryName { get; set; }
        public int NumberOfEntries { get; set; }
        public DateTime EntryDate { get; set; }
        public bool HasAccepted { get; set; }
        public bool IsJudged { get; set; }
        public String JudgeDate { get; set; }
        public String NotificationDate { get; set; }
        public String AccreditationNumbers { get; set; }
        public int AcceptedCount { get; set; }
        public string SalonUrl { get; set; }
    }
}
