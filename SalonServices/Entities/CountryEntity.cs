using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class CountryEntity : AbstractEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual List<SalonEntity> Salons { get; set; }
    }
}
