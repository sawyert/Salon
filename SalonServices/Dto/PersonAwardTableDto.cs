using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto
{
    public class PersonAwardTableDto
    {
        public PersonAwardTableDto()
        {
            Organisations = new List<PersonAwardTableOrgDto>();
        }

        public string PersonName { get; set; }
        public List<PersonAwardTableOrgDto> Organisations { get; set; }

    }
}
