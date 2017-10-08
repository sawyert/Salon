using System;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Models
{
    public class ImageViewModel
    {
        public ImageViewModel()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<ImageSalonViewModel> SalonEntries { get; set; }

		public List<ImageSalonViewModel> AcceptedEntries()
		{
            var lReturn = this.SalonEntries.Where(itm => itm.IsAccepted == true).OrderByDescending(itm => itm.JudgeDate).ToList();
			return lReturn;
		}

        public List<ImageSalonViewModel> AwardedEntries()
        {
            var lReturn = this.SalonEntries.Where(itm => itm.IsAwarded == true).OrderByDescending(itm => itm.JudgeDate).ToList();
            return lReturn;
        }
    }
}
