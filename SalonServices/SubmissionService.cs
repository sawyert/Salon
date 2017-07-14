using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;
using SalonServices.Repositories;

namespace SalonServices
{
    public class SubmissionService : ISubmissionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ISubmissionRepository _submissionRepository;

        public SubmissionService(ISectionRepository pSectionRepository, ISubmissionRepository pSubmissionRepository)
        {
            this._sectionRepository = pSectionRepository;
            this._submissionRepository = pSubmissionRepository;
        }

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
