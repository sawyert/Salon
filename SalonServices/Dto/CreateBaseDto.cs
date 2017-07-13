using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonServices.Dto
{
    public abstract class CreateBaseDto
    {
        public CreateBaseDto()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
    }
}
