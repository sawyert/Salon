using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionResultsEntryViewModel
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        [Required]
        public bool? IsAwarded { get; set; }
        [Required]
        public bool? IsAccepted { get; set; }
        [Required]
        public int? Score { get; set; }
    }
}
