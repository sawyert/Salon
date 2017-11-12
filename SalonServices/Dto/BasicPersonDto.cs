using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto
{
    public class BasicPersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CostPerAcceptance { get; set; }
        public decimal TotalCost { get; set; }
        public int UnjudgedSalonCount { get; set; }
        public int UnjudgedImageCount { get; set; }
    }
}
