using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionSaveSectionImagesViewModel
    {
        public int? ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageNotes { get; set; }
        public IFormFile ImageThumbnail { get; set; }
    }
}
