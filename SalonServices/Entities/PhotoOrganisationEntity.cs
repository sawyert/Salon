using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class PhotoOrganisationEntity : AbstractEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public bool EnableSectionTypes { get; set; }

        public virtual List<AccreditationEntity> AccreditedSalons { get; set; }

        public virtual List<AwardLevelEntity> AwardLevels { get; set; }


    }
}
