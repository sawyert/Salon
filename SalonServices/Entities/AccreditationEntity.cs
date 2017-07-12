using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class AccreditationEntity : AbstractEntity
    {       

        [Required]
        [MaxLength(20)]
        public string SalonNumber { get; set; }

        public int PhotoOrganisationId { get; set; }

        public virtual PhotoOrganisationEntity PhotoOrganisation { get; set; }

        public int SalonYearId { get; set; }
        
        public virtual SalonYearEntity SalonYear { get; set; }


    }
}
