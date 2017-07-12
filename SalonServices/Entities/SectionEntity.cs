using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class SectionEntity : AbstractEntity
    {
        public int SalonYearId { get; set; }
        public virtual SalonYearEntity SalonYear { get; set; }

        public List<CompetitionEntryEntity> Entries { get; set; }

        public int SectionTypeId { get; set; }

        public virtual SectionTypeEntity SectionType { get; set; }
    }
}
