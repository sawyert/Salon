﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalonServices.Entities
{
    public class SectionTypeEntity : AbstractEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public bool IsPrint { get; set; }

        public string SectionCode { get; set; }
    }
}
