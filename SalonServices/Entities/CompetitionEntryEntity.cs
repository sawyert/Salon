using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class CompetitionEntryEntity : AbstractEntity
    {
        public int SectionId { get; set; }
        public virtual SectionEntity Section { get; set; }

        public int ImageId { get; set; }
        public virtual ImageEntity Image { get; set; }

        public bool? IsAwarded { get; set; }
        [MaxLength(100)]
        public string AwardDetails { get; set; }
        public bool? IsAccepted { get; set; }

        public int? Score { get; set; }
    }
}
