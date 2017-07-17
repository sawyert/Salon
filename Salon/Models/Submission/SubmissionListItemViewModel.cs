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
        public int NumberOfEntries { get; set; }
    }
}
