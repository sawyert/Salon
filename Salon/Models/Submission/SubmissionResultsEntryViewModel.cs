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
        public int ImageId { get; set; }
        public string SectionName { get; set; }
        [Display(ResourceType =typeof(Strings), Name = "Submission_IsAwarded")]
        [Required]
        public bool IsAwarded { get; set; }
        [Display(ResourceType = typeof(Strings), Name = "Submission_AwardDetails")]
        [MaxLength(100)]
        public string AwardDetails { get; set; }
        [Display(ResourceType = typeof(Strings), Name = "Submission_IsAccepted")]
        [Required]
        public bool IsAccepted { get; set; }
        [Required]
        public int? Score { get; set; }
    }
}
