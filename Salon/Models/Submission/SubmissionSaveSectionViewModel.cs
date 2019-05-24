using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionSaveSectionViewModel
    {
        public int SectionTypeId { get; set; }
        public List<SubmissionSaveSectionImagesViewModel> Images { get; set; }
    }
}
