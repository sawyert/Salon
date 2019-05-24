using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Models
{
    public class PersonAwardTableOrgViewModel
    {
        public PersonAwardTableOrgViewModel()
        {
            Awards = new List<PersonAwardTableRowViewModel>();
        }

        public string OrginisationName { get; set; }
        public List<PersonAwardTableRowViewModel> Awards { get; set; }
    }
}
