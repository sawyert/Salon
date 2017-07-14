using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class SectionTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPrint { get; set; }
        public string SectionCode { get; set; }
    }
}
