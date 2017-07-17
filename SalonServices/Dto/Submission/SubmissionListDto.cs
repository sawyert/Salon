using System.Collections.Generic;

namespace SalonServices.Dto.Submission
{
    public class SubmissionListDto
    {
        public SubmissionListDto()
        {
            Items = new List<SubmissionItemDto>();
        }
        public int PersonId { get; set; }
        public List<SubmissionItemDto> Items { get; set; }
    }
}
