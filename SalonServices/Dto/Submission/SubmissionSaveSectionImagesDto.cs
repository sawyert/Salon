
namespace SalonServices.Dto.Submission
{
    public class SubmissionSaveSectionImagesDto
    {
        public int? ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageNotes { get; set; }
        public byte[] ImageThumbnail { get; set; }
    }
}
