using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Models
{
    public class PersonAwardTableViewModel
    {
        public PersonAwardTableViewModel()
        {
            Organisations = new List<PersonAwardTableOrgViewModel>();
        }

        public string PersonName { get; set; }
        public List<PersonAwardTableOrgViewModel> Organisations { get; set; }

    }
}
