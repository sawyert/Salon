using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission.Submission
{
    public class SubmissionSaveSectionImagesDto
    {
        public int? ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageNotes { get; set; }
        public IFormFile ImageThumbnail { get; set; }
    }
}
