using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class SubmissionSaveSectionDto
    {
        public int SectionTypeId { get; set; }
        public List<SubmissionSaveSectionImagesDto> Images { get; set; }
    }
}
