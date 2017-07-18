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
        public int NumberOfEntries { get; set; }
    }
}
