using SalonServices.Dto.Submission;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface ISubmissionRepository : IGenericRepository<SubmissionEntity>
    {
        Task<SubmissionResultsDto> GetSubmissionResults(int pSubmissionId);

        Task<SubmissionEntity> GetSubmissionWithEntries(int pSubmissionId);

        Task<List<SubmissionListItemDto>> GetBasicSubmissionInfoByPersonId(int pPersonId);

    }
}
