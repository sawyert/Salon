using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CreateSalonYearViewModel : CreateBaseViewModel
    {
        public int SalonId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime CataloguesPostedDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime JudgeDate { get; set; }
        public DateTime NotificationDate { get; set; }
   
    }
}
