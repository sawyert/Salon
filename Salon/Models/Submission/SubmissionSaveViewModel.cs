using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionSaveViewModel : CreateBaseViewModel, IValidatableObject
    {
        public bool SubmissionCreated { get; set; }
        public int? SalonYearId { get; set; }
        public int? CircuitId { get; set; }

        public int PersonId { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
        public decimal Cost { get; set; }
        public string Notes { get; set; }

        public List<SubmissionSaveSectionViewModel> Sections { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (!this.SalonYearId.HasValue && !this.CircuitId.HasValue)
            {
                results.Add(new ValidationResult("Either a salon year or circuit must be selected", new List<string> { nameof(this.SalonYearId) }));
            }
            return results;
        }
    }
}
