using System;
using System.Collections.Generic;

namespace Salon.Models
{
    public class ImageViewModel
    {
        public ImageViewModel()
        {
        }

        public string Name { get; set; }
        public List<ImageSalonViewModel> SalonEntries { get; set; }
    }
}
