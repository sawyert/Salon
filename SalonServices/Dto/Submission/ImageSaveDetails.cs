using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto.Submission
{
    public class ImageSaveDetails
    {
        public string FileName { get; set; }
        public byte[] ImageContent { get; set; }
    }
}
