using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public abstract class CreateBaseViewModel
    {
        public CreateBaseViewModel()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
    }
}
