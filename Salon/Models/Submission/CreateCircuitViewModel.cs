﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CreateCircuitViewModel : CreateBaseViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
