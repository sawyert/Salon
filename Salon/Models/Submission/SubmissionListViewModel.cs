using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models.Submission
{
    public class SubmissionListViewModel
    {
        public SubmissionListViewModel()
        {
            Items = new List<SubmissionListItemViewModel>();
        }
        public int PersonId { get; set; }
        public List<SubmissionListItemViewModel> Items { get; set; }
    }
}
