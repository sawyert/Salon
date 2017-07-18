using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class SalonYearEntity : AbstractEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public int Year { get; set; }

        public DateTime ClosingDate { get; set; }
        public DateTime JudgeDate { get; set; }
        public DateTime NotificationDate { get; set; }
        public DateTime CataloguesPostedDate { get; set; }

        public int SalonId { get; set; }

        public virtual SalonEntity Salon {get; set;}

        public virtual List<AccreditationEntity> Accreditations { get; set; }

        public int? CircuitId { get; set; }
        public virtual CircuitEntity Circuit { get; set; }
    }
}
