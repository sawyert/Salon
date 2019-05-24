using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class SectionTypeIndexViewModel
    {
        public string SuccessMessage { get; set; }
        public string FailureMessage { get; set; }

        public List<SectionTypeViewModel> SectionTypes { get; set; }
    }
}
