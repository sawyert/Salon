using System;
namespace Salon.Models
{
    public class ImageSalonViewModel
    {
        public ImageSalonViewModel()
        {

        }

        public int AcceptanceNumber { get; set; }
        public int ImageNumber { get; set; }
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

        public bool IsDigital { get { return this.IsPrint == false; } }
    }
}
