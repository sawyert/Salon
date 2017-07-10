using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class AccreditationEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string SalonNumber { get; set; }

        public virtual PhotoOrganisationEntity PhotoOrganisation { get; set; }

        public virtual SalonYearEntity SalonYear { get; set; }


    }
}
