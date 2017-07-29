using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SalonServices.Dto
{
    public class OrganisationSubmissionReportDto
    {
        public List<OrganisationAcceptedEntryReportDto> AcceptedEntries { get; internal set; }

        public List<string> AcceptedImages { get { return this.AcceptedEntries.Select(ent => ent.ImageName).ToList(); } }
    }
}
