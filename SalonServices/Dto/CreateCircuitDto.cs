using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto
{
    public class CreateCircuitDto : CreateBaseDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
