using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class SalonEntity : AbstractEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Website { get; set; }

        public int CountryId { get; set; }
        public virtual CountryEntity Country { get; set; }

        public virtual List<SalonYearEntity> SalonYears { get; set; }
    }
}
