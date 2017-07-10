using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class SectionEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual SalonYearEntity SalonYear { get; set; }

        public List<CompetitionEntryEntity> Entries { get; set; }

        public virtual SectionTypeEntity SectionType { get; set; }
    }
}
