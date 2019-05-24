using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto.Submission
{
    public class BasicSubmissionItemDto
    {
        public int SubmissionId { get; set; }
        public string SalonName { get; set; }
        public string CountryName { get; set; }

        public int NumberOfEntries { get; set; }
    }
}
