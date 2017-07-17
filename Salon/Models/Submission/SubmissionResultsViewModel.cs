
using System.Collections.Generic;

namespace Salon.Models.Submission
{
    public class SubmissionResultsViewModel
    {
        public SubmissionResultsViewModel()
        {
            Entries = new List<SubmissionResultsEntryViewModel>();
        }

        public string DisplayName { get; set; }

        public int SubmissionId { get; set; }

        public List<SubmissionResultsEntryViewModel> Entries { get; set; }

        public bool ResultsUpdated { get; set; }
    }
}
