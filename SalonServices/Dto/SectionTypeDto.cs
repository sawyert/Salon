using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto
{
    public class SectionTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPrint { get; set; }
        public string SectionCode { get; set; }
    }
}
