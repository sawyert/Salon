using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto.Submission
{
    public class CreateSalonYearDto : CreateBaseDto
    {
        public int? Id { get; set; }
        public int SalonId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime CataloguesPostedDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime JudgeDate { get; set; }
        public DateTime NotificationDate { get; set; }
   
    }
}
