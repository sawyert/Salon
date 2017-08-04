using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int SalonCount { get; set; }
        public int Number {get; set;}
    }
}
