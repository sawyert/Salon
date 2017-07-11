using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class ImageEntity : AbstractEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Notes { get; set; }

        public List<CompetitionEntryEntity> Entries { get; set; }

        public int PersonId { get; set; }
        public virtual PersonEntity Person { get; set; }
    }
}
