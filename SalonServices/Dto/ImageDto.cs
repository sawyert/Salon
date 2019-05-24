using System;
using System.Collections.Generic;

namespace SalonServices.Dto
{
    public class ImageDto
    {
        public ImageDto()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public List<ImageSalonEntryDto> SalonEntries { get; set; }
    }
}
