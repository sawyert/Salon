using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Dto
{
    public class PersonAwardTableRowDto
    {
        public string AwardName { get; set; }

        public int AcceptancesMissing { get; set; }
        public int CountriesMissing { get; set; }
        public int AwardsMissing { get; set; }
        public int DistinctImagesMissing { get; set; }
        public int SalonsMissing { get; set; }
        public int PrintsMissing { get; set; }

        public bool IsAwarded { get {
                return AcceptancesMissing == 0 && CountriesMissing == 0 && AwardsMissing == 0 && DistinctImagesMissing == 0 && SalonsMissing == 0 && PrintsMissing == 0;
            }
        }
    }
}
