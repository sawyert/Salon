using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class AwardLevelEntity : AbstractEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int MinimumAcceptances { get; set; }
        public int MinimumCountries { get; set; }
        public int MinimumAwards { get; set; }
        public int MinimumDistinctImages { get; set; }
        public int MinimumSalons { get; set; }
        public int MinimumPrints { get; set; }
      
        public int PhotoOrganisationId { get; set; }
        public virtual PhotoOrganisationEntity PhotoOrganisation { get; set; }

    }
}
