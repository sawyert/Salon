using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Salon.Models
{
    public class SectionTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(ResourceType = typeof(Strings), Name = "SectionType_IsPrint")]

        public bool IsPrint { get; set; }
        [Display(ResourceType = typeof(Strings), Name = "SectionType_SectionCode")]

        public string SectionCode { get; set; }
    }
}
