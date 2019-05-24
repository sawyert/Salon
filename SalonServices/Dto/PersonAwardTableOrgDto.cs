using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto
{
    public class PersonAwardTableOrgDto
    {
        public PersonAwardTableOrgDto()
        {
            Awards = new List<PersonAwardTableRowDto>();
        }

        public string OrginisationName { get; set; }
        public List<PersonAwardTableRowDto> Awards { get; set; }
    }
}
