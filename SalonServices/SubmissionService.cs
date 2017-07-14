using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;

namespace SalonServices
{
    public class SubmissionService : ISubmissionService
    {
        public Task<SubmissionSaveDto> CreateSubmission(SubmissionSaveDto pCreateSubmission)
        {
            throw new NotImplementedException();
        }

        public Task<SubmissionResultsDto> GetSubmissionResults(int pSubmissionId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSubmissionResults(SubmissionResultsDto pSubmissionResults)
        {
            throw new NotImplementedException();
        }
    }
}
