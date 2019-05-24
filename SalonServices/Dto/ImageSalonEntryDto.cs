using System;
namespace SalonServices.Dto
{
    public class ImageSalonEntryDto
    {
        public ImageSalonEntryDto()
        {
        }

        public DateTime JudgeDate { get; set; }
        public string SalonName { get; set; }
        public string SectionName { get; set; }
        public bool IsAwarded { get; set; }
		public string AwardDetails { get; set; }
		public bool IsAccepted { get; set; }
        public int? Score { get; set; }
        public string ImageTitle { get; set; }
        public int ImageId { get; set; }
        public string Country { get; set; }
        public string OrganisationAccreditationNumber { get; set; }
        public bool IsPrint { get; set; }
    }
}
