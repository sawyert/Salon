using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CreateCountryViewModel
    {
        public CreateCountryViewModel()
        {
            Errors = new List<string>();
        }

        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<string> Errors { get; set; }
    }
}
