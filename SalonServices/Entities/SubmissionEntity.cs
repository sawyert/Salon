using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class SubmissionEntity : AbstractEntity
    {
        public SubmissionEntity()
        {
            Entries = new List<CompetitionEntryEntity>();
        }

        [Required]
        public DateTime EntryDate { get; set; }

        [MaxLength(1000)]
        public string Notes { get; set; }

        public bool IsJudged { get; set; }

        [Column(TypeName ="Money")]
        public decimal EntryCost {get; set;}

        public int SalonYearId { get; set; }
        public virtual SalonYearEntity SalonYear { get; set; }
        
        public int PersonId { get; set; }
        public virtual PersonEntity Person { get; set; }

        public virtual List<CompetitionEntryEntity> Entries { get; set; }
    }
}
