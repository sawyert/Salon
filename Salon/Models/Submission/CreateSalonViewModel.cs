using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CreateSalonViewModel : CreateBaseViewModel
    {
        public string SalonName { get; set; }
        public int CountryId { get; set; }
        public string Website { get; set; }
    }
}
