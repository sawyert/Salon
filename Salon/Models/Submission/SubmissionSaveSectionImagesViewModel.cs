using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionSaveSectionImagesViewModel : IValidatableObject
    {
        public int? ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageNotes { get; set; }
        public IFormFile ImageThumbnail { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            // No previous image and new image info empty (image name or thumbnail no value)
            if (!this.ImageId.HasValue && (string.IsNullOrWhiteSpace(this.ImageName) || this.ImageThumbnail == null))                
            {
                results.Add(new ValidationResult("Either an existing image or new image informration must be supplied", new List<string> { nameof(this.ImageThumbnail) }));
            }
            return results;
        }
    }
}
