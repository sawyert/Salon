using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class IndexViewModel
    {
        public string SuccessMessage { get; set; }
        public string FailureMessage { get; set; }

        public List<CountryViewModel> Countries { get; set; }
    }
}
