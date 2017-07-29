using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionListItemViewModel
    {
        public int SubmissionId { get; set; }
        public string DisplayName { get; set; }
        public string CountryName { get; set; }
        public int NumberOfEntries { get; set; }
        public DateTime EntryDate { get; set; }
        public bool HasAccepted { get; set; }
        public bool IsJudged { get; set; }

        public int AcceptedCount { get; set; }
        public double AcceptedPercent { get { return this.AcceptedCount * 100.0 / this.NumberOfEntries; } }
    }
}
